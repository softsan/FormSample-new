namespace FormSample
{
    using System;

    using Xamarin.Forms;
    using Xamarin.Forms.Labs.Controls;

    public class RegisterPage : ContentPage
    {
        DataService service = new DataService();
        readonly Agent agent;
        public RegisterPage(Agent c)
        {
            this.agent = c;
            var layout = this.AssignValues();
            this.Content = layout;
        }

        public StackLayout AssignValues()
        {
            ////var image = new Image
            ////                {
            ////                    HorizontalOptions = LayoutOptions.Start
            ////                };
            ////// image.SetBinding(Image.SourceProperty,new Binding("ProfilePicture"));
            ////image.WidthRequest = image.HeightRequest = 70;
            ////image.Source = this.agent.ProfilePicture;



            var firstNameLabel = new Label { HorizontalOptions = LayoutOptions.Fill };
            firstNameLabel.Text = "First Name";

            var lastNameLabel = new Label { HorizontalOptions = LayoutOptions.Fill };
            lastNameLabel.Text = "Last Name";

            var firstName = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            firstName.Text = this.agent.FirstName;

            var lastName = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            lastName.Text = this.agent.LastName;

            var emailLabel = new Label { HorizontalOptions = LayoutOptions.Fill };
            emailLabel.Text = "Email";

            var emailText = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            emailText.Text = this.agent.Email;

            var agencyLabel = new Label { HorizontalOptions = LayoutOptions.Fill };
            agencyLabel.Text = "Agency";

            var agencyText = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            agencyText.Text = this.agent.AgencyName;


            var phoneLabel = new Label { HorizontalOptions = LayoutOptions.Fill };
            phoneLabel.Text = "Phone number";

            var phoneText = new Entry { HorizontalOptions = LayoutOptions.FillAndExpand };
            phoneText.Text = this.agent.Phone;

            var chkInvite = new CheckBox();
            chkInvite.UncheckedText = "I Agree to the terms and condition";
            chkInvite.IsVisible = true;
            chkInvite.BackgroundColor = Color.Blue;

            chkInvite.Checked = true;

            Button b = new Button
                           {
                               HorizontalOptions = LayoutOptions.Fill,
                               BackgroundColor = Color.Olive,
                               Text = "Submit"
                           };

            b.Clicked += async (object sender, EventArgs e) =>
                {
                    Agent c = new Agent()
                                     {
                                         Email = emailText.Text,
                                         FirstName = firstName.Text,
                                         LastName = lastName.Text,
                                         AgencyName = agencyText.Text,
                                         Phone = phoneText.Text
                                     };

                    var result = await this.service.AddAgent(c);
                    if (result.ResponseCode == "200")
                    {
                        await this.DisplayAlert("success", result.ResponseMessage, "OK");

                        await this.Navigation.PopToRootAsync();
                    }

                };


            var nameLayout = new StackLayout()
                                 {
                                     WidthRequest = 320,
                                     Padding = new Thickness(20, 0, 10, 0),
                                     HorizontalOptions = LayoutOptions.StartAndExpand,
                                     Orientation = StackOrientation.Vertical,
                                     Children = { emailLabel, emailText, firstNameLabel, firstName, lastNameLabel, lastName, agencyLabel, agencyText, phoneLabel, phoneText, b },
                                     BackgroundColor = Color.Gray
                                 };
            return nameLayout;
        }
    }
}