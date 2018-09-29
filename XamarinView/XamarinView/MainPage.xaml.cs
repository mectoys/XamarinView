using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinView
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            dtp.Date = DateTime.Now;
            dtp.MinimumDate = new DateTime(1990,1,1);
            dtp.MaximumDate = new DateTime(2020,1,1);

        }

        private void Entry_Completed(object sender, EventArgs e)
        {

        }

        private void redSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {

        }
    }
}
