using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class OptionObjectDecorator
    {
        public class OptionObjectDecoratorReturnBuilder
        {
            private readonly OptionObjectDecorator _decorator;

            public OptionObjectDecoratorReturnBuilder(OptionObjectDecorator decorator)
            {
                _decorator = decorator;
            }

            public OptionObjectDecoratorReturnBuilder WithErrorCode(double errorCode)
            {
                _decorator.ErrorCode = errorCode;
                return this;
            }

            public OptionObjectDecoratorReturnBuilder WithErrorMesg(string errorMesg)
            {
                _decorator.ErrorMesg = errorMesg;
                return this;
            }

            public OptionObject AsOptionObject()
            {
                var optionObject = OptionObject.Initialize();
                optionObject.EntityID = _decorator.EntityID;
                optionObject.EpisodeNumber = _decorator.EpisodeNumber;
                optionObject.ErrorCode = _decorator.ErrorCode;
                optionObject.ErrorMesg = _decorator.ErrorMesg;
                optionObject.Facility = _decorator.Facility;
                optionObject.OptionId = _decorator.OptionId;
                optionObject.OptionStaffId = _decorator.OptionStaffId;
                optionObject.OptionUserId = _decorator.OptionUserId;
                optionObject.SystemCode = _decorator.SystemCode;
                
                foreach (var form in _decorator.Forms)
                {
                    var formObject = form.Return().AsFormObject();
                    if (formObject != null &&
                        (formObject.CurrentRow != null ||
                        formObject.OtherRows.Count > 0))
                        optionObject.Forms.Add(formObject);
                }

                return optionObject;
            }
        }
    }
}