using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

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
                AreFormsEqual(Forms, other.Forms);

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
            string delimiter = "||";
            StringBuilder sb = new StringBuilder();
            sb.Append(EntityID
                + delimiter + EpisodeNumber.ToString(CultureInfo.InvariantCulture)
                + delimiter + ErrorCode.ToString(CultureInfo.InvariantCulture)
                + delimiter + ErrorMesg
                + delimiter + Facility
                + delimiter + NamespaceName
                + delimiter + OptionId
                + delimiter + OptionStaffId
                + delimiter + OptionUserId
                + delimiter + ParentNamespace
                + delimiter + ServerName
                + delimiter + SessionToken
                + delimiter + SystemCode);
            foreach (FormObject formObject in Forms)
            {
                sb.Append(delimiter + formObject.GetHashCode());
            }
            return sb.GetHashCode();
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
