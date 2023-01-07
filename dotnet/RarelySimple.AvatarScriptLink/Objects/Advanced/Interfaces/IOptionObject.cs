using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public interface IOptionObject
    {
        string EntityID { get; set; }
        double EpisodeNumber { get; set; }
        double ErrorCode { get; set; }
        string ErrorMesg { get; set; }
        string Facility { get; set; }
        List<FormObject> Forms { get; set; }
        string OptionId { get; set; }
        string OptionStaffId { get; set; }
        string OptionUserId { get; set; }
        string SystemCode { get; set; }
    }
}
