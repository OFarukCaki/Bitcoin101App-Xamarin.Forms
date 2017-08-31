using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.TabbedPages;
using App1.Baslangic;

namespace App1.Views
{
    public class MyCarouselPage : CarouselPage
    {
        public MyCarouselPage()
        {
            this.BackgroundColor = Color.FromHex("#5B5999");
            this.Title = "1.1 - Bitcoin Nedir";
            //this.CurrentPage = this.Children[4];            

            Children.Add(new b1() { Title = "1.1 - Bitcoin Nedir" });
            Children.Add(new b2() { Title = "1.2 - Bitcoinin Yapısı" });
            Children.Add(new b3() { Title = "1.3 - Bitcoin Cüzdanı ve İşlemler" });
            Children.Add(new b4() { Title = "1.4 - Bitcoin Madenciliği" });
            Children.Add(new b5() { Title = "1.5 - Güvenlik" });
            Children.Add(new b6() { Title = "1.6 - Bitcoin Temini" });
            Children.Add(new b7() { Title = "1.7 - Gizlilik" });
            Children.Add(new b8() { Title = "1.8 - Önemli Noktalar" });
            Children.Add(new b9());
            //Children.Add(new b10());
            
            this.CurrentPageChanged += CurrentPageHasChanged;

        }
        protected void CurrentPageHasChanged(object sender, EventArgs e)
        {
            this.Title = this.CurrentPage.Title;
        }
        
    }
}
