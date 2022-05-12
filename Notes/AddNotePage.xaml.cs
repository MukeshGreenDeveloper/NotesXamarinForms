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
    public partial class AddNotePage : ContentPage
    {
        string title, message;
        public AddNotePage(string title, string message)
        {
            this.title = title;
            this.message = message;
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            if (title!=null && title.Length > 0)
                EntryTitle.Text = title;
            if(message!=null && message.Length > 0)
                EntryDescription.Text = message;
            
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            EntryDescription.Focus();
        }
        async void backPressed(Object sender,EventArgs eventArgs)
        {
            Navigation.PopAsync();
        }
    }
}