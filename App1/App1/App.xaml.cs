using App1.Baslangic;
using App1.MyMasterPages;
using App1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;


namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            //MainPage = new Views.Main();
            //MainPage = new MasterDetailPage1();
            MainPage = new language();
            //MainPage = new b9();
            //MainPage = new demo1();
            //MainPage = new MyCarouselPage();


        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
