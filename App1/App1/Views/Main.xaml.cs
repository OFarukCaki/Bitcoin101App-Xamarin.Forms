using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Main : ContentPage
    {
        public Main()
        {
            InitializeComponent();
        }

        async void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            await DisplayAlert("clicked!",
                "the buton labeled '" + btn.Text + "' has been clciked and slider value is:"+valueLabel.Text,
                "OK");   
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            valueLabel.Text = e.NewValue.ToString("F1");
        }

        
    }
}