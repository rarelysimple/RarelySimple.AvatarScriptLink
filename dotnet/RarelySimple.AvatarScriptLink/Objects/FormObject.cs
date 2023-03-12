using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="FormObject"/> within an <see cref="OptionObject"/>.
    /// </summary>
    public class FormObject : FormObjectBase
    {

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        public FormObject() : base()
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        public FormObject(string formId) : base(formId)
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="currentRow"></param>
        public FormObject(string formId, RowObject currentRow) : base(formId, currentRow)
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="currentRow"></param>
        /// <param name="multipleIteration"></param>
        public FormObject(string formId, RowObject currentRow, bool multipleIteration) : base(formId, currentRow, multipleIteration)
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="currentRow"></param>
        /// <param name="multipleIteration"></param>
        /// <param name="otherRows"></param>
        public FormObject(string formId, RowObject currentRow, bool multipleIteration, List<RowObject> otherRows)
            : base(formId, currentRow, multipleIteration, otherRows)
        { }
        /// <summary>
        /// Initializes a <see cref="FormObject"/>
        /// </summary>
        /// <returns>A <see cref="FormObject"/></returns>
        public static FormObject Initialize() { return new FormObject(); }
        /// <summary>
        /// Initializes a <see cref="FormObjectBuilder"/> to help construct a <see cref="FormObject"/>.
        /// The implementation must set the FormId before build may be completed.
        /// <code>
        /// // Sample usage
        /// // Assumes FieldObjects were created earlier
        /// FormObject formObject = FormObject.Builder()
        ///                                   .FormId("1")
        ///                                   .CurrentRow()
        ///                                       .RowId("1||1")
        ///                                       .Field(fieldObject1)
        ///                                       .Field(fieldObject2)
        ///                                       .AddRow()
        ///                                   .MultipleIteration()
        ///                                   .OtherRow()
        ///                                       .RowId("1||2")
        ///                                       .Field(fieldObject3)
        ///                                       .Field(fieldObject4)
        ///                                       .AddRow()
        ///                                   .Build();
        /// </code>
        /// </summary>
        /// <returns>A <see cref="FormObject"/></returns>
        public static FormObjectBuilder Builder() { return new FormObjectBuilder(); }

        /// <summary>
        /// Returns a deep copy of the <see cref="FormObject"/>.
        /// </summary>
        /// <returns></returns>
        public new FormObject Clone()
        {
            var formObject = (FormObject)MemberwiseClone();
            formObject.CurrentRow = CurrentRow?.Clone();
            formObject.OtherRows = new List<RowObject>();
            foreach (var row in OtherRows)
            {
                formObject.OtherRows.Add(row.Clone());
            }
            return formObject;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FormObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FormObject"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);
        /// <summary>
        /// A Fluent Builder for constructing FormObjects
        /// </summary>
        public class FormObjectBuilder
        {
            protected readonly FormObject formObject;
            /// <summary>
            /// Constructs a FormObjectBuilder
            /// </summary>
            public FormObjectBuilder()
            {
                formObject = new FormObject();
            }
            /// <summary>
            /// Sets the FormId of the <see cref="FormObject"/>.
            /// This is required before any other attributes may be set on the <see cref="FormObject"/> built.
            /// </summary>
            /// <param name="formId">Required. The FormId to assign to the <see cref="FormObject"/></param>
            /// <returns>A <see cref="FormObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public FormObjectBuilderFinal FormId(string formId)
            {
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                formObject.FormId = formId;
                return new FormObjectBuilderFinal(formObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a <see cref="FormObject"/> build.
        /// </summary>
        public class FormObjectBuilderFinal
        {
            protected readonly FormObject formObject;
            /// <summary>
            /// Constructs a FormObjectBuilderFinal used to complete the build of a <see cref="FormObject"/>.
            /// </summary>
            /// <param name="formObject">The <see cref="FormObject"/> to continue building.</param>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="FormObject"/> is provided for continuation of build.</exception>
            public FormObjectBuilderFinal(FormObject formObject)
            {
                this.formObject = formObject ?? throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Initializes a builder to construct the CurrentRow.
            /// </summary>
            /// <returns>A <see cref="RowObject.CurrentRowObjectBuilder"/></returns>
            public RowObject.CurrentRowObjectBuilder CurrentRow()
            {
                return new RowObject.CurrentRowObjectBuilder(formObject);
            }
            /// <summary>
            /// Sets the CurrentRow of the <see cref="FormObject"/>.
            /// </summary>
            /// <param name="rowObject">The <see cref="RowObject"/> to set as the CurrentRow.</param>
            /// <returns>A <see cref=" FormObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> provided.</exception>
            public FormObjectBuilderFinal CurrentRow(RowObject rowObject)
            {
                formObject.CurrentRow = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                return this;
            }
            /// <summary>
            /// Indicate the <see cref="FormObject"/> uses a Multiple-Iteration Table.
            /// <para>Must be set to enable the adding of OtherRows to the <see cref="FormObject"/></para>
            /// </summary>
            /// <returns>A <see cref="FormObjectBuilderMIFinal"/></returns>
            public FormObjectBuilderMIFinal MultipleIteration()
            {
                formObject.MultipleIteration = true;
                return new FormObjectBuilderMIFinal(formObject);
            }
            /// <summary>
            /// Builds the <see cref="FormObject"/> based on the supplied parameters.
            /// </summary>
            /// <returns>A <see cref="FormObject"/></returns>
            public FormObject Build()
            {
                return formObject;
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a multiple iteration <see cref="FormObject"/> build.
        /// </summary>
        public class FormObjectBuilderMIFinal : FormObjectBuilderFinal
        {
            /// <summary>
            /// Constructs a FormObjectBuilderMIFinal used to complete the build of a multiple iteration <see cref="FormObject"/>.
            /// </summary>
            /// <param name="formObject"></param>
            public FormObjectBuilderMIFinal(FormObject formObject) : base(formObject) { }
            /// <summary>
            /// Initializes a builder to construct an OtherRow.
            /// </summary>
            /// <returns>A <see cref="RowObject.OtherRowObjectBuilder"/></returns>
            public RowObject.OtherRowObjectBuilder OtherRow()
            {
                return new RowObject.OtherRowObjectBuilder(formObject);
            }
            /// <summary>
            /// Adds another RowObject to the <see cref="FormObject"/>.
            /// </summary>
            /// <param name="rowObject">The <see cref="RowObject"/> to add.</param>
            /// <returns>A <see cref="FormObjectBuilderMIFinal"/></returns>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> provided.</exception>
            public FormObjectBuilderMIFinal OtherRow(RowObject rowObject)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                formObject.OtherRows.Add(rowObject);
                return this;
            }
        }
    }
}