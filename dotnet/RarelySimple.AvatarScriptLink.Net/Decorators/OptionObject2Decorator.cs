using RarelySimple.AvatarScriptLink.Objects;
using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Net.Decorators
{
    public sealed partial class OptionObject2Decorator
    {
        private readonly IOptionObject2 _optionObject;

        public double ErrorCode { get; set; }
        public string ErrorMesg { get; set; }
        public List<FormObjectDecorator> Forms { get; set; }

        public OptionObject2Decorator(OptionObject2 optionObject)
        {
            _optionObject = optionObject.Clone();

            Forms = new List<FormObjectDecorator>();
            foreach (var form in optionObject.Forms)
            {
                Forms.Add(new FormObjectDecorator(form));
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
        public string SystemCode => _optionObject.SystemCode;

        public OptionObject2DecoratorReturnBuilder Return()
        {
            return new OptionObject2DecoratorReturnBuilder(this);
        }

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject2Decorator"/> on the first form CurrentRow.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string fieldNumber, string fieldValue) => Forms = Helper.SetFieldValue(this, fieldNumber, fieldValue).Forms;

        /// <summary>
        /// Sets the FieldValue of a <see cref="FieldObject"/> in the <see cref="OptionObject2Decorator"/> 
        /// </summary>
        /// <param name="formId"></param>
        /// <param name="rowId"></param>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public void SetFieldValue(string formId, string rowId, string fieldNumber, string fieldValue) => Forms = Helper.SetFieldValue(this, formId, rowId, fieldNumber, fieldValue).Forms;
    }
}
