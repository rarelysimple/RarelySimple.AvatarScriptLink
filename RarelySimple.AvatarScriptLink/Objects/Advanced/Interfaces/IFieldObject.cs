namespace RarelySimple.AvatarScriptLink.Objects.Advanced
{
    public interface IFieldObject
    {
        string Enabled { get; set; }
        string FieldNumber { get; set; }
        string FieldValue { get; set; }
        string Lock { get; set; }
        string Required { get; set; }

        // Custom Properties (Must be decorated with [JsonIgnore] and [XmlIgnore] when implemented
        bool Modified { get; set; }
    }
}
