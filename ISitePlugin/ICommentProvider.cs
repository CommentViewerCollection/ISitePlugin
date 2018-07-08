using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ryu_s.BrowserCookie;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Input;
namespace SitePlugin
{
    public interface ICommentProvider
    {
        event EventHandler<ConnectedEventArgs> Connected;
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>棒読みちゃんに読ませないために必要</remarks>
        event EventHandler<List<ICommentViewModel>> InitialCommentsReceived;
        event EventHandler<ICommentViewModel> CommentReceived;

        //event EventHandler<List<ICommentViewModel>> PastCommentsReceived;
        event EventHandler<IMetadata> MetadataUpdated;
        //Task PostCommentAsync(string text);
        Task ConnectAsync(string input, IBrowserProfile browserProfile);
        void Disconnect();
        //IEnumerable<ICommentViewModel> GetUserComments(IUser user);
        bool CanConnect { get; }
        bool CanDisconnect { get; }
        event EventHandler CanConnectChanged;
        event EventHandler CanDisconnectChanged;
        //TODO:どのアカウントでログインしているのかConnectionViewに表示したい
        //Task<IMyInfo> GetMyInfo(IBrowserProfile browserProfile);
        IUser GetUser(string userId);
    }
    public class ConnectedEventArgs : EventArgs
    {
        /// <summary>
        /// 入力値の保存が必要か
        /// YouTubeLiveの場合であれば、放送URLはfalse,channelURLはtrue
        /// </summary>
        public bool IsInputStoringNeeded { get; set; }
        /// <summary>
        /// 次回起動時にリストアするURL
        /// </summary>
        public string UrlToRestore { get; set; }
    }
    public interface IUser:INotifyPropertyChanged
    {
        string UserId { get; }
        IEnumerable<IMessagePart> Name { get; set; }
        string Nickname { get; set; }
        string ForeColorArgb { get; set; }
        string BackColorArgb { get; set; }
        bool IsNgUser { get; set; }
    }


}
