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
        /// <summary>
        /// Initializes a <see cref="OptionObject"/>
        /// </summary>
        /// <returns>An <see cref="OptionObject"/></returns>
        public static OptionObject Initialize() { return new OptionObject(); }
        /// <summary>
        /// Initializes an <see cref="OptionObjectBuilder"/> to help construct an <see cref="OptionObject"/>
        /// <code>
        /// // Sample usage
        /// OptionObject optionObject = OptionObject.Builder()
        ///                                         .OptionId("123")
        ///                                         .OptionUserId("FLAST")
        ///                                         .OptionStaffId("4567")
        ///                                         .Facility("1")
        ///                                         .EntityId("23")
        ///                                         .EpisodeNumber(1)
        ///                                         .SystemCode("SBOX")
        ///                                         .Form("1")
        ///                                             .CurrentRow()
        ///                                         .Form("2")
        ///                                             .CurrentRow()
        ///                                             .MultipleIteration()
        ///                                             .OtherRow()
        ///                                         .Build();
        /// </code>
        /// </summary>
        /// <returns></returns>
        public static OptionObjectBuilder Builder() { return new OptionObjectBuilder(); }


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
        public new OptionObject Clone()
        {
            var optionObject = (OptionObject)MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }

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
        public override OptionObject ToOptionObject() => Clone();

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
        public new OptionObject ToReturnOptionObject(double errorCode, string errorMessage) => (OptionObject)OptionObjectHelpers.GetReturnOptionObject((IOptionObject)this, errorCode, errorMessage);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="OptionObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="OptionObject"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);

        public class OptionObjectBuilder
        {
            protected readonly OptionObject optionObject;
            /// <summary>
            /// Constructs a OptionObjectBuilder
            /// </summary>
            public OptionObjectBuilder()
            {
                optionObject = new OptionObject();
            }
            /// <summary>
            /// Sets the OptionId of the <see cref="OptionObject"/>.
            /// </summary>
            /// <param name="optionId"></param>
            /// <returns>An <see cref="OptionObjectBuilder"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectBuilderFinal OptionId(string optionId)
            {
                if (string.IsNullOrEmpty(optionId))
                    throw new ArgumentNullException(nameof(optionId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionId = optionId;
                return new OptionObjectBuilderFinal(optionObject);
            }
        }
        public class OptionObjectBuilderFinal
        {
            protected readonly OptionObject optionObject;
            /// <summary>
            /// Constructs a OptionObjectBuilder
            /// </summary>
            public OptionObjectBuilderFinal(OptionObject optionObject)
            {
                this.optionObject = optionObject ?? throw new ArgumentNullException(nameof(optionObject), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the EntityId of the <see cref="OptionObject"/>.
            /// </summary>
            /// <param name="entityId"></param>
            /// <returns>An <see cref="OptionObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectBuilderFinal EntityId(string entityId)
            {
                if (string.IsNullOrEmpty(entityId))
                    throw new ArgumentNullException(nameof(entityId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.EntityID = entityId;
                return this;
            }
            /// <summary>
            /// Sets the EpisodeNumber of the <see cref="OptionObject"/>.
            /// </summary>
            /// <param name="episodeNumber"></param>
            /// <returns>An <see cref="OptionObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectBuilderFinal EpisodeNumber(double episodeNumber)
            {
                optionObject.EpisodeNumber = episodeNumber;
                return this;
            }
            /// <summary>
            /// Sets the Facility of the <see cref="OptionObject"/>.
            /// </summary>
            /// <param name="facility"></param>
            /// <returns>An <see cref="OptionObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectBuilderFinal Facility(string facility)
            {
                if (string.IsNullOrEmpty(facility))
                    throw new ArgumentNullException(nameof(facility), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.Facility = facility;
                return this;
            }
            /// <summary>
            /// Sets the OptionStaffId of the <see cref="OptionObject2015"/>.
            /// </summary>
            /// <param name="optionStaffId"></param>
            /// <returns>An <see cref="OptionObject2015BuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectBuilderFinal OptionStaffId(string optionStaffId)
            {
                if (string.IsNullOrEmpty(optionStaffId))
                    throw new ArgumentNullException(nameof(optionStaffId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionStaffId = optionStaffId;
                return this;
            }
            /// <summary>
            /// Sets the OptionUserId of the <see cref="OptionObject"/>.
            /// </summary>
            /// <param name="optionUserId"></param>
            /// <returns>An <see cref="OptionObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectBuilderFinal OptionUserId(string optionUserId)
            {
                if (string.IsNullOrEmpty(optionUserId))
                    throw new ArgumentNullException(nameof(optionUserId), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.OptionUserId = optionUserId;
                return this;
            }
            /// <summary>
            /// Sets the SystemCode of the <see cref="OptionObject"/>.
            /// </summary>
            /// <param name="systemCode"></param>
            /// <returns>An <see cref="OptionObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectBuilderFinal SystemCode(string systemCode)
            {
                if (string.IsNullOrEmpty(systemCode))
                    throw new ArgumentNullException(nameof(systemCode), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                optionObject.SystemCode = systemCode;
                return this;
            }
            /// <summary>
            /// Initializes a builder to construct a FormObject within the OptionObject builder.
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
            /// <returns>An <see cref="OptionObjectBuilderFinal"/></returns>
            /// <exception cref="ArgumentNullException"></exception>
            public OptionObjectBuilderFinal Form(FormObject formObject)
            {
                if (optionObject.Forms == null)
                {
                    optionObject.Forms = new List<FormObject>();
                }
                optionObject.Forms.Add(formObject);
                return this;
            }
            /// <summary>
            /// Builds the <see cref="OptionObject"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="OptionObject"/></returns>
            public OptionObject Build()
            {
                return optionObject;
            }
        }
    }
}
