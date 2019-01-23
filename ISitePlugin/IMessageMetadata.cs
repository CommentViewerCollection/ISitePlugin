using System.Windows;
using System.Windows.Media;

namespace SitePlugin
{
    /// <summary>
    /// 
    /// </summary>
    public interface IMessageMetadata
    {
        Color BackColor { get; }
        Color ForeColor { get; }
        FontFamily FontFamily { get; }
        int FontSize { get; }
        FontWeight FontWeight { get; }
        FontStyle FontStyle { get; }
    }
}
