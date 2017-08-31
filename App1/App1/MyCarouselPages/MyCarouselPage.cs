using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.TabbedPages;
using App1.Baslangic;

namespace App1.MyCarouselPages
{
    public class MyCarouselPage : CarouselPage
    {
        public MyCarouselPage()
        {
            Children.Add(new b1());
            Children.Add(new b2());
        }
    }
}
