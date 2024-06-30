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
    public sealed class RowObject : RowObjectBase, IEquatable<RowObject>
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
        /// <returns>A <see cref="RowObject"/></returns>
        public static RowObject Initialize() { return new RowObject(); }

        /// <summary>
        /// Initializes a <see cref="RowObjectBuilder"/> to help construct a <see cref="RowObject"/>.
        /// The implementation must set the RowId before build may be completed.
        /// <code>
        /// // Sample usage
        /// RowObject rowObject = RowObject.Builder()
        ///                                .RowId("1||2")
        ///                                .ParentRowId("1||1")
        ///                                .Field(fieldObject)
        ///                                .Field().FieldNumber("123.45").FieldValue("Sample").Enabled().AddField()
        ///                                .Add()  // Sets RowAction to "ADD"
        ///                                .Build();
        /// </code>
        /// </summary>
        /// <returns>A <see cref="RowObject"/></returns>
        public static RowObjectBuilder Builder() { return new RowObjectBuilder(); }

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

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="RowObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="RowObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="RowObject"/> are equal.</returns>
        public bool Equals(RowObject other)
        {
            return other != null &&
                ParentRowId == other.ParentRowId &&
                ((RowAction == null && other.RowAction == null) ||
                RowAction == other.RowAction) &&
                RowId == other.RowId &&
                AreFieldsEqual(Fields, other.Fields);
        }

        /// <summary>
        /// Used to compare <see cref="RowObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="RowObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is RowObject rowObject))
                return false;
            return Equals(rowObject);
        }
        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="RowObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="RowObject"/>.</returns>
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (ParentRowId != null ? ParentRowId.GetHashCode() : 0);
            hash = hash * 23 + (RowAction != null ? RowAction.GetHashCode() : 0);
            hash = hash * 23 + (RowId != null ? RowId.GetHashCode() : 0);
            foreach (FieldObject fieldObject in Fields)
            {
                hash = hash * 23 + (fieldObject != null ? fieldObject.GetHashCode() : 0);
            }
            return hash;
        }

        private static bool AreFieldsEqual(List<FieldObject> list1, List<FieldObject> list2)
        {
            if (!AreBothNull(list1, list2) && AreBothEmpty(list1, list2))
                return true;
            if (list1.Count != list2.Count)
                return false;
            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool AreBothEmpty(List<FieldObject> list1, List<FieldObject> list2) => list1.Count == 0 && list2.Count == 0;

        private static bool AreBothNull(List<FieldObject> list1, List<FieldObject> list2) => list1 == null && list2 == null;

        public static bool operator ==(RowObject rowObject1, RowObject rowObject2)
        {
            if (((object)rowObject1) == null || ((object)rowObject2) == null)
                return Equals(rowObject1, rowObject2);

            return rowObject1.Equals(rowObject2);
        }

        public static bool operator !=(RowObject rowObject1, RowObject rowObject2)
        {
            if (((object)rowObject1) == null || ((object)rowObject2) == null)
                return !Equals(rowObject1, rowObject2);

            return !rowObject1.Equals(rowObject2);
        }

        #endregion

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
                    throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
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
            /// <param name="rowObject">The <see cref="RowObject"/> to continue building.</param>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> is provided for continuation of build.</exception>
            public RowObjectBuilderFinal(RowObject rowObject)
            {
                _rowObject = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
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
        /// <summary>
        /// A Fluent Builder for constructing a FormObject CurrentRow.
        /// </summary>
        public class CurrentRowObjectBuilder
        {
            protected readonly FormObject formObject;
            protected readonly RowObject rowObject;
            /// <summary>
            /// Constructs a CurrentRowObjectBuilder with the RowAction set to None by default.
            /// </summary>
            public CurrentRowObjectBuilder(FormObject formObject)
            {
                this.formObject = formObject ?? throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                rowObject = new RowObject()
                {
                    RowAction = ""
                };
            }
            /// <summary>
            /// Sets the RowId of the <see cref="RowObject"/> to build.
            /// This is required before any other attributes may be set on the <see cref="RowObject"/> built.
            /// </summary>
            /// <param name="rowId">Required. The RowId assigned to the <see cref="RowObject"/></param>
            /// <returns>A <see cref="CurrentRowObjectBuilderFinal"/> allowing for the setting of other attributes and building of the <see cref="RowObject"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public CurrentRowObjectBuilderFinal RowId(string rowId)
            {
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                rowObject.RowId = rowId;
                return new CurrentRowObjectBuilderFinal(rowObject, formObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a <see cref="RowObject"/> build.
        /// </summary>
        public class CurrentRowObjectBuilderFinal
        {
            protected readonly FormObject formObject;
            protected readonly RowObject rowObject;

            /// <summary>
            /// Constructs a FormObjectRowObjectBuilderFinal used to complete build of a <see cref="RowObject"/>.
            /// </summary>
            /// <param name="rowObject"></param>
            /// <exception cref="ArgumentNullException"></exception>
            public CurrentRowObjectBuilderFinal(RowObject rowObject, FormObject formObject)
            {
                this.rowObject = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                this.formObject = formObject ?? throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the RowAction to Add for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public CurrentRowObjectBuilderFinal Add()
            {
                rowObject.RowAction = Objects.RowAction.Add;
                return this;
            }
            /// <summary>
            /// Sets the RowAction to Delete for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public CurrentRowObjectBuilderFinal Delete()
            {
                rowObject.RowAction = Objects.RowAction.Delete;
                return this;
            }
            /// <summary>
            /// Sets the RowAction to Edit for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public CurrentRowObjectBuilderFinal Edit()
            {
                rowObject.RowAction = Objects.RowAction.Edit;
                return this;
            }
            /// <summary>
            /// Sets the ParentRowId for this <see cref="RowObject"/>
            /// </summary>
            /// <param name="parentRowId">The RowId of the parent RowObject</param>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public CurrentRowObjectBuilderFinal ParentRowId(string parentRowId)
            {
                rowObject.ParentRowId = parentRowId;
                return this;
            }
            /// <summary>
            /// Adds a <see cref="FieldObject"/> to the <see cref="RowObject"/>
            /// </summary>
            /// <param name="fieldObject">The <see cref="FieldObject"/> to add</param>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public CurrentRowObjectBuilderFinal Field(FieldObject fieldObject)
            {
                if (rowObject.Fields == null)
                {
                    rowObject.Fields = new List<FieldObject>();
                }
                rowObject.Fields.Add(fieldObject);
                return this;
            }
            /// <summary>
            /// Builds the <see cref="RowObject"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="RowObject"/></returns>
            public FormObject.FormObjectBuilderFinal AddRow()
            {
                formObject.CurrentRow = rowObject;
                return new FormObject.FormObjectBuilderFinal(formObject);
            }
        }
        /// <summary>
        /// A Fluent Builder for adding OtherRows to a <see cref="FormObject"/>
        /// </summary>
        public class OtherRowObjectBuilder
        {
            protected readonly FormObject formObject;
            protected readonly RowObject rowObject;
            /// <summary>
            /// Constructs a FormObjectRowObjectBuilder with the RowAction set to None by default.
            /// </summary>
            public OtherRowObjectBuilder(FormObject formObject)
            {
                this.formObject = formObject ?? throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                rowObject = new RowObject()
                {
                    RowAction = ""
                };
            }
            /// <summary>
            /// Sets the RowId of the <see cref="RowObject"/> to build.
            /// This is required before any other attributes may be set on the <see cref="RowObject"/> built.
            /// </summary>
            /// <param name="rowId">Required. The RowId assigned to the <see cref="RowObject"/></param>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> allowing for the setting of other attributes and building of the <see cref="RowObject"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OtherRowObjectBuilderFinal RowId(string rowId)
            {
                if (string.IsNullOrEmpty(rowId))
                    throw new ArgumentNullException(nameof(rowId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                rowObject.RowId = rowId;
                return new OtherRowObjectBuilderFinal(rowObject, formObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a <see cref="RowObject"/> build.
        /// </summary>
        public class OtherRowObjectBuilderFinal
        {
            protected readonly FormObject formObject;
            protected readonly RowObject rowObject;

            /// <summary>
            /// Constructs a FormObjectRowObjectBuilderFinal used to complete build of a <see cref="RowObject"/>.
            /// </summary>
            /// <param name="rowObject"></param>
            /// <exception cref="ArgumentNullException"></exception>
            public OtherRowObjectBuilderFinal(RowObject rowObject, FormObject formObject)
            {
                this.rowObject = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                this.formObject = formObject ?? throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the RowAction to Add for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public OtherRowObjectBuilderFinal Add()
            {
                rowObject.RowAction = Objects.RowAction.Add;
                return this;
            }
            /// <summary>
            /// Sets the RowAction to Delete for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public OtherRowObjectBuilderFinal Delete()
            {
                rowObject.RowAction = Objects.RowAction.Delete;
                return this;
            }
            /// <summary>
            /// Sets the RowAction to Edit for this <see cref="RowObject"/>
            /// </summary>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public OtherRowObjectBuilderFinal Edit()
            {
                rowObject.RowAction = Objects.RowAction.Edit;
                return this;
            }
            /// <summary>
            /// Sets the ParentRowId for this <see cref="RowObject"/>
            /// </summary>
            /// <param name="parentRowId">The RowId of the parent RowObject</param>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public OtherRowObjectBuilderFinal ParentRowId(string parentRowId)
            {
                rowObject.ParentRowId = parentRowId;
                return this;
            }
            /// <summary>
            /// Adds a <see cref="FieldObject"/> to the <see cref="RowObject"/>
            /// </summary>
            /// <param name="fieldObject">The <see cref="FieldObject"/> to add</param>
            /// <returns>A <see cref="OtherRowObjectBuilderFinal"/> to resume build.</returns>
            public OtherRowObjectBuilderFinal Field(FieldObject fieldObject)
            {
                if (rowObject.Fields == null)
                {
                    rowObject.Fields = new List<FieldObject>();
                }
                rowObject.Fields.Add(fieldObject);
                return this;
            }
            /// <summary>
            /// Builds the <see cref="RowObject"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="RowObject"/></returns>
            public FormObject.FormObjectBuilderMIFinal AddRow()
            {
                formObject.OtherRows.Add(rowObject);
                return new FormObject.FormObjectBuilderMIFinal(formObject);
            }
        }
    }
}