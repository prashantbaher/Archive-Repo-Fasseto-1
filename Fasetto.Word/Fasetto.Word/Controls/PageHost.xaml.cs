﻿using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {

        #region Dependency Properties

        /// <summary>
        /// The current page to show in the page host
        /// </summary>
        public BasePage CurrentPage
        {
            get => (BasePage)GetValue(CurrentPageProperty); 
            set => SetValue(CurrentPageProperty, value); 
        }

        /// <summary>
        /// Register <see cref="CurrentPage"/> as a dependecy property
        /// </summary>
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(nameof(CurrentPage), 
                typeof(BasePage), 
                typeof(PageHost), 
                new UIPropertyMetadata(CurrentPagePropertyChanged));

        #endregion


        #region Consrtructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public PageHost()
        {
            InitializeComponent();
        }

        #endregion

        #region Property Changed Events

        /// <summary>
        /// Call when the <see cref="CurrentPage"/> value has been changed
        /// </summary>
        /// <param name="d">Dependency object to changed</param>
        /// <param name="e">Arguments</param>
        private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get the frames
            var newPageFrame = (d as PageHost).NewPage;
            var oldPageFrame = (d as PageHost).OldPage;

            // Sets the current page content as the old page
            var oldPageContent = newPageFrame.Content;

            // Remove current page from new page frame
            newPageFrame.Content = null;

            // Move the previous page into the old page frame
            oldPageFrame.Content = oldPageContent;

            // Animate out previous page when the Loaded event fires
            // right after this call due to moving frame
            if (oldPageContent is BasePage oldPage)
                oldPage.ShouldAnimateOut = true;

            // Set the new page content
            newPageFrame.Content = e.NewValue;
        }

        #endregion

    }
}
