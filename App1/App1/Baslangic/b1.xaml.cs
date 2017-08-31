using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Baslangic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class b1 : ContentPage
    {
       
        public b1()
        {           
            InitializeComponent();
            
            
            DisplayAlert("Başlangıç", "Başlangıç seviyesi eğitime hoşgeldin. Bir sonraki sayfaya geçmek için sayfayı kaydırabilirsin...", "OK");
        }

        public void Button_Clicked(object sender, EventArgs e)
        {
            //var carousel = ((App.Current.MainPage as MasterDetailPage).Detail as CarouselPage);
            //carousel.CurrentPage = carousel.Children[carousel.Children.IndexOf(carousel.CurrentPage) + 1];

             //var carousel = ((this.Parent as MasterDetailPage).Detail as CarouselPage);
            var caro = this.Parent as CarouselPage;
            caro.CurrentPage = caro.Children[caro.Children.IndexOf(caro.CurrentPage)+1];
            
        }


    }
}