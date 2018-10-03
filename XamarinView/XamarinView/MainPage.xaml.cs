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
            //declaramos variables que almacenaran los valores de
            //cada slider 0-255
            var red = redSlider.Value;
            var green = greeSlider.Value;
            var blue = blueSlider.Value;


            Color bgColor = new Color(red, green, blue);

            boxColor.BackgroundColor = bgColor;

            lblDisplay.Text = ColorToHex(bgColor);
            
        }

        private string ColorToHex(Color color)
        {
            int red = (int) (color.R * 255);
            int green = (int)(color.G * 255);
            int blue = (int)(color.B * 255);
            int alpha = (int)(color.A * 255);

            return $"#{red:X2}{green:X2}{blue:X2}{alpha:X2}";
        }
    }
}
