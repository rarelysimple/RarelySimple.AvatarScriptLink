using Newtonsoft.Json;
using RarelySimple.AvatarScriptLink.Helpers;
using System;
using System.Globalization;
using System.Xml.Serialization;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public abstract class FieldObjectBase : IEquatable<FieldObjectBase>, IFieldObject
    {
        #region Constructors

        /// <summary>
        /// Creates an empty <see cref="FieldObject"/>.
        /// </summary>
        protected FieldObjectBase()
        {
            _enabled = "0";
            FieldNumber = "";
            _fieldValue = "";
            _locked = "0";
            _required = "0";
        }
        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        protected FieldObjectBase(string fieldNumber)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            _enabled = "0";
            FieldNumber = fieldNumber;
            _fieldValue = "";
            _locked = "0";
            _required = "0";
        }
        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/> and <see cref="FieldValue"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        protected FieldObjectBase(string fieldNumber, string fieldValue)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            _enabled = "0";
            FieldNumber = fieldNumber;
            _fieldValue = fieldValue;
            _locked = "0";
            _required = "0";
        }
        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/> and <see cref="FieldValue"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <param name="enabled"></param>
        /// <param name="locked"></param>
        /// <param name="required"></param>
        protected FieldObjectBase(string fieldNumber, string fieldValue, bool enabled, bool locked, bool required)
        {
            if (string.IsNullOrEmpty(fieldNumber))
                throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
            _enabled = enabled ? "1" : "0";
            FieldNumber = fieldNumber;
            _fieldValue = fieldValue;
            _locked = locked ? "1" : "0";
            _required = required ? "1" : "0";
        }
        #endregion

        #region Private Properties

        private string _enabled { get; set; }
        private string _fieldValue { get; set; }
        private string _locked { get; set; }
        private string _required { get; set; }
        private bool _modified { get; set; }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the Enabled property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. 0 = Disabled. 1 = Enabled.</value>
        public string Enabled
        { 
            get
            {
                return _enabled;
            }
            set
            {
                _enabled = value;
                _modified = true;
            }
        }
        /// <summary>
        /// Gets or sets the FieldNumber property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the field number. This is typically a value like 12345.6 or 12345.67.</value>
        public string FieldNumber { get; set; }     // Do we want to prevent modifying? Can only be set when constructed?
        /// <summary>
        /// Gets or sets the FieldValue property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> containing the value entered (or to be entered) in the field.</value>
        public string FieldValue
        {
            get
            {
                return _fieldValue;
            }
            set
            {
                _fieldValue = value;
                _modified = true;
            }
        }
        /// <summary>
        /// Gets or sets the Lock property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. 0 = Unlocked. 1 = Locked.</value>
        public string Lock
        {
            get
            {
                return _locked;
            }
            set
            {
                _locked = value;
                _modified = true;
            }
        }
        /// <summary>
        /// Gets or sets the Required property of a <see cref="FieldObject"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. 0 = Not required. 1 = Required.</value>
        public string Required
        {
            get
            {
                return _required;
            }
            set
            {
                _required = value;
                _modified = true;
            }
        }
        /// <summary>
        /// Gets or sets the Modified property of a <see cref="FieldObject"/>.
        /// </summary>
        [JsonIgnore]
        [XmlIgnore]
        public bool Modified 
        { 
            get
            {
                return _modified;
            }
            set
            {
                _modified = value;
            }
        }

        #endregion

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="FieldObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="FieldObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether two <see cref="FieldObject"/> are equal.</returns>
        public bool Equals(FieldObjectBase other)
        {
            if (other == null)
                return false;
            return this.FieldValue == other.FieldValue &&
                this.Required == other.Required &&
                this.Enabled == other.Enabled &&
                this.FieldNumber == other.FieldNumber &&
                this.Lock == other.Lock;
        }
        /// <summary>
        /// Used to compare <see cref="FieldObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="FieldObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            FieldObjectBase fieldObject = obj as FieldObjectBase;
            if (fieldObject == null)
                return false;
            return this.Equals(fieldObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="FieldObjectBase"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="FieldObjectBase"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            string hash = this.FieldNumber
                + delimiter + this.FieldValue
                + delimiter + this.Enabled
                + delimiter + this.Lock
                + delimiter + this.Required;
            return hash.GetHashCode();
        }

        public static bool operator ==(FieldObjectBase fieldObject1, FieldObjectBase fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return Object.Equals(fieldObject1, fieldObject2);

            return fieldObject1.Equals(fieldObject2);
        }

        public static bool operator !=(FieldObjectBase fieldObject1, FieldObjectBase fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return !Object.Equals(fieldObject1, fieldObject2);

            return !(fieldObject1.Equals(fieldObject2));
        }

        #endregion

        #region Methods

        /// <summary>
        /// Returns a copy of the <see cref="object"/>.
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Determines whether <see cref="FieldObject"/> is enabled.
        /// </summary>
        /// <returns></returns>
        public bool IsEnabled() => this.Enabled == "1" ? true : false;

        /// <summary>
        /// Determines whether <see cref="FieldObject"/> is enabled.
        /// </summary>
        /// <returns></returns>
        public bool IsLocked() => this.Lock == "1" ? true : false;

        /// <summary>
        /// Returns whether the <see cref="FieldObject"/> has been modified.
        /// </summary>
        /// <returns></returns>
        public bool IsModified() => _modified;

        /// <summary>
        /// Determines whether <see cref="FieldObject"/> is enabled.
        /// </summary>
        /// <returns></returns>
        public bool IsRequired() => this.Required == "1" ? true : false;

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as disabled and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsDisabled()
        {
            _modified = true;
            this.Enabled = "0";
            this.Required = "0";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as enabled and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsEnabled()
        {
            _modified = true;
            this.Enabled = "1";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as locked and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsLocked()
        {
            _modified = true;
            this.Lock = "1";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsModified() => _modified = true;

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as optional and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsOptional()
        {
            _modified = true;
            this.Enabled = "1";
            this.Required = "0";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as required and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsRequired()
        {
            _modified = true;
            this.Enabled = "1";
            this.Required = "1";
        }

        /// <summary>
        /// Sets the <see cref="FieldObject"/> as unlocked and marks the <see cref="FieldObject"/> as modified.
        /// </summary>
        public void SetAsUnlocked()
        {
            _modified = true;
            this.Lock = "0";
        }

        /// <summary>
        /// Sets the <see cref="FieldValue"/> of a <see cref="FieldObject"/>.
        /// </summary>
        /// <param name="fieldValue"></param>
        /// <returns></returns>
        public void SetFieldValue(string fieldValue)
        {
            _modified = true;
            this.FieldValue = fieldValue;
        }

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted in HTML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted in HTML.</returns>
        public string ToHtmlString() => OptionObjectHelpers.TransformToHtmlString(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted in HTML.
        /// </summary>
        /// <param name="includeHtmlHeaders">Determines whether to include the HTML headers in return. False allows for the embedding of the HTML in another HTML document.</param>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted in HTML.</returns>
        public string ToHtmlString(bool includeHtmlHeaders) => OptionObjectHelpers.TransformToHtmlString(this, includeHtmlHeaders);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted as JSON.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted as JSON.</returns>
        public string ToJson() => OptionObjectHelpers.TransformToJson(this);

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted as XML.</returns>
        public abstract string ToXml();

        #endregion
    }
}
