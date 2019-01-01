using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TheButlerandGordon
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            browser.Source = "https://thebutlergordonapp.com";
        }


        void WebOnNavigating(object sender, WebNavigatingEventArgs s)

        {

            if (s.Url.StartsWith("tel:") || s.Url.StartsWith("sms:") || s.Url.StartsWith("mailto:") || s.Url.StartsWith("skype:"))
            {
                var uri = new Uri(s.Url); Device.OpenUri(uri); s.Cancel = true;
            }
            else
            {
                loading.IsVisible = true;
            }
        }

        void WebOnNavigated(object sender, WebNavigationEventArgs s)
        {
            loading.IsVisible = false;
        }
    }
}