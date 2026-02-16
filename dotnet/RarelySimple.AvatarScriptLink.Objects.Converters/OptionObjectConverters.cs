using RarelySimple.AvatarScriptLink.Objects.Interfaces;

namespace RarelySimple.AvatarScriptLink.Objects.Converters
{
    /// <summary>
    /// Provides conversion extensions for OptionObject variants.
    /// </summary>
    public static class OptionObjectConverters
    {
        /// <summary>
        /// Converts an <see cref="OptionObject2"/> to an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="source">The OptionObject2 to convert.</param>
        /// <param name="includeForms">True to copy forms, false to ignore them.</param>
        /// <returns>A new OptionObject with copied values, or null if the source is null.</returns>
        public static OptionObject? ToOptionObject(this OptionObject2? source, bool includeForms = true)
        {
            if (source == null)
            {
                return null;
            }

            var optionObject = OptionObject.Initialize();
            CopyCommonFields(source, optionObject);
            CopyForms(source, optionObject, includeForms);
            return optionObject;
        }

        /// <summary>
        /// Converts an <see cref="OptionObject2015"/> to an <see cref="OptionObject"/>.
        /// </summary>
        /// <param name="source">The OptionObject2015 to convert.</param>
        /// <param name="includeForms">True to copy forms, false to ignore them.</param>
        /// <returns>A new OptionObject with copied values, or null if the source is null.</returns>
        public static OptionObject? ToOptionObject(this OptionObject2015? source, bool includeForms = true)
        {
            if (source == null)
            {
                return null;
            }

            var optionObject = OptionObject.Initialize();
            CopyCommonFields(source, optionObject);
            CopyForms(source, optionObject, includeForms);
            return optionObject;
        }

        /// <summary>
        /// Converts an <see cref="OptionObject"/> to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="source">The OptionObject to convert.</param>
        /// <param name="includeForms">True to copy forms, false to ignore them.</param>
        /// <returns>A new OptionObject2 with copied values, or null if the source is null.</returns>
        public static OptionObject2? ToOptionObject2(this OptionObject? source, bool includeForms = true)
        {
            if (source == null)
            {
                return null;
            }

            var optionObject = OptionObject2.Initialize();
            CopyCommonFields(source, optionObject);
            CopyForms(source, optionObject, includeForms);
            return optionObject;
        }

        /// <summary>
        /// Converts an <see cref="OptionObject2015"/> to an <see cref="OptionObject2"/>.
        /// </summary>
        /// <param name="source">The OptionObject2015 to convert.</param>
        /// <param name="includeForms">True to copy forms, false to ignore them.</param>
        /// <returns>A new OptionObject2 with copied values, or null if the source is null.</returns>
        public static OptionObject2? ToOptionObject2(this OptionObject2015? source, bool includeForms = true)
        {
            if (source == null)
            {
                return null;
            }

            var optionObject = OptionObject2.Initialize();
            CopyCommonFields(source, optionObject);
            optionObject.NamespaceName = source.NamespaceName;
            optionObject.ParentNamespace = source.ParentNamespace;
            optionObject.ServerName = source.ServerName;
            CopyForms(source, optionObject, includeForms);
            return optionObject;
        }

        /// <summary>
        /// Converts an <see cref="OptionObject"/> to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="source">The OptionObject to convert.</param>
        /// <param name="includeForms">True to copy forms, false to ignore them.</param>
        /// <param name="sessionToken">The session token to set, if provided.</param>
        /// <param name="optionUserId">The option user ID to set, if provided.</param>
        /// <returns>A new OptionObject2015 with copied values, or null if the source is null.</returns>
        public static OptionObject2015? ToOptionObject2015(this OptionObject? source, bool includeForms = true, string? sessionToken = null, string? optionUserId = null)
        {
            if (source == null)
            {
                return null;
            }

            var optionObject = OptionObject2015.Initialize();
            CopyCommonFields(source, optionObject);
            ApplySessionDetails(optionObject, sessionToken, optionUserId, source.OptionUserId);
            CopyForms(source, optionObject, includeForms);
            return optionObject;
        }

        /// <summary>
        /// Converts an <see cref="OptionObject2"/> to an <see cref="OptionObject2015"/>.
        /// </summary>
        /// <param name="source">The OptionObject2 to convert.</param>
        /// <param name="includeForms">True to copy forms, false to ignore them.</param>
        /// <param name="sessionToken">The session token to set, if provided.</param>
        /// <param name="optionUserId">The option user ID to set, if provided.</param>
        /// <returns>A new OptionObject2015 with copied values, or null if the source is null.</returns>
        public static OptionObject2015? ToOptionObject2015(this OptionObject2? source, bool includeForms = true, string? sessionToken = null, string? optionUserId = null)
        {
            if (source == null)
            {
                return null;
            }

            var optionObject = OptionObject2015.Initialize();
            CopyCommonFields(source, optionObject);
            optionObject.NamespaceName = source.NamespaceName;
            optionObject.ParentNamespace = source.ParentNamespace;
            optionObject.ServerName = source.ServerName;
            ApplySessionDetails(optionObject, sessionToken, optionUserId, source.OptionUserId);
            CopyForms(source, optionObject, includeForms);
            return optionObject;
        }

        private static void CopyCommonFields(OptionObject source, IOptionObject target)
        {
            target.EntityID = source.EntityID;
            target.EpisodeNumber = source.EpisodeNumber;
            target.ErrorCode = source.ErrorCode;
            target.ErrorMesg = source.ErrorMesg;
            target.Facility = source.Facility;
            target.OptionId = source.OptionId;
            target.OptionStaffId = source.OptionStaffId;
            target.OptionUserId = source.OptionUserId;
            target.SystemCode = source.SystemCode;
        }

        private static void CopyCommonFields(OptionObject2 source, IOptionObject target)
        {
            target.EntityID = source.EntityID;
            target.EpisodeNumber = source.EpisodeNumber;
            target.ErrorCode = source.ErrorCode;
            target.ErrorMesg = source.ErrorMesg;
            target.Facility = source.Facility;
            target.OptionId = source.OptionId;
            target.OptionStaffId = source.OptionStaffId;
            target.OptionUserId = source.OptionUserId;
            target.SystemCode = source.SystemCode;
        }

        private static void CopyCommonFields(OptionObject2015 source, IOptionObject target)
        {
            target.EntityID = source.EntityID;
            target.EpisodeNumber = source.EpisodeNumber;
            target.ErrorCode = source.ErrorCode;
            target.ErrorMesg = source.ErrorMesg;
            target.Facility = source.Facility;
            target.OptionId = source.OptionId;
            target.OptionStaffId = source.OptionStaffId;
            target.OptionUserId = source.OptionUserId;
            target.SystemCode = source.SystemCode;
        }

        private static void ApplySessionDetails(OptionObject2015 target, string? sessionToken, string? optionUserId, string? fallbackOptionUserId)
        {
            if (sessionToken != null)
            {
                target.SessionToken = sessionToken;
            }

            if (optionUserId != null)
            {
                target.OptionUserId = optionUserId;
            }
            else if (fallbackOptionUserId != null)
            {
                target.OptionUserId = fallbackOptionUserId;
            }
        }

        private static void CopyForms(IOptionObject source, IOptionObject target, bool includeForms)
        {
            if (!includeForms || source.Forms == null)
            {
                return;
            }

            foreach (var form in source.Forms)
            {
                var convertedForm = form.ToFormObject();
                if (convertedForm != null)
                {
                    target.Forms.Add(convertedForm);
                }
            }
        }
    }
}
