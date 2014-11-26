using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSample.ViewModel
{
    using FormSample.Views;

    using Xamarin.Forms;

    public class AgentViewModel :BaseViewModel
    {
        private DataService dataService;

        private INavigation navigation;
        public AgentViewModel(INavigation navigation)
        {
            this.navigation = navigation;
            this.dataService = new DataService();
        }

        public const string IdPropertyName = "Id";
        private int id = 0;
        public int Id
        {
            get { return this.id; }
            set { this.ChangeAndNotify(ref this.id, value, IdPropertyName); }
        }

        public const string AgentEmailPropertyName = "Email";
        private string email = string.Empty; 
        public string Email
        {
            get { return this.email; }
            set { this.ChangeAndNotify(ref this.email, value, AgentEmailPropertyName); }
        }

        public const string FirstNamePropertyName = "FirstName";

        private string firstName = string.Empty;
        public string FirstName
        {
            get { return this.firstName; }
            set { this.ChangeAndNotify(ref this.firstName, value, FirstNamePropertyName); }
        }

        public const string LastNamePropertyName = "LastName";
        private string lastName = string.Empty;
        public string LastName
        {
            get { return this.lastName; }
            set { this.ChangeAndNotify(ref this.lastName, value, LastNamePropertyName); }
        }

        public const string AgencyNamePropertyName = "AgencyName";
        private string agencyName = string.Empty;
        public string AgencyName
        {
            get { return this.agencyName; }
            set { this.ChangeAndNotify(ref this.agencyName, value, AgencyNamePropertyName); }
        }

        public const string PhonePropertyName = "Phone";
        private string phone = string.Empty;
        public string Phone
        {
            get { return this.phone; }
            set { this.ChangeAndNotify(ref this.phone, value, PhonePropertyName); }
        }


        public const string isCheckedPropertyName = "IsChecked";
        private string isChecked = string.Empty;
        public string IsChecked
        {
            get { return this.isChecked; }
            set { this.ChangeAndNotify(ref this.isChecked, value, isCheckedPropertyName); }
        }

        private Command submitCommand;
        public const string SubmitCommandPropertyName = "SubmitCommand";
        public Command SubmitCommand
        {
            get
            {
                return submitCommand ?? (submitCommand = new Command(async () => await ExecuteSubmitCommand()));
            }
        }

        /// <summary>
        /// The execute submit command.
        /// </summary>
        /// <returns> The <see cref="Task"/>. </returns>
        protected async Task ExecuteSubmitCommand()
        {
            try
            {
                var a = new Agent()
                            {
                                Id = this.Id,
                                Email = this.Email,
                                FirstName = this.FirstName,
                                LastName = this.LastName,
                                AgencyName = this.AgencyName,
                                Phone = this.Phone
                            };

                await dataService.AddAgent(a);

                await navigation.PushAsync(new HomePage());
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
