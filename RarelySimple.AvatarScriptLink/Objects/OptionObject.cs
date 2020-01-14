using Newtonsoft.Json;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="OptionObject"/>.
    /// <para>Deprecrated.</para>
    /// </summary>
    public sealed class OptionObject : OptionObjectBase
    {
        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject"/>.
        /// </summary>
        public OptionObject() : base()
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        public OptionObject(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode) : base(optionId, optionUserId, optionStaffId
            , facility, entityId, episodeNumber
            , systemCode, "", "", "", "")
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="optionId"></param>
        /// <param name="optionUserId"></param>
        /// <param name="optionStaffId"></param>
        /// <param name="facility"></param>
        /// <param name="entityId"></param>
        /// <param name="episodeNumber"></param>
        /// <param name="systemCode"></param>
        /// <param name="forms"></param>
        public OptionObject(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode
            , List<FormObject> forms) : base(optionId, optionUserId, optionStaffId
            , facility, entityId, episodeNumber
            , systemCode, "", "", "", "", forms)
        { }


        [JsonIgnore]
        [XmlIgnore]
        /// <summary>
        /// Gets or sets the NamespaceName property of the <see cref="OptionObject"/>. This is not serialized in an <see cref="OptionObject"/>
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the namespace name of the Option in the myAvatar system.</value>
        public override string NamespaceName { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        /// <summary>
        /// Gets or sets the ParentNamespace object of the <see cref="OptionObject"/>. This is not serialized in an <see cref="OptionObject"/>
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Parent Namespace.</value>
        public override string ParentNamespace { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        /// <summary>
        /// Gets or sets the ServerName object of the <see cref="OptionObject"/>. This is not serialized in an <see cref="OptionObject"/>
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Server Name.</value>
        public override string ServerName { get; set; }

        [JsonIgnore]
        [XmlIgnore]
        /// <summary>
        /// Gets or sets the SessionToken object of the <see cref="OptionObject"/>. This is not serialized in an <see cref="OptionObject"/>
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the SessionToken.</value>
        public override string SessionToken { get; set; }


        /// <summary>
        /// Clones the <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public new OptionObject Clone() => (OptionObject)OptionObjectHelpers.Clone((IOptionObject)this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject"/> formatted in HTML.</returns>
        public new string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString((IOptionObject)this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject"/> formatted in HTML.</returns>
        public new string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString((IOptionObject)this, includeHtmlHeaders);

        /// <summary>
        /// Transforms the <see cref="OptionObject"/>  to an <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject ToOptionObject() => (OptionObject)OptionObjectHelpers.Clone((IOptionObject)this);

        /// <summary>
        /// Transforms the <see cref="OptionObject"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2 ToOptionObject2() => (OptionObject2)OptionObjectHelpers.TransformToOptionObject2((IOptionObject)this);

        /// <summary>
        /// Transforms the <see cref="OptionObject"/>  to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2015 ToOptionObject2015() => (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015((IOptionObject)this);

        /// <summary>
        /// Creates an <see cref="OptionObject"/> with the minimal information required to return.
        /// </summary>
        /// <returns></returns>
        public new OptionObject ToReturnOptionObject() => (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)this);

        /// <summary>
        /// Creates an <see cref="OptionObject"/> with the minimal information required to return plus the provide Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public new OptionObject ToReturnOptionObject(int errorCode, string errorMessage) => (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)this, errorCode, errorMessage);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);
    }
}
