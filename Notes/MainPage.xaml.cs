using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Notes
{
    public partial class MainPage : ContentPage
    {
        //String URL= "https://social.msdn.microsoft.com/Forums/en-US/f990924b-7cf1-4538-9a17-6e45ed19828a/truncate-long-texts-with-ellipsis-on-label-control?forum=xamarinforms";
        String URL= "https://books.nowsecure.com/secure-mobile-development/en/coding-practices/code-complexity-and-obfuscation.html";
        //WebView webView;
        public MainPage()
        {
            InitializeComponent();
        }
        async void OnButtonClicked(object btn,EventArgs args)
        {
            layoutWeb.IsVisible = true;
            mGridLayout.IsVisible = false;
            mWebView.Source = URL;
        }
        async void OnCloseWebView(object btn,EventArgs args)
        {
            layoutWeb.IsVisible = false;
            mGridLayout.IsVisible = true;
        }
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            labelLoading.IsVisible = true;
            Console.WriteLine("keysss  ==> Loading In progress");
        }

        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            labelLoading.IsVisible = false;
            Console.WriteLine("keysss  ==> Loading Complete");
            urlLable.Text=URL;
        }
        public async Task OpenBrowser(Uri uri)
        {
            try
            {
                await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex="+ ex.StackTrace);
                // An unexpected error occured. No browser may be installed on the device.
            }
        }
    }
}
