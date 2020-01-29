using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink OptionObject2015.
    /// </summary>
    public sealed class OptionObject2015 : OptionObjectBase
    {
        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2015"/>.
        /// </summary>
        public OptionObject2015() : base()
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        /// <param name="namespaceName"></param>
        /// <param name="parentNamespace"></param>
        /// <param name="serverName"></param>
        /// <param name="sessionToken"></param>
        public OptionObject2015(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , string sessionToken) : base(optionId, optionUserId, optionStaffId
            , facility, entityId, episodeNumber
            , systemCode, namespaceName, parentNamespace, serverName
            , sessionToken)
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        /// <param name="namespaceName"></param>
        /// <param name="parentNamespace"></param>
        /// <param name="serverName"></param>
        /// <param name="sessionToken"></param>
        /// <param name="forms"></param>
        public OptionObject2015(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , string sessionToken
            , List<FormObject> forms) : base(optionId, optionUserId, optionStaffId
            , facility, entityId, episodeNumber
            , systemCode, namespaceName, parentNamespace, serverName
            , sessionToken, forms)
        { }

        /// <summary>
        /// Clones the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2015 Clone()
        {
            var optionObject = (OptionObject2015)MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.</returns>
        public new string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString((IOptionObject2015)this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted in HTML.</returns>
        public new string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString((IOptionObject2015)this, includeHtmlHeaders);

        /// <summary>
        /// Transforms the <see cref="OptionObject2015"/>  to an <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject ToOptionObject() => (OptionObject)OptionObjectHelpers.TransformToOptionObject((IOptionObject2015)this);

        /// <summary>
        /// Transforms the <see cref="OptionObject2015"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2 ToOptionObject2() => (OptionObject2)OptionObjectHelpers.TransformToOptionObject2((IOptionObject2015)this);

        /// <summary>
        /// Transforms the <see cref="OptionObject2015"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2015 ToOptionObject2015() => Clone();

        /// <summary>
        /// Creates an <see cref="OptionObject2015"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2015 ToReturnOptionObject() => (OptionObject2015)OptionObjectHelpers.GetReturnOptionObject(this);

        /// <summary>
        /// Creates an <see cref="OptionObject2015"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public new OptionObject2015 ToReturnOptionObject(double errorCode, string errorMessage) => (OptionObject2015)OptionObjectHelpers.GetReturnOptionObject((IOptionObject2015)this, errorCode, errorMessage);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2015"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2015"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);
    }
}
