using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSample.Views
{
    using FormSample.ViewModel;
    using Xamarin.Forms;

    public class LoginPage : ContentPage
    {


        public LoginPage()
        {
            BindingContext = new LoginViewModel(Navigation);

            BackgroundColor = Color.FromHex("232323");

            var layout = new StackLayout { Padding = 5 };

            var label = new Label
                            {
                                Text = "Sign in",
                                Font = Font.SystemFontOfSize(NamedSize.Large),
                                TextColor = Color.White,
                                VerticalOptions = LayoutOptions.Center,
                                XAlign = TextAlignment.Center, // Center the text in the blue box.
                                YAlign = TextAlignment.Center, // Center the text in the blue box.
                            };

            layout.Children.Add(label);

            var username = new Entry { Placeholder = "Username" };
            username.SetBinding(Entry.TextProperty, LoginViewModel.UsernamePropertyName);
            username.Keyboard = Keyboard.Email;
            layout.Children.Add(username);

            var password = new Entry { Placeholder = "Password" };
            password.SetBinding(Entry.TextProperty, LoginViewModel.PasswordPropertyName);
            password.IsPassword = true;
            layout.Children.Add(password);



            var button = new Button { Text = "Sign In", TextColor = Color.White };
            button.SetBinding(Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);

            layout.Children.Add(button);

            Content = new ScrollView { Content = layout };
        }
    }
}
