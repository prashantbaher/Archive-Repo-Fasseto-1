namespace Fasetto.Word.Core
{
    /// <summary>
    /// The design-time data for a <see cref="ChatListItemViewModel"/>
    /// </summary>
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        #region Singelton

        // Below property is expand version of Instance property, which is the short hand version
        // public static ChatListItemDesignModel Instance { get {return new ChatListItemDesignModel(); } }

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListItemDesignModel Instance => new ChatListItemDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListItemDesignModel()
        {
            Initials = "PB";
            Name = "Prashant Baher";
            Message = "This chat app is awesome. I bet this will be fast too";
            ProfilePictureRGB = "3099c5";
        }

        #endregion
    }
}
