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
    public partial class Page_dos : ContentPage
    {
        public Page_dos()
        {
            InitializeComponent();
        }

        private void stepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblDisplay.Text =
                    stepper.Value.ToString();
        }

        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var elementoSeleccionado =
                picker.SelectedItem as string;
            DisplayAlert("Seleccion: " , elementoSeleccionado.ToString(),"ok");
        }
    }
}