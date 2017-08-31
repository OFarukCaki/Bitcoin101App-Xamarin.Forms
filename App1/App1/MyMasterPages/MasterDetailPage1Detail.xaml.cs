using App1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.MyMasterPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPage1Detail : ContentPage
    {
        public MasterDetailPage1Detail()
        {

            InitializeComponent();
            
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            // DisplayAlert("a", "asdsa", "OK");
            await Navigation.PushAsync(new MyCarouselPage());
        }

        
    }
}