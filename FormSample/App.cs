using System;
using Xamarin.Forms;

namespace FormSample
{
    using FormSample.Helpers;
    using FormSample.Views;

    public class App
    {

        public static INavigation Navigation { get; private set; }
      
        public static Page GetMainPage()
        {
            NavigationPage page = null;
            try
            {
                // return new HomePage();
                page = new NavigationPage(new LoginPage());
                if (!string.IsNullOrWhiteSpace(Settings.GeneralSettings))
                {
                    Navigation = page.Navigation;
                    // return page;
                    // return new HomePage();
                }
                    // return new LoginPage();
                else
                {
                    page = new NavigationPage(new HomePage());
                    Navigation = page.Navigation;
                }
                // return page;

                //var navigationPage = new NavigationPage(new HackerNewsPage());
                //Navigation = navigationPage.Navigation;

                //return navigationPage;

                ////            return new ContentPage
                ////            { 
                ////                Content = new Label
                ////                {
                ////                    Text = "Hello, Forms!",
                ////                    VerticalOptions = LayoutOptions.CenterAndExpand,
                ////                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                ////                },
                ////            };
            }
            catch (Exception ex)
            {
            }
            return page;
        }
    }

    public class HackerNewsPage : ContentPage
    {

        private ListView listView;
        public HackerNewsPage()
        {
            Title = "Customers";

            listView = new ListView
            {
                RowHeight = 80
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { listView }
            };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var entries = await new DataService().GetCustomers();
            listView.ItemTemplate = new DataTemplate(typeof(CustomCell));
            listView.ItemsSource = entries;
        }
    }
}

