using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects
{
    /// <summary>
    /// Represents an AvatarScriptLink <see cref="OptionObject2"/>.
    /// <para>Deprecated</para>
    /// </summary>
    public class OptionObject2 : OptionObject2Base
    {
        /// <summary>
        /// Creates a new AvatarScriptLink <see cref="OptionObject2"/>.
        /// </summary>
        public OptionObject2() : base() { }

        /// <summary>
        /// Initializes a <see cref="OptionObject2"/>
        /// </summary>
        /// <returns>An <see cref="OptionObject2"/></returns>
        public static OptionObject2 Initialize() { return new OptionObject2(); }

        /// <summary>
        /// Clones the <see cref="OptionObject2"/>.
        /// </summary>
        /// <returns></returns>
        public new OptionObject2 Clone()
        {
            var optionObject = (OptionObject2) MemberwiseClone();
            optionObject.Forms = new List<FormObject>();
            foreach (var form in Forms)
            {
                optionObject.Forms.Add(form.Clone());
            }
            return optionObject;
        }
    }
}
