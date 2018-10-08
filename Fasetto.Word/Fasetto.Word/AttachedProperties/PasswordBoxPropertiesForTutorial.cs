using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    public class PasswordBoxPropertiesForTutorial
    {
        #region Standard Way of doint Attached Properties

        /* This region is not going to stay in Luke's code. He used these codes
         * just to show how attached properties are created in standard way.
         * He has other ways to do the same thing so he is doint that way.
         * Because of this, we did not have comment in this region.
         * This is just for our information.
         */

        public static readonly DependencyProperty MonitorPasswordProperty =
            DependencyProperty.RegisterAttached("MonitorPassword", typeof(bool), typeof(PasswordBoxPropertiesForTutorial), new PropertyMetadata(false, OnMonitorPasswordChanged));

        private static void OnMonitorPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var passwordBox = (d as PasswordBox);

            if (passwordBox == null)
                return;

            passwordBox.PasswordChanged += PasswordBox_PasswordChanged;

            if ((bool)e.NewValue)
            {
                SetHasText(passwordBox);
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }
        }

        private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            SetHasText((PasswordBox)sender);
        }

        public static void SetMonitorPassword(PasswordBox element, bool value)
        {
            element.SetValue(MonitorPasswordProperty, value);
        }

        public static bool GetMonitorPassword(PasswordBox element)
        {
            return (bool)element.GetValue(MonitorPasswordProperty);
        }

        public static readonly DependencyProperty HasTextProperty = 
            DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordBoxPropertiesForTutorial), new PropertyMetadata(false));

        private static void SetHasText(PasswordBox element)
        {
            element.SetValue(HasTextProperty, element.SecurePassword.Length > 0);
        }

        public static bool GetHasText (PasswordBox element)
        {
            return (bool)element.GetValue(HasTextProperty);
        }

        #endregion

    }
}
