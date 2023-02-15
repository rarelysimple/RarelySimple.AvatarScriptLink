using RarelySimple.AvatarScriptLink.Objects.Advanced;
using RarelySimple.AvatarScriptLink.Helpers;
using System.Globalization;
using System;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="FieldObject"/> within a <see cref="RowObject"/>.
    /// </summary>
    public class FieldObject : FieldObjectBase
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
        /// Initializes a <see cref="FieldObjectBuilder"/> to help construct a <see cref="FieldObject"/>.
        /// The implementation must set the FieldNumber before build may be completed.
        /// <code>
        /// FieldObject fieldObject = FieldObject.Builder().FieldNumber("123").Build();
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
            protected readonly FieldObject _fieldObject;

            /// <summary>
            /// Constructs a FieldObjectBuilder with Enabled, Locked, and Required set to false by default.
            /// </summary>
            public FieldObjectBuilder()
            {
                _fieldObject = new FieldObject
                {
                    _enabled = "0",
                    _locked = "0",
                    _required = "0"
                };
            }
            /// <summary>
            /// Constructs a FieldObjectBuilder to resume work on an existing <see cref="FieldObject"/>.
            /// </summary>
            /// <param name="fieldObject"></param>
            protected FieldObjectBuilder(FieldObject fieldObject) => _fieldObject = fieldObject;
            /// <summary>
            /// Sets the FieldNumber for the FieldObject to build.
            /// This is required before any other attributes may be set or the <see cref="FieldObject"/> built.
            /// </summary>
            /// <param name="fieldNumber">Required. The FieldNumber assigned to the <see cref="FieldObject"/></param>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> allowing for the setting of other attributes and building of the <see cref="FieldObject"/></returns>
            public FieldObjectBuilderFinal FieldNumber(string fieldNumber)
            {
                if (string.IsNullOrEmpty(fieldNumber))
                    throw new ArgumentNullException(nameof(fieldNumber), ScriptLinkHelpers.GetLocalizedString("parameterCannotBeNull", CultureInfo.CurrentCulture));
                _fieldObject.FieldNumber = fieldNumber;
                return new FieldObjectBuilderFinal(_fieldObject);
            }
        }
        /// <summary>
        /// Fluent Builder class for the completion of a <see cref="FieldObject"/> build.
        /// </summary>
        public class FieldObjectBuilderFinal : FieldObjectBuilder {
            /// <summary>
            /// Constructs a <see cref="FieldObjectBuilderFinal"/> to resume building of a <see cref="FieldObject"/>.
            /// </summary>
            /// <param name="fieldObject"></param>
            public FieldObjectBuilderFinal(FieldObject fieldObject) : base(fieldObject) { }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as enabled.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal Enabled()
            {
                _fieldObject._enabled = "1";
                return this;
            }
            /// <summary>
            /// Sets the FieldValue of the <see cref="FieldObject"/> to build.
            /// </summary>
            /// <param name="fieldValue">The value this <see cref="FieldObject"/> is to be set to.</param>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal FieldValue(string fieldValue)
            {
                _fieldObject.FieldValue = fieldValue;
                return this;
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as locked.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal Locked()
            {
                _fieldObject._locked = "1";
                return this;
            }
            /// <summary>
            /// Sets the <see cref="FieldObject"/> to build as required.
            /// </summary>
            /// <returns>A <see cref="FieldObjectBuilderFinal"/> to resume build.</returns>
            public FieldObjectBuilderFinal Required()
            {
                _fieldObject._required = "1";
                return this;
            }
            /// <summary>
            /// Builds the <see cref="FieldObject"/> based on the supplied build parameters.
            /// </summary>
            /// <returns>A <see cref="FieldObject"/>.</returns>
            public FieldObject Build() => _fieldObject;
        }
    }
}
