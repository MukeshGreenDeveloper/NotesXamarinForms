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
            
            for(int row = 0; row < 4; row++)
            {
                Label l = new Label
                {
                    Text = "LabelText",
                    FontAttributes = FontAttributes.Bold,

                };
                Label l2 = new Label
                {
                    Text = "LabelText",
                    FontAttributes = FontAttributes.Bold,

                };
                Frame R1View = new Frame
                {
                    BorderColor = (Color)Application.Current.Resources["GrayLine"],
                    CornerRadius = 8,
                    Content = l,
                    Padding = new Thickness(8, 8, 8, 8),
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Center, true)
                };
                Frame R2View = new Frame
                {
                    BorderColor = (Color)Application.Current.Resources["GrayLine"],
                    CornerRadius = 8,
                    Content = l2,
                    Padding = new Thickness(8, 8, 8, 8),
                    HorizontalOptions = new LayoutOptions(LayoutAlignment.Fill, true),
                    VerticalOptions = new LayoutOptions(LayoutAlignment.Center, true)
                };
                gridNotes.Children.Add(R1View, row, 0);
                gridNotes.Children.Add(R2View, row, 1);
            }
            gridNotes.SetRowSpan = 2;
            Console.WriteLine("Log Me=>"+ gridNotes.Children.Count());
            //gridNotes.Children.Add(view,0,0);
            //gridNotes.Children.Add(view, 0, 1);
            //gridNotes.Children.Add(view, 1, 0);
            //gridNotes.Children.Add(view, 1, 1);
            //gridNotes.Children.Add(view, 2, 0);
        }
    }
}