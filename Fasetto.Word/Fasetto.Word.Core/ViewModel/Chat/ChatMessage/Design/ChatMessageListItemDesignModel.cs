using System;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatMessageListItemViewModel"/>
    /// </summary>
    public class ChatMessageListItemDesignModel : ChatMessageListItemViewModel
    {
        #region Singelton

        // Below property is expand version of Instance property, which is the short hand version
        // public static ChatListItemDesignModel Instance { get {return new ChatListItemDesignModel(); } }

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatMessageListItemDesignModel Instance => new ChatMessageListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatMessageListItemDesignModel()
        {
            Initials = "PB";
            SenderName = "Prashant Baher";
            Message = "Some design time visual text.";
            ProfilePictureRGB = "3099c5";
            SentByMe = true;
            MessageSentTime = DateTime.UtcNow;
            MessageReadTime = DateTimeOffset.UtcNow.Subtract(TimeSpan.FromDays(1.5));

        }

        #endregion
    }
}
