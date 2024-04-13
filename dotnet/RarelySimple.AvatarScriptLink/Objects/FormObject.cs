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
                    throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
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
                this.formObject = formObject ?? throw new ArgumentNullException(nameof(formObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
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
                formObject.CurrentRow = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
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
                    throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                formObject.OtherRows.Add(rowObject);
                return this;
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for adding FormObjects to OptionObjects
        /// </summary>
        public class OptionObjectFormObjectBuilder
        {
            protected readonly OptionObject optionObject;
            protected readonly FormObject formObject;
            /// <summary>
            /// Constructs a OptionObjectFormObjectBuilder
            /// </summary>
            /// <param name="optionObject"></param>
            public OptionObjectFormObjectBuilder(OptionObject optionObject)
            {
                this.optionObject = optionObject;
                formObject = new FormObject();
            }
            /// <summary>
            /// Sets the FormId of the <see cref="FormObject"/>.
            /// This is required before any other attributes may be set on the <see cref="FormObject"/> built.
            /// </summary>
            /// <param name="formId">Required. The FormId to assign to the <see cref="FormObject"/></param>
            /// <returns>A <see cref="OptionObject2015FormObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectFormObjectBuilderFinal FormId(string formId)
            {
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                formObject.FormId = formId;
                return new OptionObjectFormObjectBuilderFinal(optionObject, formObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a <see cref="FormObject"/> build.
        /// </summary>
        public class OptionObjectFormObjectBuilderFinal
        {
            protected readonly OptionObject optionObject;
            protected readonly FormObject formObject;
            /// <summary>
            /// Constructs a OptionObjectFormObjectBuilderFinal used to add a FormObject to a OptionObject
            /// </summary>
            /// <param name="optionObject">The <see cref="OptionObject"/> to add <see cref="FormObject"/>.</param>
            /// <param name="formObject">The <see cref="FormObject"/> to complete.</param>
            public OptionObjectFormObjectBuilderFinal(OptionObject optionObject, FormObject formObject)
            {
                this.optionObject = optionObject;
                this.formObject = formObject;
            }
            /// <summary>
            /// Sets the CurrentRow of the <see cref="FormObject"/>.
            /// </summary>
            /// <param name="rowObject">The <see cref="RowObject"/> to set as the CurrentRow.</param>
            /// <returns>A <see cref=" OptionObject2015FormObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> provided.</exception>
            public OptionObjectFormObjectBuilderFinal CurrentRow(RowObject rowObject)
            {
                formObject.CurrentRow = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return this;
            }
            /// <summary>
            /// Indicate the <see cref="FormObject"/> uses a Multiple-Iteration Table.
            /// <para>Must be set to enable the adding of OtherRows to the <see cref="FormObject"/></para>
            /// </summary>
            /// <returns>A <see cref="OptionObjectFormObjectBuilderMIFinal"/></returns>
            public OptionObjectFormObjectBuilderMIFinal MultipleIteration()
            {
                formObject.MultipleIteration = true;
                return new OptionObjectFormObjectBuilderMIFinal(optionObject, formObject);
            }
            /// <summary>
            /// Adds FormObject to the <see cref="OptionObject"/>.
            /// </summary>
            /// <returns>A <see cref="OptionObjectBuilderFinal"/></returns>
            public OptionObject.OptionObjectBuilderFinal AddForm()
            {
                optionObject.AddFormObject(formObject);
                return new OptionObject.OptionObjectBuilderFinal(optionObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a multiple iteration <see cref="FormObject"/> build.
        /// </summary>
        public class OptionObjectFormObjectBuilderMIFinal : OptionObjectFormObjectBuilderFinal
        {
            public OptionObjectFormObjectBuilderMIFinal(OptionObject optionObject, FormObject formObject) : base(optionObject, formObject) { }
            /// <summary>
            /// Adds another RowObject to the <see cref="FormObject"/>.
            /// </summary>
            /// <param name="rowObject">The <see cref="RowObject"/> to add.</param>
            /// <returns>A <see cref="OptionObjectFormObjectBuilderMIFinal"/></returns>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> provided.</exception>
            public OptionObjectFormObjectBuilderMIFinal OtherRow(RowObject rowObject)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                formObject.OtherRows.Add(rowObject);
                return this;
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for adding FormObjects to OptionObject2s
        /// </summary>
        public class OptionObject2FormObjectBuilder
        {
            protected readonly OptionObject2 optionObject;
            protected readonly FormObject formObject;
            /// <summary>
            /// Constructs a OptionObject2FormObjectBuilder
            /// </summary>
            /// <param name="optionObject"></param>
            public OptionObject2FormObjectBuilder(OptionObject2 optionObject)
            {
                this.optionObject = optionObject;
                formObject = new FormObject();
            }
            /// <summary>
            /// Sets the FormId of the <see cref="FormObject"/>.
            /// This is required before any other attributes may be set on the <see cref="FormObject"/> built.
            /// </summary>
            /// <param name="formId">Required. The FormId to assign to the <see cref="FormObject"/></param>
            /// <returns>A <see cref="OptionObject2015FormObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2FormObjectBuilderFinal FormId(string formId)
            {
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                formObject.FormId = formId;
                return new OptionObject2FormObjectBuilderFinal(optionObject, formObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a <see cref="FormObject"/> build.
        /// </summary>
        public class OptionObject2FormObjectBuilderFinal
        {
            protected readonly OptionObject2 optionObject;
            protected readonly FormObject formObject;
            /// <summary>
            /// Constructs a OptionObject2FormObjectBuilderFinal used to add a FormObject to a OptionObject2
            /// </summary>
            /// <param name="optionObject">The <see cref="OptionObject2"/> to add <see cref="FormObject"/>.</param>
            /// <param name="formObject">The <see cref="FormObject"/> to complete.</param>
            public OptionObject2FormObjectBuilderFinal(OptionObject2 optionObject, FormObject formObject)
            {
                this.optionObject = optionObject;
                this.formObject = formObject;
            }
            /// <summary>
            /// Sets the CurrentRow of the <see cref="FormObject"/>.
            /// </summary>
            /// <param name="rowObject">The <see cref="RowObject"/> to set as the CurrentRow.</param>
            /// <returns>A <see cref=" OptionObject2FormObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> provided.</exception>
            public OptionObject2FormObjectBuilderFinal CurrentRow(RowObject rowObject)
            {
                formObject.CurrentRow = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return this;
            }
            /// <summary>
            /// Indicate the <see cref="FormObject"/> uses a Multiple-Iteration Table.
            /// <para>Must be set to enable the adding of OtherRows to the <see cref="FormObject"/></para>
            /// </summary>
            /// <returns>A <see cref="OptionObject2FormObjectBuilderMIFinal"/></returns>
            public OptionObject2FormObjectBuilderMIFinal MultipleIteration()
            {
                formObject.MultipleIteration = true;
                return new OptionObject2FormObjectBuilderMIFinal(optionObject, formObject);
            }
            /// <summary>
            /// Adds FormObject to the <see cref="OptionObject2"/>.
            /// </summary>
            /// <returns>A <see cref="OptionObject2BuilderFinal"/></returns>
            public OptionObject2.OptionObject2BuilderFinal AddForm()
            {
                optionObject.AddFormObject(formObject);
                return new OptionObject2.OptionObject2BuilderFinal(optionObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a multiple iteration <see cref="FormObject"/> build.
        /// </summary>
        public class OptionObject2FormObjectBuilderMIFinal : OptionObject2FormObjectBuilderFinal
        {
            public OptionObject2FormObjectBuilderMIFinal(OptionObject2 optionObject, FormObject formObject) : base(optionObject, formObject) { }
            /// <summary>
            /// Adds another RowObject to the <see cref="FormObject"/>.
            /// </summary>
            /// <param name="rowObject">The <see cref="RowObject"/> to add.</param>
            /// <returns>A <see cref="OptionObject2FormObjectBuilderMIFinal"/></returns>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> provided.</exception>
            public OptionObject2FormObjectBuilderMIFinal OtherRow(RowObject rowObject)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                formObject.OtherRows.Add(rowObject);
                return this;
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for adding FormObjects to OptionObject2015s
        /// </summary>
        public class OptionObject2015FormObjectBuilder
        {
            protected readonly OptionObject2015 optionObject;
            protected readonly FormObject formObject;
            /// <summary>
            /// Constructs a OptionObjectFormObjectBuilder
            /// </summary>
            /// <param name="optionObject"></param>
            public OptionObject2015FormObjectBuilder(OptionObject2015 optionObject)
            {
                this.optionObject = optionObject;
                formObject = new FormObject();
            }
            /// <summary>
            /// Sets the FormId of the <see cref="FormObject"/>.
            /// This is required before any other attributes may be set on the <see cref="FormObject"/> built.
            /// </summary>
            /// <param name="formId">Required. The FormId to assign to the <see cref="FormObject"/></param>
            /// <returns>A <see cref="OptionObject2015FormObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015FormObjectBuilderFinal FormId(string formId)
            {
                if (string.IsNullOrEmpty(formId))
                    throw new ArgumentNullException(nameof(formId), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                formObject.FormId = formId;
                return new OptionObject2015FormObjectBuilderFinal(optionObject, formObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a <see cref="FormObject"/> build.
        /// </summary>
        public class OptionObject2015FormObjectBuilderFinal
        {
            protected readonly OptionObject2015 optionObject;
            protected readonly FormObject formObject;
            /// <summary>
            /// Constructs a OptionObject2015FormObjectBuilderFinal used to add a FormObject to a OptionObject2015
            /// </summary>
            /// <param name="optionObject">The <see cref="OptionObject2015"/> to add <see cref="FormObject"/>.</param>
            /// <param name="formObject">The <see cref="FormObject"/> to complete.</param>
            public OptionObject2015FormObjectBuilderFinal(OptionObject2015 optionObject, FormObject formObject)
            {
                this.optionObject = optionObject;
                this.formObject = formObject;
            }
            /// <summary>
            /// Sets the CurrentRow of the <see cref="FormObject"/>.
            /// </summary>
            /// <param name="rowObject">The <see cref="RowObject"/> to set as the CurrentRow.</param>
            /// <returns>A <see cref=" OptionObject2015FormObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> provided.</exception>
            public OptionObject2015FormObjectBuilderFinal CurrentRow(RowObject rowObject)
            {
                formObject.CurrentRow = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                return this;
            }
            /// <summary>
            /// Indicate the <see cref="FormObject"/> uses a Multiple-Iteration Table.
            /// <para>Must be set to enable the adding of OtherRows to the <see cref="FormObject"/></para>
            /// </summary>
            /// <returns>A <see cref="OptionObject2015FormObjectBuilderMIFinal"/></returns>
            public OptionObject2015FormObjectBuilderMIFinal MultipleIteration()
            {
                formObject.MultipleIteration = true;
                return new OptionObject2015FormObjectBuilderMIFinal(optionObject, formObject);
            }
            /// <summary>
            /// Adds FormObject to the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <returns>A <see cref="OptionObject2015BuilderFinal"/></returns>
            public OptionObject2015.OptionObject2015BuilderFinal AddForm()
            {
                optionObject.AddFormObject(formObject);
                return new OptionObject2015.OptionObject2015BuilderFinal(optionObject);
            }
        }
        /// <summary>
        /// A Faceted Fluent Builder for the completion of a multiple iteration <see cref="FormObject"/> build.
        /// </summary>
        public class OptionObject2015FormObjectBuilderMIFinal : OptionObject2015FormObjectBuilderFinal
        {
            public OptionObject2015FormObjectBuilderMIFinal(OptionObject2015 optionObject, FormObject formObject) : base(optionObject, formObject) { }
            /// <summary>
            /// Adds another RowObject to the <see cref="FormObject"/>.
            /// </summary>
            /// <param name="rowObject">The <see cref="RowObject"/> to add.</param>
            /// <returns>A <see cref="OptionObject2015FormObjectBuilderMIFinal"/></returns>
            /// <exception cref="ArgumentNullException">Thrown if no <see cref="RowObject"/> provided.</exception>
            public OptionObject2015FormObjectBuilderMIFinal OtherRow(RowObject rowObject)
            {
                if (rowObject == null)
                    throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                formObject.OtherRows.Add(rowObject);
                return this;
            }
        }
    }
}