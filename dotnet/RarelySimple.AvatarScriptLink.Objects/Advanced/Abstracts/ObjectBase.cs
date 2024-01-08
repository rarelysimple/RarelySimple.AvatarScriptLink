using System;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced.Abstracts
{
    public abstract class ObjectBase : ICloneable
    {
        #region ICloneable Implementation

        /// <summary>
        /// Returns a copy of the <see cref="object"/>.
        /// </summary>
        /// <returns></returns>
        public virtual object Clone()
        {
            return MemberwiseClone();
        }

        #endregion
    }
}
