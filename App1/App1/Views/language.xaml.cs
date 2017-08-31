using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.MyMasterPages;
using System.Net.Http;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class language : ContentPage
    {
        public language()
        {
            InitializeComponent();
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new MasterDetailPage1());
            await Navigation.PushModalAsync(new MasterDetailPage1());
        }

        //async public void Button_Clicked(object sender, EventArgs e)
        //{
        //    //await sendRequest();
        //    try
        //    {
        //        string url = "http://bitcoin101app.com/api/?p=10&l=0&c=wwwwwwww&s=0&a=20&m=1&t=1&y=1&o=1";
        //        var client = new HttpClient();
        //        await client.GetStringAsync(url);
                
        //    }
        //    catch
        //    {

        //    }
           

        //}

        
    }
}