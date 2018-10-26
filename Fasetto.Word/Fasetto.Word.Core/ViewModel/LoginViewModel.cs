using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for Login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {

        #region Public Properties

        /// <summary>
        /// The email of this user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool LoginIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new accound
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            // Create command
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await LoginAsync(parameter) );

            // Creating Register command
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task LoginAsync(object parameter)
        {
            await RunCommandAsync(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(1000);

                // Go to chat page
                IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Chat);

                //var email = this.Email;

                //// IMPORTANT : Never store unsecure password in variable like this
                //var pass = (parameter as IHavePassword).securePassword.Unsecure();
            });

        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task RegisterAsync()
        {
            // Go to register page
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Register);

            await Task.Delay(1);
        }

        #endregion
    }
}
