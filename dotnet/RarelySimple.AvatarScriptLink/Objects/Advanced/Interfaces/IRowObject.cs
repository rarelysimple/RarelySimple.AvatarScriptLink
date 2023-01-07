using System.Collections.Generic;

namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public interface IRowObject
    {
        List<FieldObject> Fields { get; set; }
        string ParentRowId { get; set; }
        string RowAction { get; set; }
        string RowId { get; set; }
    }
}
