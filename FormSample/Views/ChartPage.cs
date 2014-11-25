namespace FormSample
{
    using OxyPlot;
    using OxyPlot.Axes;
    using OxyPlot.Series;

    using Xamarin.Forms;

    public class ChartPage : ContentPage
    {
        public ChartPage()
        {
            // var layout= GenerateChart();
            // Content = layout;
            this.Content = this.GenerateChart();
        }

        public StackLayout GenerateChart()
        {
            var plotModel = new PlotModel
                                {
                                    Title = "OxyPlot in Xamarin.Forms",
                                    Subtitle = string.Format("OS: {0}, Idiom: {1}", Device.OS, Device.Idiom),
                                    Background = OxyColors.LightYellow,
                                    PlotAreaBackground = OxyColors.LightGray
                                };
            var categoryAxis = new CategoryAxis { Position = AxisPosition.Bottom };
            var valueAxis = new LinearAxis { Position = AxisPosition.Left, MinimumPadding = 0 };
            plotModel.Axes.Add(categoryAxis);
            plotModel.Axes.Add(valueAxis);
            var series = new ColumnSeries();
            series.Items.Add(new ColumnItem { Value = 3 });
            series.Items.Add(new ColumnItem { Value = 14 });
            series.Items.Add(new ColumnItem { Value = 11 });
            series.Items.Add(new ColumnItem { Value = 12 });
            series.Items.Add(new ColumnItem { Value = 7 });
            plotModel.Series.Add(series);

            var c = new PlotView
                        {
                            Model = plotModel,
                            VerticalOptions = LayoutOptions.Fill,
                            HorizontalOptions = LayoutOptions.Fill,
                        };

            var nameLayout = new StackLayout()
                                 {
                                     // WidthRequest = 320,
                                     Padding = new Thickness(0, 20, 0, 0),
                                     HorizontalOptions = LayoutOptions.Fill,
                                     VerticalOptions = LayoutOptions.Fill,
                                     Orientation = StackOrientation.Vertical,
                                     Children = { c },
                                     BackgroundColor = Color.Gray
                                 };
            return nameLayout;

            //                return  new ContentPage
            //                {
            //                    Padding = new Thickness(0, 20, 0, 0),
            //                    Content = new PlotView
            //                    {
            //                        Model = plotModel,
            //                        VerticalOptions = LayoutOptions.Fill,
            //                        HorizontalOptions = LayoutOptions.Fill,
            //                    },
            //                };
        }

    }
}