using RarelySimple.AvatarScriptLink.Objects;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class OptionObject2015Decorator
    {
        public class OptionObject2015DecoratorReturnBuilder
        {
            private readonly OptionObject2015Decorator _decorator;

            public OptionObject2015DecoratorReturnBuilder(OptionObject2015Decorator decorator)
            {
                _decorator = decorator;
            }

            public OptionObject2015DecoratorReturnBuilder WithErrorCode(double errorCode)
            {
                _decorator.ErrorCode = errorCode;
                return this;
            }

            public OptionObject2015DecoratorReturnBuilder WithErrorMesg(string errorMesg)
            {
                _decorator.ErrorMesg = errorMesg;
                return this;
            }

            public OptionObject2015 AsOptionObject2015()
            {
                var optionObject = OptionObject2015.Initialize();
                optionObject.EntityID = _decorator.EntityID;
                optionObject.EpisodeNumber = _decorator.EpisodeNumber;
                optionObject.ErrorCode = _decorator.ErrorCode;
                optionObject.ErrorMesg = _decorator.ErrorMesg;
                optionObject.Facility = _decorator.Facility;
                optionObject.NamespaceName = _decorator.NamespaceName;
                optionObject.OptionId = _decorator.OptionId;
                optionObject.OptionStaffId = _decorator.OptionStaffId;
                optionObject.OptionUserId = _decorator.OptionUserId;
                optionObject.ParentNamespace = _decorator.ParentNamespace;
                optionObject.ServerName = _decorator.ServerName;
                optionObject.SessionToken = _decorator.SessionToken;
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