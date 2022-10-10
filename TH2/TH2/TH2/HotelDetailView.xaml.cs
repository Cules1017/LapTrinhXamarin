using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotelDetailView : ContentPage
    {
        public HotelDetailView( Hotel ks)
        {
            Title = "Chi tiết khách sạn "+ks.Htname;
            InitializeComponent();
            BindingContext = ks;
        }
    }
}