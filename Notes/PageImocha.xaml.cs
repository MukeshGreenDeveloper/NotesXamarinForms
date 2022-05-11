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
    public partial class PageImocha : ContentPage
    {
        public PageImocha()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        async public void OnTapped(Object sender, EventArgs eventArgs)
        {
            await Navigation.PushAsync(new HomeScreen());
            //Navigation.RemovePage(this);
        }

        async public void OnSwiped(object sender, SwipedEventArgs e)
        {
            if (e.Direction == SwipeDirection.Left)
            {
                //await Navigation.PopAsync();
                await Navigation.PushAsync(new HomeScreen());
                //Navigation.RemovePage(this);
                //App.Current.MainPage = new HomeScreen();
                //foreach (Page p in Navigation.NavigationStack)
                //{
                //    if (p.GetType() == typeof(PageImocha))
                //    {
                //        Navigation.RemovePage(p);
                //    }
                //}
            }
        }
    }
}