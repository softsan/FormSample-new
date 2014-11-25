using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSample.ViewModel
{
    using System.Diagnostics;

    using FormSample.Views;

    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {
        private DataService dataService;

        private INavigation navigation;
        public LoginViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            this.dataService = new DataService();
        }

        public const string UsernamePropertyName = "Username";
        private string username = string.Empty;
        public string Username
        {
            get { return username; }
            set { this.ChangeAndNotify(ref username, value, UsernamePropertyName); }
        }

        public const string PasswordPropertyName = "Password";
        private string password = string.Empty;
        public string Password
        {
            get { return password; }
            set { this.ChangeAndNotify(ref password, value, PasswordPropertyName); }
        }

        private Command loginCommand;
        public const string LoginCommandPropertyName = "LoginCommand";
        public Command LoginCommand
        {
            get
            {
                return loginCommand ?? (loginCommand = new Command(async () => await ExecuteLoginCommand()));
            }
        }

        protected async Task ExecuteLoginCommand()
        {
            try
            {
                
                 await navigation.PushAsync(new HomePage());
                //var navigationPage = new NavigationPage(new HomePage());
                //this.navigation = navigationPage.Navigation;
                //return navigationPage;

                ////Debug.WriteLine(username);
                ////Debug.WriteLine(password);
            }
            catch (Exception ex)
            {

            }
            //if (await this.dataService.IsValidUser(this.Username, this.Password))
            //{
                
            //}
        }

    }
}
