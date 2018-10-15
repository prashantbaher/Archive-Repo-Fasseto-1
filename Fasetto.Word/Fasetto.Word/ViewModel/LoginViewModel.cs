using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word
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

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {
            // Create command
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter) );
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        private async Task Login(object parameter)
        {
            await RunCommand(() => this.LoginIsRunning, async () =>
            {
                await Task.Delay(8 * 1000);

                var email = this.Email;

                // IMPORTANT : Never store unsecure password in variable like this
                var pass = (parameter as IHavePassword).securePassword.Unsecure();
            });

        }

        #endregion
    }
}
