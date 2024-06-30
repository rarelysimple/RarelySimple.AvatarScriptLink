using RarelySimple.AvatarScriptLink.Helpers;
using RarelySimple.AvatarScriptLink.Objects.Advanced;
using System;
using System.Globalization;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="FieldObject"/> within a <see cref="RowObject"/>.
    /// </summary>
    public sealed class FieldObject : FieldObjectBase, IEquatable<FieldObject>
    {
        /// <summary>
        /// Creates an empty <see cref="FieldObject"/>.
        /// </summary>
        public FieldObject() : base()
        { }

        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        public FieldObject(string fieldNumber) : base(fieldNumber)
        { }

        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/> and <see cref="FieldValue"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        public FieldObject(string fieldNumber, string fieldValue) : base(fieldNumber, fieldValue)
        { }

        /// <summary>
        /// Creates a <see cref="FieldObject"/> with the specified <see cref="FieldNumber"/> and <see cref="FieldValue"/>.
        /// </summary>
        /// <param name="fieldNumber"></param>
        /// <param name="fieldValue"></param>
        /// <param name="enabled"></param>
        /// <param name="locked"></param>
        /// <param name="required"></param>
        public FieldObject(string fieldNumber, string fieldValue, bool enabled, bool locked, bool required)
            : base(fieldNumber, fieldValue, enabled, locked, required)
        { }

        /// <summary>
        /// Initializes a FieldObject.
        /// </summary>
        /// <returns>A <see cref="FieldObject"/></returns>
        public static FieldObject Initialize() {
            return new FieldObject();
        }

        /// <summary>
        /// Initializes a <see cref="FieldObjectBuilder"/> to help construct a <see cref="FieldObject"/>.
        /// The implementation must set the FieldNumber before build may be completed.
        /// <code>
        /// // Sample usage
        /// FieldObject fieldObject = FieldObject.Builder()
        ///                                      .FieldNumber("123")
        ///                                      .FieldValue("Sample")
        ///                                      .Enabled()
        ///                                      .Required()
        ///                                      .Build();
        /// </code>
        /// </summary>
        /// <returns>A <see cref="FieldObjectBuilder"/>.</returns>
        public static FieldObjectBuilder Builder() => new FieldObjectBuilder();

        /// <summary>
        /// Returns a copy of the <see cref="FieldObject"/>.
        /// </summary>
        /// <returns></returns>
        public new FieldObject Clone()
        {
            return (FieldObject)MemberwiseClone();
        }

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="FieldObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="FieldObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether two <see cref="FieldObject"/> are equal.</returns>
        public bool Equals(FieldObject other)
        {
            return other != null &&
                FieldValue == other.FieldValue &&
                Required == other.Required &&
                Enabled == other.Enabled &&
                FieldNumber == other.FieldNumber &&
                Lock == other.Lock;
        }
        /// <summary>
        /// Used to compare <see cref="FieldObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="FieldObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is FieldObject fieldObject))
                return false;
            return Equals(fieldObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="FieldObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="FieldObject"/>.</returns>
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + (FieldNumber != null ? FieldNumber.GetHashCode() : 0);
            hash = hash * 23 + (FieldValue != null ? FieldValue.GetHashCode() : 0);
            hash = hash * 23 + (Enabled != null ? Enabled.GetHashCode() : 0);
            hash = hash * 23 + (Lock != null ? Lock.GetHashCode() : 0);
            hash = hash * 23 + (Required != null ? Required.GetHashCode() : 0);
            return hash;
        }

        public static bool operator ==(FieldObject fieldObject1, FieldObject fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return Equals(fieldObject1, fieldObject2);

            return fieldObject1.Equals(fieldObject2);
        }

        public static bool operator !=(FieldObject fieldObject1, FieldObject fieldObject2)
        {
            if (((object)fieldObject1) == null || ((object)fieldObject2) == null)
                return !Equals(fieldObject1, fieldObject2);

            return !fieldObject1.Equals(fieldObject2);
        }

        #endregion

        /// <summary>
        /// Returns a <see cref="string"/> with all of the contents of the <see cref="FieldObject"/> formatted as XML.
        /// </summary>
        /// <returns><see cref="string"/> of all of the contents of the <see cref="FieldObject"/> formatted as XML.</returns>
        public override string ToXml() => OptionObjectHelpers.TransformToXml(this);

        /// <summary>
        /// Fluent Builder class for constructing FieldObjects.
        /// </summary>
        public class FieldObjectBuilder
        {
            protected readonly FieldObject fieldObject;

            /// <summary>
            /// Constructs a FieldObjectBuilder with Enabled, Locked, and Required set to false by default.
            /// </summary>
            public FieldObjectBuilder()
            {
                fieldObject = new FieldObject
                {
                    _enabled = "0",
                    _locked = "0",
                    _required = "0"
                };
            }
            /// <summary>
            /// Sets the FieldNumber for the FieldObject to build.
            /// This is required before any other attributes may be set on the <see cref="FieldObject"/> built.
            /// </summary>
            /// <param name="fieldNumber">Required. The FieldNumber assigned to the <see cref="FieldObject"/></param>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> allowing for the setting of other attributes and building of the <see cref="FieldObject"/></returns>
            public FieldObjectBuilderFinal FieldNumber(string fieldNumber)
            {
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                fieldObject.FieldNumber = fieldNumber;
                return new FieldObjectBuilderFinal(fieldObject);
            }
        }
        /// <summary>
        /// Fluent Builder class for the completion of a <see cref="FieldObject"/> build.
        /// </summary>
        public class FieldObjectBuilderFinal
        {
            protected readonly FieldObject fieldObject;

            /// <summary>
            /// Constructs a <see cref="FieldObjectBuilderFinal"/> to resume building of a <see cref="FieldObject"/>.
            /// </summary>
            /// <param name="fieldObject"></param>
            public FieldObjectBuilderFinal(FieldObject fieldObject)
            {
                this.fieldObject = fieldObject ?? throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as enabled.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal Enabled()
            {
                fieldObject._enabled = "1";
                return this;
            }
            /// <summary>
            /// Sets the FieldValue of the <see cref="FieldObject"/> to build.
            /// </summary>
            /// <param name="fieldValue">The value this <see cref="FieldObject"/> is to be set to.</param>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal FieldValue(string fieldValue)
            {
                fieldObject.FieldValue = fieldValue;
                return this;
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as locked.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal Locked()
            {
                fieldObject._locked = "1";
                return this;
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as modified.
            /// <para>Allow the FieldObject to be returned in a return OptionObject.</para>
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal Modified()
            {
                fieldObject._modified = true;
                return this;
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as required.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal Required()
            {
                fieldObject._required = "1";
                return this;
            }
            /// <summary>
            /// Builds the <see cref="FieldObject"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="FieldObject"/>.</returns>
            public FieldObject Build() => fieldObject;
        }

        /// <summary>
        /// Fluent Builder class for constructing FieldObjects.
        /// </summary>
        public class RowObjectFieldObjectBuilder
        {
            protected readonly FieldObject fieldObject;
            protected readonly RowObject rowObject;

            /// <summary>
            /// Constructs a FieldObjectBuilder with Enabled, Locked, and Required set to false by default.
            /// </summary>
            public RowObjectFieldObjectBuilder(RowObject rowObject)
            {
                this.rowObject = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                fieldObject = new FieldObject();
            }
            /// <summary>
            /// Constructs a FieldObjectBuilder to resume work on an existing <see cref="FieldObject"/>.
            /// </summary>
            /// <param name="fieldObject"></param>
            protected RowObjectFieldObjectBuilder(FieldObject fieldObject, RowObject rowObject)
            {
                this.fieldObject = fieldObject ?? throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                this.rowObject = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            }
            /// <summary>
            /// Sets the FieldNumber for the FieldObject to build.
            /// This is required before any other attributes may be set or the <see cref="FieldObject"/> built.
            /// </summary>
            /// <param name="fieldNumber">Required. The FieldNumber assigned to the <see cref="FieldObject"/></param>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> allowing for the setting of other attributes and building of the <see cref="FieldObject"/></returns>
            public RowObjectFieldObjectBuilderFinal FieldNumber(string fieldNumber)
            {
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                fieldObject.FieldNumber = fieldNumber;
                return new RowObjectFieldObjectBuilderFinal(fieldObject, rowObject);
            }
        }
        /// <summary>
        /// Fluent Builder class for the completion of a <see cref="FieldObject"/> build.
        /// </summary>
        public class RowObjectFieldObjectBuilderFinal
        {
            protected readonly FieldObject fieldObject;
            protected readonly RowObject rowObject;

            /// <summary>
            /// Constructs a <see cref="FieldObjectBuilderFinal"/> to resume building of a <see cref="FieldObject"/>.
            /// </summary>
            /// <param name="fieldObject"></param>
            public RowObjectFieldObjectBuilderFinal(FieldObject fieldObject, RowObject rowObject) {
                this.fieldObject = fieldObject ?? throw new ArgumentNullException(nameof(fieldObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
                this.rowObject = rowObject ?? throw new ArgumentNullException(nameof(rowObject), ScriptLinkHelpers.GetLocalizedString(ParameterCannotBeNull, CultureInfo.CurrentCulture));
            }

            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as enabled.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectFieldObjectBuilderFinal Enabled()
            {
                fieldObject._enabled = "1";
                return this;
            }
            /// <summary>
            /// Sets the FieldValue of the <see cref="FieldObject"/> to build.
            /// </summary>
            /// <param name="fieldValue">The value this <see cref="FieldObject"/> is to be set to.</param>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectFieldObjectBuilderFinal FieldValue(string fieldValue)
            {
                fieldObject.FieldValue = fieldValue;
                return this;
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as locked.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectFieldObjectBuilderFinal Locked()
            {
                fieldObject._locked = "1";
                return this;
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as modified.
            /// <para>Allow the FieldObject to be returned in a return OptionObject.</para>
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectFieldObjectBuilderFinal Modified()
            {
                fieldObject._modified = true;
                return this;
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as required.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public RowObjectFieldObjectBuilderFinal Required()
            {
                fieldObject._required = "1";
                return this;
            }
            /// <summary>
            /// Builds the <see cref="FieldObject"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="FieldObject"/>.</returns>
            public RowObject.RowObjectBuilderFinal AddField()
            {
                rowObject.Fields.Add(fieldObject);
                return new RowObject.RowObjectBuilderFinal(rowObject);
            }
        }
    }
}
