namespace SitePlugin
{
    public interface IMessage : IValueChanged
    {
        string Raw { get; }
        SiteType SiteType { get; }
    }
}
