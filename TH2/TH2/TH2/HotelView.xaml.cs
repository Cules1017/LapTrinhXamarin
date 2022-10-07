using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    public class Hotel
    {
        public string Htname { get; set; }
        public string Htimg { get; set; }
        public string Htprice { get; set; }
        public string Htaddress { get; set; }
        public string Htdetail { get; set; }
         public Hotel(string htname, string htimg, string htprice, string htaddress, string htdetail)
        {
            Htname = htname;
            Htimg = htimg;
            Htprice = htprice;
            Htaddress = htaddress;
            Htdetail = htdetail;
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HotelView : ContentPage
    {
        public List<Hotel> HotelList { get; set; }
         
        void Khoitao(City city)
        {
            HotelList = new List<Hotel>();
            
            if(city.Citynum == 1)
            {
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
            }
            else if(city.Citynum == 2)
            {
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
            }
            else if (city.Citynum == 3)
            {
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
            }
        }
        public HotelView(City city)
        {
            InitializeComponent();
            //Khoitao(city);
            HotelList = new List<Hotel>();

            if (city.Citynum == 1)
            {
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));

            }
            else if (city.Citynum == 2)
            {
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));

                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
            }
            else if (city.Citynum == 3)
            {
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));

                HotelList.Add(new Hotel("Khách Sạn chà bà", "hanoi.jpg", "90.000đ", "Ba đình", "thật khó chịu"));
            }
            dshotel.ItemsSource= HotelList;
        }
    }
}