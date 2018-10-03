using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page_tres : ContentPage
	{
		public Page_tres ()
		{
			InitializeComponent ();
            picker.Time = new TimeSpan(17, 0, 0);
		}

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblDisplay.Text = slider.Value.ToString();
        }

        private void btnSimulate_Clicked(object sender, EventArgs e)
        {
            progress.ProgressTo(.1, 250, Easing.BounceOut);
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Switch", "Switch", "ok");
        }

        private async void webView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            var canGoBack = webView.CanGoBack;
            var canGoFoward = webView.CanGoForward;

            await DisplayAlert("Navegando", "Pagina Cargando", "ok");

            if (canGoBack)
            {
                webView.GoBack();
            }
            
        }

        private void webView_Navigating(object sender, WebNavigatingEventArgs e)
        {

        }
    }
}