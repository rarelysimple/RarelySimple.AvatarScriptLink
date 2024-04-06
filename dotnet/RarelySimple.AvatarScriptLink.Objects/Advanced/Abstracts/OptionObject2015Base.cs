using RarelySimple.AvatarScriptLink.Objects.Advanced.Interfaces;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts
{
    public class OptionObject2015Base : ObjectBase, IOptionObject2015
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
        /// Gets or sets the NamespaceName property of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the namespace name of the Option in the myAvatar system.</value>
        public string NamespaceName { get; set; }
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
        /// Gets or sets the ParentNamespace object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Parent Namespace.</value>
        public string ParentNamespace { get; set; }
        /// <summary>
        /// Gets or sets the ServerName object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the Server Name.</value>
        public string ServerName { get; set; }
        /// <summary>
        /// Gets or sets the SystemCode object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the System Code. The value may be SBOX, BLD, UAT, or LIVE.</value>
        public string SystemCode { get; set; }
        /// <summary>
        /// Gets or sets the SessionToken object of the <see cref="OptionObject2015"/>.
        /// </summary>
        /// <value>The value is a <see cref="string"/> representing the SessionToken.</value>
        public string SessionToken { get; set; }

        #region Constructors

        /// <summary>
        /// Creates a new ScriptLink <see cref="OptionObject2015Base"/>.
        /// </summary>
        protected OptionObject2015Base()
        {
            Forms = new List<FormObject>();
        }

        #endregion
    }
}
