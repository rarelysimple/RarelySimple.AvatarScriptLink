using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts
{
    public class OptionObjectBase : ObjectBase, IEquatable<OptionObjectBase>, IOptionObject
    {
        /// <summary>
        /// Gets or sets the EntityID property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and can contain a myAvatar PATID, STAFFID, USERID, or INCID.</value>
        public string EntityID { get; set; }
        /// <summary>
        /// Gets or sets the Episode Number property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used with episodic, patient OptionObjects.</value>
        public double EpisodeNumber { get; set; }
        /// <summary>
        /// Gets or sets the ErrorCode property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used upon return to myAvatar to determine prompted response. Possible values include 0, 1, 2, 3, 4, and 5 as string values.</value>
        public double ErrorCode { get; set; }
        /// <summary>
        /// Gets or sets the ErrorMesg property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> and is used to display a message to the user in myAvatar for ErrorCodes 1-4.</value>
        public string ErrorMesg { get; set; }
        /// <summary>
        /// Gets or sets the Facility property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/>. For most organizations, this value is 1, however more complex security configurations will utilize additional values.</value>
        public string Facility { get; set; }
        /// <summary>
        /// Gets or sets the Forms property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="List{T}"/> of <see cref="FormObject"/> .</value>
        public List<FormObject> Forms { get; set; }
        /// <summary>
        /// Gets or sets the OptionId property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the unique identifier of the Option in the myAvatar system.</value>
        public string OptionId { get; set; }
        /// <summary>
        /// Gets or sets the OptionStaffId object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the staff Id of the current myAvatar user.</value>
        public string OptionStaffId { get; set; }
        /// <summary>
        /// Gets or sets the OptionUserId object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the user id of the current myAvatar user.</value>
        public string OptionUserId { get; set; }
        /// <summary>
        /// Gets or sets the SystemCode object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the System Code. The value may be SBOX, BLD, UAT, or LIVE.</value>
        public string SystemCode { get; set; }

        #region Constructors

        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObjectBase"/>.
        /// </summary>
        protected OptionObjectBase()
        {
            Forms = new List<FormObject>();
        }

        #endregion

        #region IEquatable Implementation


        /// <summary>
        /// Used to compare two <see cref="OptionObject"/> and determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="OptionObject"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether the two <see cref="OptionObject"/> are equal.</returns>
        public bool Equals(OptionObjectBase other)
        {
            if (other == null)
                return false;
            return this.EntityID == other.EntityID &&
                this.EpisodeNumber == other.EpisodeNumber &&
                this.ErrorCode == other.ErrorCode &&
                this.ErrorMesg == other.ErrorMesg &&
                this.Facility == other.Facility &&
                this.OptionId == other.OptionId &&
                this.OptionStaffId == other.OptionStaffId &&
                this.OptionUserId == other.OptionUserId &&
                this.SystemCode == other.SystemCode &&
                AreFormsEqual(this.Forms, other.Forms);

        }

        /// <summary>
        /// Used to compare <see cref="OptionObject"/> to an <see cref="object"/> to determine if they are equal. Returns <see cref="bool"/>.
        /// </summary>
        /// <param name="other">The <see cref="object"/> to compare.</param>
        /// <returns>Returns a <see cref="bool"/> indicating whether <see cref="OptionObject"/> is equal to an <see cref="object"/>.</returns>
        public override bool Equals(object obj)
        {
            OptionObjectBase optionObject = obj as OptionObjectBase;
            if (optionObject == null)
                return false;
            return Equals(optionObject);
        }

        /// <summary>
        /// Overrides the <see cref="GetHashCode"/> method for a <see cref="OptionObjectBase"/>.
        /// </summary>
        /// <returns>Returns an <see cref="int"/> representing the unique hash code for the <see cref="OptionObjectBase"/>.</returns>
        public override int GetHashCode()
        {
            string delimiter = "||";
            StringBuilder sb = new StringBuilder();
            sb.Append(this.EntityID
                + delimiter + this.EpisodeNumber.ToString(CultureInfo.InvariantCulture)
                + delimiter + this.ErrorCode.ToString(CultureInfo.InvariantCulture)
                + delimiter + this.ErrorMesg
                + delimiter + this.Facility
                + delimiter + this.OptionId
                + delimiter + this.OptionStaffId
                + delimiter + this.OptionUserId
                + delimiter + this.SystemCode);
            foreach (FormObject formObject in this.Forms)
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

        private static bool AreBothEmpty(List<FormObject> list1, List<FormObject> list2) => (!list1.Any() && !list2.Any());

        private static bool AreBothNull(List<FormObject> list1, List<FormObject> list2) => (list1 == null && list2 == null);

        public static bool operator ==(OptionObjectBase optionObject1, OptionObjectBase optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return Equals(optionObject1, optionObject2);

            return optionObject1.Equals(optionObject2);
        }

        public static bool operator !=(OptionObjectBase optionObject1, OptionObjectBase optionObject2)
        {
            if (((object)optionObject1) == null || ((object)optionObject2) == null)
                return !Equals(optionObject1, optionObject2);

            return !(optionObject1.Equals(optionObject2));
        }

        #endregion
    }
}
