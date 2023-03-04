using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="RowObject"/> contained within a <see cref="FormObject"/>.
    /// </summary>
    public class RowObject : RowObjectBase
    {
        /// <summary>
        /// Creates a new <see cref="RowObject"/>. 
        /// </summary>
        public RowObject() : base()
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/>.
        /// </summary>
        /// <param name="rowId"></param>
        public RowObject(string rowId) : base(rowId)
        { }
        
        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="ParentRowId"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        public RowObject(string rowId, string parentRowId) : base(rowId, parentRowId)
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/>, <see cref="ParentRowId"/>, and <see cref="RowAction"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        public RowObject(string rowId, string parentRowId, string rowAction) : base(rowId, parentRowId, rowAction)
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects) : base(rowId, fieldObjects)
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        /// <param name="parentRowId"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects, string parentRowId) : base(rowId, fieldObjects, parentRowId)
        { }

        /// <summary>
        /// Creates a new <see cref="RowObject"/> with specified <see cref="RowId"/> and <see cref="List{T}"/> of <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="rowId"></param>
        /// <param name="fieldObjects"></param>
        /// <param name="parentRowId"></param>
        /// <param name="rowAction"></param>
        public RowObject(string rowId, List<FieldObject> fieldObjects, string parentRowId, string rowAction) 
            : base(rowId, fieldObjects, parentRowId, rowAction)
        { }

        /// <summary>
        /// Initializes a <see cref="RowObject"/>
        /// </summary>
        /// <returns>A <see cref="FieldObject"/></returns>
        public static RowObject Initialize()
        {
            return new RowObject();
        }

        /// <summary>
        /// Initializes a <see cref="RowObjectBuilder"/> to help construct a <see cref="RowObject"/>.
        /// The implementation must set the RowId before build may be completed.
        /// <code>
        /// // Sample usage
        /// RowObject rowObject = RowObject.Builder()
        ///                                .RowId("1||2")
        ///                                .ParentRowId("1||1")
        ///                                .Field(fieldObject)
        ///                                .Field().FieldNumber("123.45").FieldValue("Sample").Enabled().Add()
        ///                                .Add()  // Sets RowAction to "ADD"
        ///                                .Build();
        /// </code>
        /// </summary>
        /// <returns></returns>
        public static RowObjectBuilder Builder()
        {
            return new RowObjectBuilder();
        }

        /// <summary>
        /// Returns a deep copy of the <see cref="RowObject"/>.
        /// </summary>
        /// <returns></returns>
        public new RowObject Clone()
        {
            var rowObject = (RowObject)MemberwiseClone();
            rowObject.Fields = new List<FieldObject>();
            foreach (var field in Fields)
            {
                rowObject.Fields.Add(field.Clone());
            }
            return rowObject;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="RowObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="RowObject"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);

        /// <summary>
        /// Fluent Builder for contructing RowObjects
        /// </summary>
        public class RowObjectBuilder
        {
            protected readonly RowObject _rowObject;

            /// <summary>
            /// Constructs a RowObjectBuilder with the RowAction set to None by default.
            /// </summary>
            public RowObjectBuilder()
            {
                _rowObject = new RowObject()
                {
                    RowAction = ""
                };
            }
            /// <summary>
            /// Sets the RowId of the <see cref="RowObject"/> to build.
            /// This is required before any other attributes may be set on the <see cref="RowObject"/> built.
            /// </summary>
            /// <param name="rowId">Required. The RowId assigned to the <see cref="RowObject"/></param>
            /// <returns>A <see cref="RowObjectBuilderFinal"/> allowing for the setting of other attributes and building of the <see cref="RowObject"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public RowObjectBuilderFinal RowId(string rowId)
            {
                if(string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                _rowObject.RowId = rowId;
                return new RowObjectBuilderFinal(_rowObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a <see cref="RowObject"/> build.
        /// </summary>
        public class RowObjectBuilderFinal
        {
            protected readonly RowObject _rowObject;

            /// <summary>
            /// Constructs a RowObjectBuilderFinal used to complete build of a <see cref="RowObject"/>.
            /// </summary>
            /// <param name="rowObject"></param>
            /// <exception cref="ArgumentNullException"></exception>
            public RowObjectBuilderFinal(RowObject rowObject)
            {
                _rowObject = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the RowAction to Add for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="RowObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectBuilderFinal Add()
            {
                _rowObject.RowAction = Objects.RowAction.Add;
                return this;
            }
            /// <summary>
            /// Sets the RowAction to Delete for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="RowObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectBuilderFinal Delete()
            {
                _rowObject.RowAction = Objects.RowAction.Delete;
                return this;
            }
            /// <summary>
            /// Sets the RowAction to Edit for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="RowObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectBuilderFinal Edit()
            {
                _rowObject.RowAction = Objects.RowAction.Edit;
                return this;
            }
            /// <summary>
            /// Sets the ParentRowId for this <see cref="RowObject"/>
            /// </summary>
            /// <param name="parentRowId">The RowId of the parent RowObject</param>
            /// <returns>A <see cref="RowObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectBuilderFinal ParentRowId(string parentRowId)
            {
                _rowObject.ParentRowId = parentRowId;
                return this;
            }
            /// <summary>
            /// Initializes a builder to construct a FieldObject within the RowObject builder.
            /// </summary>
            /// <returns>A <see cref="RowObjectFieldObjectBuilder"/> to start <see cref="FieldObject"/> build</returns>
            public FieldObject.RowObjectFieldObjectBuilder Field()
            {
                return new FieldObject.RowObjectFieldObjectBuilder(_rowObject);
            }
            /// <summary>
            /// Adds a <see cref="FieldObject"/> to the <see cref="RowObject"/>
            /// </summary>
            /// <param name="fieldObject">The <see cref="FieldObject"/> to add</param>
            /// <returns>A <see cref="RowObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectBuilderFinal Field(FieldObject fieldObject)
            {
                if (_rowObject.Fields == null)
                {
                    _rowObject.Fields = new List<FieldObject>();
                }
                _rowObject.Fields.Add(fieldObject);
                return this;
            }
            /// <summary>
            /// Builds the <see cref="RowObject"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="RowObject"/></returns>
            public RowObject Build()
            {
                return _rowObject;
            }
        }
    }
}