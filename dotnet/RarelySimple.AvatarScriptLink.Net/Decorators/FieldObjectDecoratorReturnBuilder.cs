using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FieldObjectDecorator
    {
        public class FieldObjectDecoratorReturnBuilder
        {
            private readonly FieldObjectDecorator _decorator;

            public FieldObjectDecoratorReturnBuilder(FieldObjectDecorator decorator)
            {
                _decorator = decorator;
            }

            public FieldObject AsFieldObject()
            {
                var fieldObject = FieldObject.Initialize();
                fieldObject.Enabled = _decorator.Enabled ? "1" : "0";
                fieldObject.FieldNumber = _decorator.FieldNumber;
                fieldObject.FieldValue = _decorator.FieldValue;
                fieldObject.Lock = _decorator.Locked ? "1" : "0";
                fieldObject.Required = _decorator.Required ? "1" : "0";
                return fieldObject;
            }
        }
    }
}
