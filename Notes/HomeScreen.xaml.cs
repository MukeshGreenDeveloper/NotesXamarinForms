using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Notes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeScreen : ContentPage
    {
        public HomeScreen()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                Label title = (Label)((StackLayout)((Frame)s).Content).Children[0];
                Label description = (Label)((StackLayout)((Frame)s).Content).Children[0];
                navigateToAddPageAsync(title.Text, description.Text);
            };
            for (int row = 0; row < 50; row++)
            {
                Label l = new Label
                {
                    Text = "LabelText",
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.Black
                };
                Label ldesc = new Label
                {
                    Text = "Descssss ................ sadfsafsdfs ",
                    FontAttributes = FontAttributes.Italic
                };
                Label l2 = new Label
                {
                    Text = "LabelText",
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.Black
                };

                Label l2desc = new Label
                {
                    Text = "Descssss ................ sadfsafsdfs ",
                    FontAttributes = FontAttributes.Italic
                };
                StackLayout stackLayout = new StackLayout
                {
                    Orientation = StackOrientation.Vertical
                };
                stackLayout.Children.Add(l);
                stackLayout.Children.Add(ldesc);

                Frame R1View = new Frame
                {
                    BorderColor = (Color)Application.Current.Resources["GrayLine"],
                    CornerRadius = 8,
                    Content = stackLayout,
                    Padding = new Thickness(8, 8, 8, 8),
                    Margin = new Thickness(16, 0, 16, 0),
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Center, true),
                };



                StackLayout stackLayout2 = new StackLayout
                {
                    Orientation = StackOrientation.Vertical
                };
                stackLayout2.Children.Add(l2);
                stackLayout2.Children.Add(l2desc);
                Frame R2View = new Frame
                {
                    BorderColor = (Color)Application.Current.Resources["GrayLine"],
                    CornerRadius = 8,
                    Content = stackLayout2,
                    Padding = new Thickness(8, 8, 8, 8),
                    Margin = new Thickness(0, 0, 16, 0),
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Center, true)
                };
                R1View.GestureRecognizers.Add(tapGestureRecognizer);
                R2View.GestureRecognizers.Add(tapGestureRecognizer);
                gridNotes.Children.Add(R1View, 0, row);
                gridNotes.Children.Add(R2View, 1, row);
            }
            Console.WriteLine("Log Me=>"+ gridNotes.Children.Count());
        }
        async void openAddPage(Object sender,EventArgs eventArgs)
        {
            await navigateToAddPageAsync("","");
        }

        private async Task navigateToAddPageAsync(string title, string message)
        {
            await Navigation.PushAsync(new AddNotePage(title, message));
        }
    }
}