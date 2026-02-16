using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Interfaces
{
    public interface IFormObject
    {
        RowObject CurrentRow { get; set; }
        string FormId { get; set; }
        bool MultipleIteration { get; set; }
        List<RowObject> OtherRows { get; set; }
    }
}
