using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

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
        /// Initializes a <see cref="OptionObject2015"/>
        /// </summary>
        /// <returns>An <see cref="OptionObject2015"/></returns>
        public static OptionObject2015 Initialize() { return new OptionObject2015(); }
        /// <summary>
        /// Initializes an <see cref="OptionObject2015Builder"/> to help construct an <see cref="OptionObject2015"/>
        /// <code>
        /// // Sample usage
        /// OptionObject2015 optionObject = OptionObject2015.Builder()
        ///                                                 .OptionId("123")
        ///                                                 .OptionUserId("FLAST")
        ///                                                 .OptionStaffId("4567")
        ///                                                 .Facility("1")
        ///                                                 .EntityId("23")
        ///                                                 .EpisodeNumber(1)
        ///                                                 .SystemCode("SBOX")
        ///                                                 .NamespaceName("XXX")
        ///                                                 .ParentNamespace("YYY")
        ///                                                 .ServerName("avatar.domain.local")
        ///                                                 .SessionToken("asdfghjkl")
        ///                                                 .Form("1")
        ///                                                     .CurrentRow()
        ///                                                 .Form("2")
        ///                                                     .CurrentRow()
        ///                                                     .MultipleIteration()
        ///                                                     .OtherRow()
        ///                                                 .Build();
        /// </code>
        /// </summary>
        /// <returns></returns>
        public static OptionObject2015Builder Builder() { return new OptionObject2015Builder(); }
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
        /// Creates a clone of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2015 ToOptionObject2015() => Clone();

        /// <summary>
        /// Creates an <see cref="OptionObject2015"/> with the minimum information required to return.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2015 ToReturnOptionObject() => (OptionObject2015)OptionObjectHelpers.GetReturnOptionObject(this);

        /// <summary>
        /// Creates an <see cref="OptionObject2015"/> with the minimum information required to return plus the provided Error Code and Message.
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

        public class OptionObject2015Builder
        {
            protected readonly OptionObject2015 optionObject;
            /// <summary>
            /// Constructs a OptionObject2015Builder
            /// </summary>
            public OptionObject2015Builder()
            {
                optionObject = new OptionObject2015();
            }
            /// <summary>
            /// Sets the OptionId of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="optionId"></param>
            /// <returns>An <see cref="OptionObject2015Builder"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal OptionId(string optionId)
            {
                if (string.IsNullOrEmpty(optionId))
                    throw new ArgumentNullException(nameof(optionId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionId = optionId;
                return new OptionObject2015BuilderFinal(optionObject);
            }
        }
        public class OptionObject2015BuilderFinal
        {
            protected readonly OptionObject2015 optionObject;
            /// <summary>
            /// Constructs a OptionObject2015Builder
            /// </summary>
            public OptionObject2015BuilderFinal(OptionObject2015 optionObject)
            {
                this.optionObject = optionObject ?? throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the EntityId of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="entityId"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal EntityId(string entityId)
            {
                if (string.IsNullOrEmpty(entityId))
                    throw new ArgumentNullException(nameof(entityId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.EntityID = entityId;
                return this;
            }
            /// <summary>
            /// Sets the EpisodeNumber of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="episodeNumber"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal EpisodeNumber(double episodeNumber)
            {
                optionObject.EpisodeNumber = episodeNumber;
                return this;
            }
            /// <summary>
            /// Sets the Facility of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="facility"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal Facility(string facility)
            {
                if (string.IsNullOrEmpty(facility))
                    throw new ArgumentNullException(nameof(facility), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.Facility = facility;
                return this;
            }
            /// <summary>
            /// Sets the NamespaceName of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="namespaceName"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal NamespaceName(string namespaceName)
            {
                if (string.IsNullOrEmpty(namespaceName))
                    throw new ArgumentNullException(nameof(namespaceName), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.NamespaceName = namespaceName;
                return this;
            }
            /// <summary>
            /// Sets the OptionStaffId of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="optionStaffId"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal OptionStaffId(string optionStaffId)
            {
                if (string.IsNullOrEmpty(optionStaffId))
                    throw new ArgumentNullException(nameof(optionStaffId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionStaffId = optionStaffId;
                return this;
            }
            /// <summary>
            /// Sets the OptionUserId of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="optionUserId"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal OptionUserId(string optionUserId)
            {
                if (string.IsNullOrEmpty(optionUserId))
                    throw new ArgumentNullException(nameof(optionUserId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionUserId = optionUserId;
                return this;
            }
            /// <summary>
            /// Sets the ParentNamespace of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="parentNamespace"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal ParentNamespace(string parentNamespace)
            {
                if (string.IsNullOrEmpty(parentNamespace))
                    throw new ArgumentNullException(nameof(parentNamespace), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.ParentNamespace = parentNamespace;
                return this;
            }
            /// <summary>
            /// Sets the ServerName of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="serverName"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal ServerName(string serverName)
            {
                if (string.IsNullOrEmpty(serverName))
                    throw new ArgumentNullException(nameof(serverName), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.ServerName = serverName;
                return this;
            }
            /// <summary>
            /// Sets the SessionToken of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="sessionToken"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal SessionToken(string sessionToken)
            {
                if (string.IsNullOrEmpty(sessionToken))
                    throw new ArgumentNullException(nameof(sessionToken), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.SessionToken = sessionToken;
                return this;
            }
            /// <summary>
            /// Sets the SystemCode of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="systemCode"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal SystemCode(string systemCode)
            {
                if (string.IsNullOrEmpty(systemCode))
                    throw new ArgumentNullException(nameof(systemCode), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.SystemCode = systemCode;
                return this;
            }
            /// <summary>
            /// Initializes a builder to construct a FormObject within the OptionObject2015 builder.
            /// </summary>
            /// <returns>A <see cref="OptionObjectFormObjectBuilder"/> to start<see cref="FormObject"/> build.</returns>
            public FormObject.OptionObjectFormObjectBuilder Form()
            {
                return new FormObject.OptionObjectFormObjectBuilder(optionObject);
            }
            /// <summary>
            /// Adds a <see cref="FormObject"/> of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2015BuilderFinal Form(FormObject formObject)
            {
                if (optionObject.Forms == null)
                {
                    optionObject.Forms = new List<FormObject>();
                }
                optionObject.Forms.Add(formObject);
                return this;
            }
            /// <summary>
            /// Builds the <see cref="OptionObject2015"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="OptionObject2015"/></returns>
            public OptionObject2015 Build()
            {
                return optionObject;
            }
        }
    }
}
