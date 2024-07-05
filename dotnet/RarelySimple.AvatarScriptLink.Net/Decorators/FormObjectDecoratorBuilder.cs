using System.Collections.Generic;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FormObjectDecorator
    {
        public class FormObjectDecoratorBuilder
        {
            private string _formId;
            private RowObject _currentRow;
            private bool _multipleIteration;
            private List<RowObject> _otherRows;

            public FormObjectDecoratorBuilder() {
                _otherRows = new List<RowObject>();
            }

            public FormObjectDecoratorBuilder(FormObject formObject) {
                if (formObject != null) {
                    _formId = formObject.FormId;
                    _currentRow = formObject.CurrentRow;
                    _multipleIteration = formObject.MultipleIteration;
                    _otherRows = formObject.OtherRows;
                }
            }

            public FormObjectDecoratorBuilder CurrentRow(RowObject rowObject) {
                _currentRow = rowObject;
                return this;
            }

            public FormObjectDecoratorBuilder FormId(string formId) {
                _formId = formId;
                return this;
            }

            public FormObjectDecoratorBuilder MultipleIteration() {
                _multipleIteration = true;
                return this;
            }

            public FormObjectDecoratorBuilder MultipleIteration(bool multipleIteration) {
                _multipleIteration = multipleIteration;
                return this;
            }

            public FormObjectDecoratorBuilder OtherRow(RowObject rowObject) {
                if (rowObject != null) {
                    _otherRows.Add(rowObject);
                }
                return this;
            }

            public FormObjectDecoratorBuilder OtherRows(List<RowObject> rowObjects) {
                _otherRows = rowObjects;
                return this;
            }

            public FormObjectDecorator Build() {
                FormObject formObject = new FormObject {
                    FormId = _formId,
                    CurrentRow = _currentRow,
                    MultipleIteration = _multipleIteration,
                    OtherRows = _otherRows
                };
                return new FormObjectDecorator(formObject);
            }
        }
    }
}