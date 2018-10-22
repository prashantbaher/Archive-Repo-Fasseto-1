using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// Helpers to animate the page in specific ways
    /// </summary>
    public static class PageAnimations
    {
        /// <summary>
        /// Slides a page in from the right
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRightAsync( this Page page, float seconds)
        {
            // Create the storyboard
            var storyBoard = new Storyboard();

            // Adds slides from right animation
            storyBoard.AddSlideInFromRight(seconds, page.WindowWidth);

            // Adds fade-in animation
            storyBoard.AddFadeIn(seconds);

            // Start animating
            storyBoard.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait to finish it
            await Task.Delay((int)seconds * 8000);
        }

        /// <summary>
        /// Slides a page out to the left
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeftAsync(this Page page, float seconds)
        {
            // Create the storyboard
            var storyBoard = new Storyboard();

            // Adds slides from right animation
            storyBoard.AddSlideOutToLeft(seconds, page.WindowWidth);

            // Adds fade-in animation
            storyBoard.AddFadeOut(seconds);

            // Start animating
            storyBoard.Begin(page);

            // Make page visible
            page.Visibility = Visibility.Visible;

            // Wait to finish it
            await Task.Delay((int)seconds * 1000);
        }
    }
}
