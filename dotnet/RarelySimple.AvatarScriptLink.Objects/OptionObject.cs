using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="OptionObject"/>.
    /// <para>Deprecrated.</para>
    /// </summary>
    public sealed class OptionObject : OptionObjectBase, IEquatable<OptionObject>
    {
        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject"/>.
        /// </summary>
        public OptionObject() : base() { }

        /// <summary>
        /// Initializes a <see cref="OptionObject"/>
        /// </summary>
        /// <returns>An <see cref="OptionObject"/></returns>
        public static OptionObject Initialize() { return new OptionObject(); }

        /// <summary>
        /// Clones the <see cref="OptionObject"/>.
        /// </summary>
        /// <returns></returns>
        public new OptionObject Clone()
        {
            var optionObject = (OptionObject) MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }

        #region IEquatable Implementation


        /// <summary>
        /// Used to compare two <see cref="OptionObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="OptionObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="OptionObject"/> are equal.</returns>
        public bool Equals(OptionObject other)
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
                OptionId == other.OptionId &&
                OptionStaffId == other.OptionStaffId &&
                OptionUserId == other.OptionUserId &&
                SystemCode == other.SystemCode &&
                AreFormsEqual(Forms, other.Forms);

        }

        /// <summary>
        /// Used to compare <see cref="OptionObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="OptionObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is OptionObject optionObject))
                return false;
            return Equals(optionObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="OptionObject"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="OptionObject"/>.</returns>
        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + EpisodeNumber.GetHashCode();
            hash = hash * 23 + ErrorCode.GetHashCode();
            hash = hash * 23 + (ErrorMesg != null ? ErrorMesg.GetHashCode() : 0);
            hash = hash * 23 + (Facility != null ? Facility.GetHashCode() : 0);
            hash = hash * 23 + (OptionId != null ? OptionId.GetHashCode() : 0);
            hash = hash * 23 + (OptionStaffId != null ? OptionStaffId.GetHashCode() : 0);
            hash = hash * 23 + (OptionUserId != null ? OptionUserId.GetHashCode() : 0);
            hash = hash * 23 + (SystemCode != null ? SystemCode.GetHashCode() : 0);
            foreach (FormObject formObject in Forms)
            {
                hash = hash * 23 + (formObject != null ? formObject.GetHashCode() : 0);
            }
            return hash;
        }

        private static bool AreFormsEqual(List<FormObject> list1, List<FormObject> list2)
        {
            if (!AreBothNull(list1, list2) && AreBothEmpty(list1, list2))
                return true;

            if (list1.Count != list2.Count)
                return false;

            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool AreBothEmpty(List<FormObject> list1, List<FormObject> list2) => !list1.Any() && !list2.Any();

        private static bool AreBothNull(List<FormObject> list1, List<FormObject> list2) => list1 == null && list2 == null;

        public static bool operator ==(OptionObject optionObject1, OptionObject optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return Equals(optionObject1, optionObject2);

            return optionObject1.Equals(optionObject2);
        }

        public static bool operator !=(OptionObject optionObject1, OptionObject optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return !Equals(optionObject1, optionObject2);

            return !optionObject1.Equals(optionObject2);
        }

        #endregion
    }
}
