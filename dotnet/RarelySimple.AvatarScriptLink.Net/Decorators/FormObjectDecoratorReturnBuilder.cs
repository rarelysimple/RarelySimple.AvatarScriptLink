using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FormObjectDecorator
    {
        public class FormObjectDecoratorReturnBuilder
        {
            private readonly FormObjectDecorator _decorator;

            public FormObjectDecoratorReturnBuilder(FormObjectDecorator decorator)
            {
                _decorator = decorator;
            }

            public FormObject AsFormObject()
            {
                var formObject = FormObject.Initialize();
                formObject.FormId = _decorator.FormId;

                var currentRow = _decorator.CurrentRow.Return().AsRowObject();
                if (currentRow != null &&
                    DecoratorHelper.IsValidReturnRowAction(currentRow.RowAction) &&
                    currentRow.Fields.Count > 0)
                    formObject.CurrentRow = currentRow;

                if (_decorator.MultipleIteration)
                {
                    formObject.MultipleIteration = _decorator.MultipleIteration;
                    foreach (var rowObject in _decorator.OtherRows)
                    {
                        var otherRow = rowObject.Return().AsRowObject();
                        if (otherRow != null &&
                            DecoratorHelper.IsValidReturnRowAction(otherRow.RowAction) &&
                            otherRow.Fields.Count > 0)
                            formObject.OtherRows.Add(otherRow);
                    }
                }

                return formObject;
            }
        }
    }
}
