using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;

namespace Fasetto.Word
{
    /// <summary>
    /// Helpers to animate <see cref="FrameworkElement"/> is specific ways
    /// </summary>
    public static class FrameworkElementAnimations
    {
        /// <summary>
        /// Slides an elemets in from the right
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep the element at the same width during animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRightAsync (this FrameworkElement element, float seconds = 0.3f, bool KeepMargin = true)
        {
            // Create the storyboad
            var sb = new Storyboard();

            // Add slides from right animation
            sb.AddSlideInFromRight(seconds, element.ActualWidth, KeepMargin: KeepMargin);

            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an elemets in from the left
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep the element at the same width during animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool KeepMargin = true)
        {
            // Create the storyboad
            var sb = new Storyboard();

            // Add slides from right animation
            sb.AddSlideInFromLeft(seconds, element.ActualWidth, KeepMargin: KeepMargin);

            // Add fade in animation
            sb.AddFadeIn(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an elemets out to the left
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep the element at the same width during animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeftAsync(this FrameworkElement element, float seconds = 0.3f, bool KeepMargin = true)
        {
            // Create the storyboad
            var sb = new Storyboard();

            // Add slides out to right animation
            sb.AddSlideToLeft(seconds, element.ActualWidth, KeepMargin : KeepMargin);
            
            // Add fade out animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }

        /// <summary>
        /// Slides an elemets out to the right
        /// </summary>
        /// <param name="element">The element to animate</param>
        /// <param name="seconds">The time the animation will take</param>
        /// <param name="KeepMargin">Whether to keep the element at the same width during animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToRightAsync(this FrameworkElement element, float seconds = 0.3f, bool KeepMargin = true)
        {
            // Create the storyboad
            var sb = new Storyboard();

            // Add slides out to right animation
            sb.AddSlideToRight(seconds, element.ActualWidth, KeepMargin : KeepMargin);

            // Add fade out animation
            sb.AddFadeOut(seconds);

            // Start animating
            sb.Begin(element);

            // Make page visible
            element.Visibility = Visibility.Visible;

            // Wait for it to finish
            await Task.Delay((int)(seconds * 1000));
        }
    }
}
