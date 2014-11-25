using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormSample.Views
{
    using Xamarin.Forms;

    public class HomePage : ContentPage
    {

        int count = 1;

        public HomePage()
        {

            var layout = new StackLayout
            {
                Orientation = StackOrientation.Vertical,
                Padding = 20
            };

            var grid = new Grid
            {
                RowSpacing = 10
            };

            grid.Children.Add(new Label { Text = "Refer a Contractor" }, 0, 0); // Left, First element
            grid.Children.Add(new Label { Text = "My Contractors" }, 1, 0); // Right, First element
            grid.Children.Add(new Label { Text = "About us" }, 0, 1); // Left, Second element
            grid.Children.Add(new Label { Text = "Amend detail" }, 1, 1); // Right, Second element
            grid.Children.Add(new Label { Text = "Pay calculator" }, 0, 2); // Left, Thrid element
            grid.Children.Add(new Label { Text = "Pay Chart" }, 1, 2); // Right, Thrid element

            var gridButton = new Button { Text = "Download terms and condition" };
            gridButton.Clicked += delegate
            {
                gridButton.Text = string.Format("Thanks! {0} clicks.", count++);
            };
            ////grid.Children.Add(gridButton, 0, 3); // Left, Third element
            ////grid.Children.Add(new Label { Text = " " }, 1, 3);
            layout.Children.Add(grid);
            Content = layout;



            ////Grid grid = new Grid
            ////{
            ////    VerticalOptions = LayoutOptions.FillAndExpand,
            ////    RowDefinitions = 
            ////    {
            ////        new RowDefinition { Height = GridLength.Auto },
            ////        new RowDefinition { Height = GridLength.Auto },
            ////        new RowDefinition { Height = GridLength.Auto }
            ////    },
            ////    ColumnDefinitions = 
            ////    {
            ////        new ColumnDefinition { Width = GridLength.Auto },
            ////        new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
            ////    }
            ////};

             

            ////grid.Children.Add(new Label
            ////{
            ////    Text = "Refer a Contractor",
            ////    TextColor = Color.White,
            ////    BackgroundColor = Color.Blue
            ////}, 0, 0);

            ////grid.Children.Add(new Label
            ////{
            ////    Text = "My Contractors",
            ////    TextColor = Color.White,
            ////    BackgroundColor = Color.Blue  
            ////}, 1, 0);

            ////grid.Children.Add(new Label
            ////{
            ////    Text = "About us",
            ////    TextColor = Color.White,
            ////    BackgroundColor = Color.Blue
            ////}, 0, 1);

            ////grid.Children.Add(new Label
            ////{
            ////    Text = "Amend detail",
            ////    TextColor = Color.Purple,
            ////    BackgroundColor = Color.Aqua,
            ////    XAlign = TextAlignment.Center,
            ////    YAlign = TextAlignment.Center,
            ////}, 0, 2);

            ////grid.Children.Add(new Label
            ////{
            ////    Text = "Pay calculator",
            ////    TextColor = Color.Purple,
            ////    BackgroundColor = Color.Aqua,
            ////    XAlign = TextAlignment.Center,
            ////    YAlign = TextAlignment.Center,
            ////}, 0, 1);


            ////grid.Children.Add(new Label
            ////{
            ////    Text = "Pay Chart",
            ////    TextColor = Color.Purple,
            ////    BackgroundColor = Color.Aqua,
            ////    XAlign = TextAlignment.Center,
            ////    YAlign = TextAlignment.Center,
            ////}, 0, 2);

             

            ////// Accomodate iPhone status bar.
            ////this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            ////// Build the page.
            ////this.Content = grid;

        }
    }
}
