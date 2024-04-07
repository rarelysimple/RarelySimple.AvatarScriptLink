using System.Linq;
using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class RowObjectDecorator
    {
        public class RowObjectDecoratorReturnBuilder
        {
            private readonly RowObjectDecorator _decorator;

            public RowObjectDecoratorReturnBuilder(RowObjectDecorator decorator)
            {
                _decorator = decorator;
            }

            public RowObject AsRowObject()
            {
                var rowObject = RowObject.Initialize();
                rowObject.ParentRowId = _decorator.ParentRowId;
                rowObject.RowAction = _decorator.RowAction;
                rowObject.RowId = _decorator.RowId;

                foreach (var fieldObjectDecorator in _decorator.Fields.Where(field => field.IsModified()))
                {
                    rowObject.Fields.Add(fieldObjectDecorator.Return().AsFieldObject());
                }
                return rowObject;
            }
        }
    }
}
