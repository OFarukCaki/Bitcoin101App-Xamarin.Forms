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
	public partial class b9 : ContentPage
	{
		public b9 ()
		{
			InitializeComponent ();
		}

        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new demo1());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            //var caro = this.Parent as CarouselPage;
            //caro.CurrentPage = caro.Children[caro.Children.IndexOf(caro.CurrentPage) + 1];
        }
    }
}