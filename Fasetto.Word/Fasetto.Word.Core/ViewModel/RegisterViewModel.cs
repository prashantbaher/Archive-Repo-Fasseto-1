using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// A view model for Register screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {

        #region Public Properties

        /// <summary>
        /// The email of this user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A flag indicating if the login command is running
        /// </summary>
        public bool RegisterIsRunning { get; set; }

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
        public RegisterViewModel()
        {
            // Create command
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await RegisterinAsync(parameter) );

            // Creating Register command
            LoginCommand = new RelayCommand(async () => await LogAsync());
        }

        #endregion

        #region Helpers

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passed in from the view for the users password</param>
        /// <returns></returns>
        public async Task RegisterinAsync(object parameter)
        {
            await RunCommandAsync(() => this.RegisterIsRunning, async () =>
            {
                await Task.Delay(3 * 1000);

                var email = this.Email;

                // IMPORTANT : Never store unsecure password in variable like this
                var pass = (parameter as IHavePassword).securePassword.Unsecure();
            });

        }

        /// <summary>
        /// Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task LogAsync()
        {
            // Go to register page
            IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Login);

            await Task.Delay(1);
        }

        #endregion
    }
}
