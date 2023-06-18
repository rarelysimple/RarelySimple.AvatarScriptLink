using Newtonsoft.Json;
using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;
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
        /// <summary>
        /// Initializes a <see cref="OptionObject2"/>
        /// </summary>
        /// <returns>An <see cref="OptionObject2"/></returns>
        public static OptionObject2 Initialize() { return new OptionObject2(); }
        /// <summary>
        /// Initializes an <see cref="OptionObject2Builder"/> to help construct an <see cref="OptionObject2"/>
        /// <code>
        /// // Sample usage
        /// OptionObject2 optionObject = OptionObject2.Builder()
        ///                                           .OptionId("123")
        ///                                           .OptionUserId("FLAST")
        ///                                           .OptionStaffId("4567")
        ///                                           .Facility("1")
        ///                                           .EntityId("23")
        ///                                           .EpisodeNumber(1)
        ///                                           .SystemCode("SBOX")
        ///                                           .NamespaceName("XXX")
        ///                                           .ParentNamespace("YYY")
        ///                                           .ServerName("avatar.domain.local")
        ///                                           .Form("1")
        ///                                               .CurrentRow()
        ///                                           .Form("2")
        ///                                               .CurrentRow()
        ///                                               .MultipleIteration()
        ///                                               .OtherRow()
        ///                                           .Build();
        /// </code>
        /// </summary>
        /// <returns></returns>
        public static OptionObject2Builder Builder() { return new OptionObject2Builder(); }


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
        public override OptionObject ToOptionObject() => OptionObjectHelpers.TransformToOptionObject((IOptionObject2)this);

        /// <summary>
        /// Transforms the <see cref="OptionObject2"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2 ToOptionObject2() => Clone();

        /// <summary>
        /// Transforms the <see cref="OptionObject2"/>  to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2015 ToOptionObject2015() => (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(this);

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

        public class OptionObject2Builder
        {
            protected readonly OptionObject2 optionObject;
            /// <summary>
            /// Constructs a OptionObject2Builder
            /// </summary>
            public OptionObject2Builder()
            {
                optionObject = new OptionObject2();
            }
            /// <summary>
            /// Sets the OptionId of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="optionId"></param>
            /// <returns>An <see cref="OptionObject2Builder"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal OptionId(string optionId)
            {
                if (string.IsNullOrEmpty(optionId))
                    throw new ArgumentNullException(nameof(optionId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionId = optionId;
                return new OptionObject2BuilderFinal(optionObject);
            }
        }
        public class OptionObject2BuilderFinal
        {
            protected readonly OptionObject2 optionObject;
            /// <summary>
            /// Constructs a OptionObject2Builder
            /// </summary>
            public OptionObject2BuilderFinal(OptionObject2 optionObject)
            {
                this.optionObject = optionObject ?? throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the EntityId of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="entityId"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal EntityId(string entityId)
            {
                if (string.IsNullOrEmpty(entityId))
                    throw new ArgumentNullException(nameof(entityId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.EntityID = entityId;
                return this;
            }
            /// <summary>
            /// Sets the EpisodeNumber of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="episodeNumber"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal EpisodeNumber(double episodeNumber)
            {
                optionObject.EpisodeNumber = episodeNumber;
                return this;
            }
            /// <summary>
            /// Sets the Facility of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="facility"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal Facility(string facility)
            {
                if (string.IsNullOrEmpty(facility))
                    throw new ArgumentNullException(nameof(facility), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.Facility = facility;
                return this;
            }
            /// <summary>
            /// Sets the NamespaceName of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="namespaceName"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal NamespaceName(string namespaceName)
            {
                if (string.IsNullOrEmpty(namespaceName))
                    throw new ArgumentNullException(nameof(namespaceName), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.NamespaceName = namespaceName;
                return this;
            }
            /// <summary>
            /// Sets the OptionStaffId of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="optionStaffId"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal OptionStaffId(string optionStaffId)
            {
                if (string.IsNullOrEmpty(optionStaffId))
                    throw new ArgumentNullException(nameof(optionStaffId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionStaffId = optionStaffId;
                return this;
            }
            /// <summary>
            /// Sets the OptionUserId of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="optionUserId"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal OptionUserId(string optionUserId)
            {
                if (string.IsNullOrEmpty(optionUserId))
                    throw new ArgumentNullException(nameof(optionUserId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionUserId = optionUserId;
                return this;
            }
            /// <summary>
            /// Sets the ParentNamespace of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="parentNamespace"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal ParentNamespace(string parentNamespace)
            {
                if (string.IsNullOrEmpty(parentNamespace))
                    throw new ArgumentNullException(nameof(parentNamespace), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.ParentNamespace = parentNamespace;
                return this;
            }
            /// <summary>
            /// Sets the ServerName of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="serverName"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal ServerName(string serverName)
            {
                if (string.IsNullOrEmpty(serverName))
                    throw new ArgumentNullException(nameof(serverName), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.ServerName = serverName;
                return this;
            }
            /// <summary>
            /// Sets the SessionToken of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="sessionToken"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal SessionToken(string sessionToken)
            {
                if (string.IsNullOrEmpty(sessionToken))
                    throw new ArgumentNullException(nameof(sessionToken), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.SessionToken = sessionToken;
                return this;
            }
            /// <summary>
            /// Sets the SystemCode of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="systemCode"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal SystemCode(string systemCode)
            {
                if (string.IsNullOrEmpty(systemCode))
                    throw new ArgumentNullException(nameof(systemCode), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.SystemCode = systemCode;
                return this;
            }
            /// <summary>
            /// Initializes a builder to construct a FormObject within the OptionObject2 builder.
            /// </summary>
            /// <returns>A <see cref="OptionObject2FormObjectBuilder"/> to start<see cref="FormObject"/> build.</returns>
            public FormObject.OptionObject2FormObjectBuilder Form()
            {
                return new FormObject.OptionObject2FormObjectBuilder(optionObject);
            }
            /// <summary>
            /// Adds a <see cref="FormObject"/> of the <see cref="OptionObject2"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns>An <see cref="OptionObject2BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2BuilderFinal Form(FormObject formObject)
            {
                if (optionObject.Forms == null)
                {
                    optionObject.Forms = new List<FormObject>();
                }
                optionObject.Forms.Add(formObject);
                return this;
            }
            /// <summary>
            /// Builds the <see cref="OptionObject2"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="OptionObject2"/></returns>
            public OptionObject2 Build()
            {
                return optionObject;
            }
        }
    }
}