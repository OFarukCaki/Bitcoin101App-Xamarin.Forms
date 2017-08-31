using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Baslangic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class demo1 : ContentPage
    {
        public demo1()
        {
            InitializeComponent();

        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            //usdValue.Text = e.NewTextValue;
            //usdValue.Text = ((Entry)sender).Text;
            try
            {
                var usd = ((Entry)sender).Text;
                float usdInt = float.Parse(usd);
                usdInt = usdInt * 4000;
                usdValue.Text = usdInt.ToString() + " USD";
            }
            catch
            {
                usdValue.Text = "";
            }


        }

        private void usdValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            //try
            //{
            //    var btc = ((Entry)sender).Text;
            //    float btcInt = float.Parse(btc);
            //    btcInt = btcInt / 4000;
            //    btcValue.Text = btcInt.ToString();
            //}
            //catch
            //{
            //    btcValue.Text = "";
            //}
        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            if (btcAdress.Text == "1Pa6LVu1djwbV5DoHQgNkBaBQ52hiUx6pa" && float.Parse(btcValue.Text) >= 0.25)
            {
                //await Navigation.PopModalAsync();
                var res = await DisplayAlert("Başarılı!", btcAdress.Text + " adresine " + btcValue.Text + " BTC gönderildi.", "Devam Et", "Tekrar");

                if (res)
                {
                    //await DisplayAlert("true", "tru", "ok");     
                    //await Navigation.PopModalAsync();
                    //var caro = this.Parent as CarouselPage;
                    Device.BeginInvokeOnMainThread(() => {
                        Navigation.PopModalAsync();
                        Navigation.PushModalAsync(new anket());
});

                    //await Navigation.PushModalAsync(new anket());
                    // await Navigation.PushModalAsync(new b10() );

                }
                else
                {
                    //await DisplayAlert("fasle", "false", "ok");
                    await Navigation.PopModalAsync();
                }

            }
            else
            {
                //Label labelwoo = new Label { Text = " Hello ", BackgroundColor = Color.White, HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, TextColor = Color.Black };
                // errCell.Children.Add(labelwoo);
                errLabel.Text = "Sanırım bir şeyler yanlış. Gönderdiğin BTC adresinin doğru olduğundan ve yeterli miktarda gönderdiğinden emin olup tekrar dene.\n (Bir önceki sayfaya dönüp adresi tekrar kopyalayabilirsin)";
            }
        }
    }
}