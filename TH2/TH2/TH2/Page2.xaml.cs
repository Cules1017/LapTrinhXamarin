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
    public class City
    {
        public int Citynum { get; set; }
        public string Cityimg { get; set; }
        public string Cityname { get; set; }
        public City(int citynum, string cityimg, string cityname)
        {
            Citynum = citynum;
            Cityimg = cityimg;
            Cityname = cityname;
        }
    }
    public partial class Page2 : ContentPage
    {
        public List<City> Citylist { get; set; }
        public Page2()
        {
            Citylist = new List<City>();
            Citylist.Add(new City(1,  "hochiminh.jpg","Hồ Chí Minh" ));
            Citylist.Add(new City(2, "hanoi.jpg", "Hà Nội"));
            Citylist.Add(new City(3, "dalat.jpg", "Đà Lạt"));
            Citylist.Add(new City(4, "danang.jpg", "Đà Nẵng"));
            InitializeComponent();
            dscity.ItemsSource=Citylist;
        }

        private void dscity_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            City loc = (City)dscity.SelectedItem;
            Navigation.PushAsync(new HotelView(loc));
        }
    }
}