namespace RarelySimple.AvatarScriptLink.Objects.Builders
{
    /// <summary>
    /// Provides extension methods for building and creating <see cref="FormObject"/> instances.
    /// </summary>
    public static class FormObjectBuilders
    {
        /// <summary>
        /// Creates a new <see cref="FormObject"/> with the specified form ID.
        /// </summary>
        /// <param name="formId">The form ID for the new FormObject.</param>
        /// <returns>A new FormObject with the specified form ID.</returns>
        public static FormObject CreateFormObject(string formId)
        {
            return FormObject.Initialize()
                .WithFormId(formId);
        }

        /// <summary>
        /// Sets the FormId on a <see cref="FormObject"/> using a fluent interface.
        /// </summary>
        /// <param name="formObject">The FormObject to configure.</param>
        /// <param name="formId">The form ID to set.</param>
        /// <returns>The FormObject for method chaining.</returns>
        public static FormObject WithFormId(this FormObject formObject, string formId)
        {
            formObject.FormId = formId;
            return formObject;
        }

        /// <summary>
        /// Sets the MultipleIteration flag on a <see cref="FormObject"/> using a fluent interface.
        /// </summary>
        /// <param name="formObject">The FormObject to configure.</param>
        /// <param name="multipleIteration">True if the form has multiple iteration, false otherwise.</param>
        /// <returns>The FormObject for method chaining.</returns>
        public static FormObject WithMultipleIteration(this FormObject formObject, bool multipleIteration)
        {
            formObject.MultipleIteration = multipleIteration;
            return formObject;
        }

        /// <summary>
        /// Sets the CurrentRow on a <see cref="FormObject"/> using a fluent interface.
        /// </summary>
        /// <param name="formObject">The FormObject to configure.</param>
        /// <param name="currentRow">The current row to set.</param>
        /// <returns>The FormObject for method chaining.</returns>
        public static FormObject WithCurrentRow(this FormObject formObject, RowObject currentRow)
        {
            formObject.CurrentRow = currentRow;
            return formObject;
        }

        /// <summary>
        /// Adds a row to the OtherRows collection on a <see cref="FormObject"/>.
        /// </summary>
        /// <param name="formObject">The FormObject to add to.</param>
        /// <param name="rowObject">The row to add.</param>
        /// <returns>The FormObject for method chaining.</returns>
        public static FormObject AddRow(this FormObject formObject, RowObject rowObject)
        {
            if (rowObject != null)
            {
                formObject.OtherRows.Add(rowObject);
            }
            return formObject;
        }
    }
}
