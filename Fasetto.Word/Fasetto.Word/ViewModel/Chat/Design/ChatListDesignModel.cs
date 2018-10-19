using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasetto.Word
{
    /// <summary>
    /// The design time data for a <see cref="ChatListViewModel"/>
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        #region Singlton

        /// <summary>
        /// A single instance of the design model
        /// </summary>
        public static ChatListDesignModel Instance => new ChatListDesignModel();

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel
                {
                    Initials = "PB",
                    Name = "Prashant Baher",
                    Message = "This chat app is awesome. I bet this will be fast too",
                    ProfilePictureRGB = "3099c5",
                    NewContentAvailable = true
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, go to 192.168.1.1",
                    ProfilePictureRGB = "00d405",
                    IsSelected = true
                },
                                new ChatListItemViewModel
                {
                    Initials = "PB",
                    Name = "Prashant Baher",
                    Message = "This chat app is awesome. I bet this will be fast too",
                    ProfilePictureRGB = "3099c5"
                },
                new ChatListItemViewModel
                {
                    Initials = "JA",
                    Name = "Jesse",
                    Message = "Hey dude, here are the new icons",
                    ProfilePictureRGB = "fe4503"
                },
                new ChatListItemViewModel
                {
                    Initials = "PL",
                    Name = "Parnell",
                    Message = "The new server is up, go to 192.168.1.1",
                    ProfilePictureRGB = "00d405"
                },
            };
        }

        #endregion
    }
}
