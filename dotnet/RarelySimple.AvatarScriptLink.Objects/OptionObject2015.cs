using RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts;
using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects
{
    public sealed class OptionObject2015 : OptionObject2015Base
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
    }
}
