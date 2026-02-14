using RarelySimple.AvatarScriptLink.Objects;
using System;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class FieldObjectDecorator
    {
        private readonly FieldObject _fieldObject;

        public bool Enabled { get; set; }
        public string FieldNumber { get; }
        public string FieldValue { get; set; }
        public bool Locked { get; set; }
        public bool Required { get; set; }

        public FieldObjectDecorator()
        {
            _fieldObject = FieldObject.Initialize();
            Enabled = false;
            FieldNumber = string.Empty;
            FieldValue = string.Empty;
            Locked = false;
            Required = false;
        }

        public FieldObjectDecorator(string fieldNumber)
        {
            _fieldObject = FieldObject.Initialize();
            Enabled = false;
            FieldNumber = fieldNumber;
            FieldValue = string.Empty;
            Locked = false;
            Required = false;
        }

        public FieldObjectDecorator(FieldObject fieldObject)
        {
            if (fieldObject == null)
                throw new ArgumentNullException(nameof(fieldObject));
            _fieldObject = fieldObject;
            Enabled = fieldObject.IsEnabled();
            FieldNumber = fieldObject.FieldNumber;
            FieldValue = fieldObject.FieldValue;
            Locked = fieldObject.IsLocked();
            Required = fieldObject.IsRequired();
        }

        public bool IsModified()
        {
            return Enabled != _fieldObject.IsEnabled() ||
                   FieldNumber != _fieldObject.FieldNumber ||
                   FieldValue != _fieldObject.FieldValue ||
                   Locked != _fieldObject.IsLocked() ||
                   Required != _fieldObject.IsRequired();
        }

        public FieldObjectDecoratorReturnBuilder Return()
        {
            return new FieldObjectDecoratorReturnBuilder(this);
        }
    }
}
