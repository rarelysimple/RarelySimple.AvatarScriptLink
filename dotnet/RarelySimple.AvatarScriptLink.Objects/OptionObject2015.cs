using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects
{
    public sealed class OptionObject2015 : OptionObject2015Base, IEquatable<OptionObject2015>
    {
        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2015"/>.
        /// </summary>
        public OptionObject2015() : base() { }

        /// <summary>
        /// Initializes a <see cref="OptionObject2015"/>
        /// </summary>
        /// <returns>An <see cref="OptionObject2015"/></returns>
        public static OptionObject2015 Initialize() { return new OptionObject2015(); }

        /// <summary>
        /// Clones the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2015 Clone()
        {
            var optionObject = (OptionObject2015) MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }

        #region IEquatable Implementation

        /// <summary>
        /// Used to compare two <see cref="OptionObject2015"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="OptionObject2015"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="OptionObject2015"/> are equal.</returns>
        public bool Equals(OptionObject2015 other)
        {
            if (other == null)
                return false;
            return EntityID == other.EntityID &&
                // Valid EpisodeNumber are integers currently despite the datatype
                (int)EpisodeNumber == (int)other.EpisodeNumber &&
                // Valid ErrorCodes are integers currently despite the datatype
                (int)ErrorCode == (int)other.ErrorCode &&
                ErrorMesg == other.ErrorMesg &&
                Facility == other.Facility &&
                NamespaceName == other.NamespaceName &&
                OptionId == other.OptionId &&
                OptionStaffId == other.OptionStaffId &&
                OptionUserId == other.OptionUserId &&
                ParentNamespace == other.ParentNamespace &&
                ServerName == other.ServerName &&
                SessionToken == other.SessionToken &&
                SystemCode == other.SystemCode &&
                FormObject.AreFormsEqual(Forms, other.Forms);

        }

        /// <summary>
        /// Used to compare <see cref="OptionObject2015"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="OptionObject2015"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is OptionObject2015 optionObject))
                return false;
            return Equals(optionObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="OptionObject2015"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="OptionObject2015"/>.</returns>
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + EpisodeNumber.GetHashCode();
            hash = hash * 23 + ErrorCode.GetHashCode();
            hash = hash * 23 + (ErrorMesg != null ? ErrorMesg.GetHashCode() : 0);
            hash = hash * 23 + (Facility != null ? Facility.GetHashCode() : 0);
            hash = hash * 23 + (NamespaceName != null ? NamespaceName.GetHashCode() : 0);
            hash = hash * 23 + (OptionId != null ? OptionId.GetHashCode() : 0);
            hash = hash * 23 + (OptionStaffId != null ? OptionStaffId.GetHashCode() : 0);
            hash = hash * 23 + (OptionUserId != null ? OptionUserId.GetHashCode() : 0);
            hash = hash * 23 + (ParentNamespace != null ? ParentNamespace.GetHashCode() : 0);
            hash = hash * 23 + (ServerName != null ? ServerName.GetHashCode() : 0);
            hash = hash * 23 + (SessionToken != null ? SessionToken.GetHashCode() : 0);
            hash = hash * 23 + (SystemCode != null ? SystemCode.GetHashCode() : 0);
            foreach (FormObject formObject in Forms)
            {
                hash = hash * 23 + (formObject != null ? formObject.GetHashCode() : 0);
            }
            return hash;
        }

        public static bool operator ==(OptionObject2015 optionObject1, OptionObject2015 optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return Equals(optionObject1, optionObject2);

            return optionObject1.Equals(optionObject2);
        }

        public static bool operator !=(OptionObject2015 optionObject1, OptionObject2015 optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return !Equals(optionObject1, optionObject2);

            return !optionObject1.Equals(optionObject2);
        }

        #endregion
    }
}
