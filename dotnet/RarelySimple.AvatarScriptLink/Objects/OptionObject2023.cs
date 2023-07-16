using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink OptionObject2023.
    /// </summary>
    public sealed class OptionObject2023 : OptionObjectBase
    {
        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2023"/>.
        /// </summary>
        public OptionObject2023() : base()
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2023"/>.
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
        public OptionObject2023(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , string sessionToken, string historicUID) : base(optionId, optionUserId, optionStaffId
            , facility, entityId, episodeNumber
            , systemCode, namespaceName, parentNamespace, serverName
            , sessionToken, historicUID)
        { }

        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2023"/>.
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
        public OptionObject2023(string optionId, string optionUserId, string optionStaffId
            , string facility, string entityId, double episodeNumber
            , string systemCode, string namespaceName, string parentNamespace, string serverName
            , string sessionToken, string historicUID
            , List<FormObject> forms) : base(optionId, optionUserId, optionStaffId
            , facility, entityId, episodeNumber
            , systemCode, namespaceName, parentNamespace, serverName
            , sessionToken, historicUID, forms)
        { }
        /// <summary>
        /// Initializes a <see cref="OptionObject2023"/>
        /// </summary>
        /// <returns>An <see cref="OptionObject2023"/></returns>
        public static OptionObject2023 Initialize() { return new OptionObject2023(); }
        /// <summary>
        /// Initializes an <see cref="OptionObject2023Builder"/> to help construct an <see cref="OptionObject2023"/>
        /// <code>
        /// // Sample usage
        /// OptionObject2023 optionObject = OptionObject2023.Builder()
        ///                                                 .OptionId("123")
        ///                                                 .OptionUserId("FLAST")
        ///                                                 .OptionStaffId("4567")
        ///                                                 .Facility("1")
        ///                                                 .EntityId("23")
        ///                                                 .EpisodeNumber(1)
        ///                                                 .HistoricUID(111)
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
        public static OptionObject2023Builder Builder() { return new OptionObject2023Builder(); }
        /// <summary>
        /// Clones the <see cref="OptionObject2023"/>.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2023 Clone()
        {
            var optionObject = (OptionObject2023)MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2023"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2023"/> formatted in HTML.</returns>
        public new string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2023"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2023"/> formatted in HTML.</returns>
        public new string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Transforms the <see cref="OptionObject2023"/>  to an <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject ToOptionObject() => (OptionObject)OptionObjectHelpers.TransformToOptionObject(this);

        /// <summary>
        /// Transforms the <see cref="OptionObject2023"/>  to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2 ToOptionObject2() => (OptionObject2)OptionObjectHelpers.TransformToOptionObject2(this);

        /// <summary>
        /// Transforms the <see cref="OptionObject2023"/>  to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2015 ToOptionObject2015() => (OptionObject2015)OptionObjectHelpers.TransformToOptionObject2015(this);

        /// <summary>
        /// Creates a clone of the <see cref="OptionObject2023"/>.
        /// </summary>
        /// <returns></returns>
        public override OptionObject2023 ToOptionObject2023() => Clone();

        /// <summary>
        /// Creates an <see cref="OptionObject2023"/> with the minimum information required to return.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2023 ToReturnOptionObject() => (OptionObject2023)OptionObjectHelpers.GetReturnOptionObject(this);

        /// <summary>
        /// Creates an <see cref="OptionObject2023"/> with the minimum information required to return plus the provided Error Code and Message.
        /// </summary>
        /// <param name="errorCode"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public new OptionObject2023 ToReturnOptionObject(double errorCode, string errorMessage) => (OptionObject2023)OptionObjectHelpers.GetReturnOptionObject(this, errorCode, errorMessage);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject2023"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject2023"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);

        public class OptionObject2023Builder
        {
            protected readonly OptionObject2023 optionObject;
            /// <summary>
            /// Constructs a OptionObject2023Builder
            /// </summary>
            public OptionObject2023Builder()
            {
                optionObject = new OptionObject2023();
            }
            /// <summary>
            /// Sets the OptionId of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="optionId"></param>
            /// <returns>An <see cref="OptionObject2023Builder"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal OptionId(string optionId)
            {
                if (string.IsNullOrEmpty(optionId))
                    throw new ArgumentNullException(nameof(optionId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionId = optionId;
                return new OptionObject2023BuilderFinal(optionObject);
            }
        }
        public class OptionObject2023BuilderFinal
        {
            protected readonly OptionObject2023 optionObject;
            /// <summary>
            /// Constructs a OptionObject2023Builder
            /// </summary>
            public OptionObject2023BuilderFinal(OptionObject2023 optionObject)
            {
                this.optionObject = optionObject ?? throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the EntityId of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="entityId"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal EntityId(string entityId)
            {
                if (string.IsNullOrEmpty(entityId))
                    throw new ArgumentNullException(nameof(entityId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.EntityID = entityId;
                return this;
            }
            /// <summary>
            /// Sets the EpisodeNumber of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="episodeNumber"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal EpisodeNumber(double episodeNumber)
            {
                optionObject.EpisodeNumber = episodeNumber;
                return this;
            }
            /// <summary>
            /// Sets the Facility of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="facility"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal Facility(string facility)
            {
                if (string.IsNullOrEmpty(facility))
                    throw new ArgumentNullException(nameof(facility), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.Facility = facility;
                return this;
            }
            /// <summary>
            /// Sets the HistoricUID of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="historicUID"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal HistoricUID(string historicUID)
            {
                if (string.IsNullOrEmpty(historicUID))
                    throw new ArgumentNullException(nameof(historicUID), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.HistoricUID = historicUID;
                return this;
            }
            /// <summary>
            /// Sets the NamespaceName of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="namespaceName"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal NamespaceName(string namespaceName)
            {
                if (string.IsNullOrEmpty(namespaceName))
                    throw new ArgumentNullException(nameof(namespaceName), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.NamespaceName = namespaceName;
                return this;
            }
            /// <summary>
            /// Sets the OptionStaffId of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="optionStaffId"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal OptionStaffId(string optionStaffId)
            {
                if (string.IsNullOrEmpty(optionStaffId))
                    throw new ArgumentNullException(nameof(optionStaffId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionStaffId = optionStaffId;
                return this;
            }
            /// <summary>
            /// Sets the OptionUserId of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="optionUserId"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal OptionUserId(string optionUserId)
            {
                if (string.IsNullOrEmpty(optionUserId))
                    throw new ArgumentNullException(nameof(optionUserId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionUserId = optionUserId;
                return this;
            }
            /// <summary>
            /// Sets the ParentNamespace of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="parentNamespace"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal ParentNamespace(string parentNamespace)
            {
                if (string.IsNullOrEmpty(parentNamespace))
                    throw new ArgumentNullException(nameof(parentNamespace), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.ParentNamespace = parentNamespace;
                return this;
            }
            /// <summary>
            /// Sets the ServerName of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="serverName"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal ServerName(string serverName)
            {
                if (string.IsNullOrEmpty(serverName))
                    throw new ArgumentNullException(nameof(serverName), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.ServerName = serverName;
                return this;
            }
            /// <summary>
            /// Sets the SessionToken of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="sessionToken"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal SessionToken(string sessionToken)
            {
                if (string.IsNullOrEmpty(sessionToken))
                    throw new ArgumentNullException(nameof(sessionToken), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.SessionToken = sessionToken;
                return this;
            }
            /// <summary>
            /// Sets the SystemCode of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="systemCode"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal SystemCode(string systemCode)
            {
                if (string.IsNullOrEmpty(systemCode))
                    throw new ArgumentNullException(nameof(systemCode), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.SystemCode = systemCode;
                return this;
            }
            /// <summary>
            /// Initializes a builder to construct a FormObject within the OptionObject2023 builder.
            /// </summary>
            /// <returns>A <see cref="OptionObject2023FormObjectBuilder"/> to start<see cref="FormObject"/> build.</returns>
            public FormObject.OptionObject2023FormObjectBuilder Form()
            {
                return new FormObject.OptionObject2023FormObjectBuilder(optionObject);
            }
            /// <summary>
            /// Adds a <see cref="FormObject"/> of the <see cref="OptionObject2023"/>.
            /// </summary>
            /// <param name="formObject"></param>
            /// <returns>An <see cref="OptionObject2023BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObject2023BuilderFinal Form(FormObject formObject)
            {
                if (optionObject.Forms == null)
                {
                    optionObject.Forms = new List<FormObject>();
                }
                optionObject.Forms.Add(formObject);
                return this;
            }
            /// <summary>
            /// Builds the <see cref="OptionObject2023"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="OptionObject2023"/></returns>
            public OptionObject2023 Build()
            {
                return optionObject;
            }
        }
    }
}
