using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.MyMasterPages;

namespace App1.Baslangic
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class anket : ContentPage
    {
        public anket()
        {
            InitializeComponent();

        }

        private void picker1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(picker1.Items[picker1.SelectedIndex]);
        }


        private void switch1_OnChanged(object sender, ToggledEventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(switch1.On);
            //System.Diagnostics.Debug.WriteLine("asdas");
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            // System.Diagnostics.Debug.WriteLine(picker1.Items[picker1.SelectedIndex] + picker2.Items[picker2.SelectedIndex] + entry1.Text + entry2.Text + switch1.On + switch2.On + switch3.On + switch4.On );
            var s_1 = (switch1.On == true) ? 1 : 0; // merak
            var s_2 = (switch1.On == true) ? 1 : 0; // transfer
            var s_3 = (switch1.On == true) ? 1 : 0; // yatırım
            var s_4 = (switch1.On == true) ? 1 : 0; // odeme

            var p_1 = 10 - picker1.SelectedIndex;  // point
            var p_2 = picker2.SelectedIndex;       // later
            var p_3 = picker3.SelectedIndex;       // cinsiyet

            var e_1 = entry1.Text;      // country
            var e_2 = entry2.Text;      // age


            //System.Diagnostics.Debug.WriteLine(s_1+" & "+p_1);
            var url = "http://bitcoin101app.com/api/?p="+ p_1 +"&l="+ p_2 +"&c="+ e_1 +"&s="+ p_3 + "&a="+ e_2 +"&m="+ s_1 +"&t="+ s_2 +"&y="+ s_3 +"&o="+ s_4;
            //System.Diagnostics.Debug.WriteLine(url);

            try
            {                
                var client = new HttpClient();
                await client.GetStringAsync(url);
                await Navigation.PopModalAsync();


            }
            catch
            {
                await Navigation.PopModalAsync();
            }

            
            
        }


    }
}