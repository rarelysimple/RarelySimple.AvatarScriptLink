namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public interface IOptionObject2 : IOptionObject
    {
        string NamespaceName { get; set; }
        string ParentNamespace { get; set; }
        string ServerName { get; set; }
    }
}
