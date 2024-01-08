using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System.Collections.Generic;

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
    }
}
