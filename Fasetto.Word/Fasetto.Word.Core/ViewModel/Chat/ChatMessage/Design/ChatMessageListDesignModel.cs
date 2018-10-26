using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design time data for a <see cref="ChatMessageListViewModel"/>
    /// </summary>
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        #region Singlton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListDesignModel Instance => new ChatMessageListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListDesignModel()
        {
            Items = new List<ChatMessageListItemViewModel>
            {
                new ChatMessageListItemViewModel
                {
                    Initials = "PL",
                    SenderName = "Parnell",
                    Message = "I am about to wipe the old server. We need to update the old server to Windows 2016",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
                new ChatMessageListItemViewModel
                {
                    Initials = "Prashant",
                    SenderName = "PB",
                    Message = "Let me know when you manage to spin the new 2016 server.",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.5)),
                    SentByMe = false
                },
                new ChatMessageListItemViewModel
                {
                    Initials = "PL",
                    SenderName = "Parnell",
                    Message = "The new server is up. Go to 192.168.1.1 .\r\nUsername is Admin, password is P8ssw0rd!",
                    ProfilePictureRGB = "3099c5",
                    MessageSentTime = DateTimeOffset.UtcNow,
                    SentByMe = false
                },
            };
        }

        #endregion
    }
}
