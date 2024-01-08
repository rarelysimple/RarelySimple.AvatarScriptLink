using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public class OptionObjectDecorator
    {
        private readonly IOptionObject2015 _optionObject;

        public double ErrorCode { get; set; }
        public string ErrorMesg { get; set; }
        public List<FormObject> Forms { get; set; }

        public OptionObjectDecorator(OptionObject optionObject)
        {
            _optionObject = OptionObject2015.Initialize();
            Forms = new List<FormObject>();
            foreach (var form in optionObject.Forms)
            {
                Forms.Add(form.Clone());
            }
        }

        public OptionObjectDecorator(OptionObject2 optionObject)
        {
            _optionObject = OptionObject2015.Initialize();
            Forms = new List<FormObject>();
            foreach (var form in optionObject.Forms)
            {
                Forms.Add(form.Clone());
            }
        }

        public OptionObjectDecorator(OptionObject2015 optionObject)
        {
            _optionObject = optionObject.Clone();
            Forms = new List<FormObject>();
            foreach (var form in optionObject.Forms)
            {
                Forms.Add(form.Clone());
            }
        }

        public string EntityID => _optionObject.EntityID;
        public double EpisodeNumber => _optionObject.EpisodeNumber;
        public string Facility => _optionObject.Facility;
        public string NamespaceName => _optionObject.NamespaceName;
        public string OptionId => _optionObject.OptionId;
        public string OptionStaffId => _optionObject.OptionStaffId;
        public string OptionUserId => _optionObject.OptionUserId;
        public string ParentNamespace => _optionObject.ParentNamespace;
        public string ServerName => _optionObject.ServerName;
        public string SessionToken => _optionObject.SessionToken;
        public string SystemCode => _optionObject.SystemCode;

        public OptionObjectDecoratorReturnBuilder Return()
        {
            return new OptionObjectDecoratorReturnBuilder(this);
        }

        public class OptionObjectDecoratorReturnBuilder
        {
            private readonly OptionObjectDecorator _decorator;

            public OptionObjectDecoratorReturnBuilder(OptionObjectDecorator decorator)
            {
                this._decorator = decorator;
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
                optionObject.Forms = _decorator.Forms;
                optionObject.OptionId = _decorator.OptionId;
                optionObject.OptionStaffId = _decorator.OptionStaffId;
                optionObject.OptionUserId = _decorator.OptionUserId;
                optionObject.SystemCode = _decorator.SystemCode;
                return optionObject;
            }

            public OptionObject2 AsOptionObject2()
            {
                var optionObject = OptionObject2.Initialize();
                optionObject.EntityID = _decorator.EntityID;
                optionObject.EpisodeNumber = _decorator.EpisodeNumber;
                optionObject.ErrorCode = _decorator.ErrorCode;
                optionObject.ErrorMesg = _decorator.ErrorMesg;
                optionObject.Facility = _decorator.Facility;
                optionObject.Forms = _decorator.Forms;
                optionObject.NamespaceName = _decorator.NamespaceName;
                optionObject.OptionId = _decorator.OptionId;
                optionObject.OptionStaffId = _decorator.OptionStaffId;
                optionObject.OptionUserId = _decorator.OptionUserId;
                optionObject.ParentNamespace = _decorator.ParentNamespace;
                optionObject.ServerName = _decorator.ServerName;
                optionObject.SystemCode = _decorator.SystemCode;
                return optionObject;
            }

            public OptionObject2015 AsOptionObject2015()
            {
                var optionObject = OptionObject2015.Initialize();
                optionObject.EntityID = _decorator.EntityID;
                optionObject.EpisodeNumber = _decorator.EpisodeNumber;
                optionObject.ErrorCode = _decorator.ErrorCode;
                optionObject.ErrorMesg = _decorator.ErrorMesg;
                optionObject.Facility = _decorator.Facility;
                optionObject.Forms = _decorator.Forms;
                optionObject.NamespaceName = _decorator.NamespaceName;
                optionObject.OptionId = _decorator.OptionId;
                optionObject.OptionStaffId = _decorator.OptionStaffId;
                optionObject.OptionUserId = _decorator.OptionUserId;
                optionObject.ParentNamespace = _decorator.ParentNamespace;
                optionObject.ServerName = _decorator.ServerName;
                optionObject.SessionToken = _decorator.SessionToken;
                optionObject.SystemCode = _decorator.SystemCode;
                return optionObject;
            }
        }
    }
}
