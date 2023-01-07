using Newtonsoft.Json;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="OptionObject2"/>.
    /// <para>Deprecated</para>
    /// </summary>
    public sealed class OptionObject2 : OptionObjectBase
    {
        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2"/>.
        /// </summary>
        public OptionObject2() : base()
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2"/>.
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
        public OptionObject2(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName) : base(optionId, optionUserId, optionStaffId
            , facility, entityId, episodeNumber
            , systemCode, namespaceName, parentNamespace, serverName
            , "")
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2"/>.
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
        /// <param name="forms"></param>
        public OptionObject2(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , List<FormObject> forms) : base(optionId, optionUserId, optionStaffId
            , facility, entityId, episodeNumber
            , systemCode, namespaceName, parentNamespace, serverName
            , "", forms)
        { }


        [JsonIgnore]
        [XmlIgnore]
        /// <summary>
        /// Gets or sets the SessionToken object of the <see cref="OptionObject2"/>. This is not serialized in an <see cref="OptionObject2"/>
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the SessionToken.</value>
        public override string SessionToken { get; set; }


        /// <summary>
        /// Clones the <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2 Clone()
        {
            var optionObject = (OptionObject2)MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2"/> formatted in HTML.</returns>
        public new string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString((IOptionObject2)this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2"/> formatted in HTML.</returns>
        public new string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString((IOptionObject2)this, includeHtmlHeaders);

        /// <summary>
        /// Transforms the <see cref="OptionObject2"/>  to an <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject ToOptionObject() => (OptionObject)OptionObjectHelpers.TransformToOptionObject((IOptionObject2)this);

        /// <summary>
        /// Transforms the <see cref="OptionObject2"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2 ToOptionObject2() => Clone();

        /// <summary>
        /// Transforms the <see cref="OptionObject2"/>  to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2015 ToOptionObject2015() => (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015((IOptionObject2)this);

        /// <summary>
        /// Creates an <see cref="OptionObject2"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2 ToReturnOptionObject() => (OptionObject2)OptionObjectHelpers.GetReturnOptionObject((IOptionObject2)this);

        /// <summary>
        /// Creates an <see cref="OptionObject2"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public new OptionObject2 ToReturnOptionObject(double errorCode, string errorMessage) => (OptionObject2)OptionObjectHelpers.GetReturnOptionObject((IOptionObject2)this, errorCode, errorMessage);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);
    }
}