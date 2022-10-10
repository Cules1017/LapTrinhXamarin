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
            Title = " Danh sách khách sạn " + city.Cityname; 
            HotelList = new List<Hotel>();

            if (city.Citynum == 2)
            {
                HotelList.Add(new Hotel("Khách sạn Hanoi Sunshine", "ks1.jpg", "768.000  VND", "49 Lãn Ông, Hàng Bồ, Quận Hoàn Kiếm, Hà Nội, Việt Nam, 108313", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng! \r\nCó hoá đơn Giá Trị Gia Tăng cho đặt chỗ thanh toán khi nhận phòng"));
                HotelList.Add(new Hotel("Ma Coeur Boutique Hotel", "ks2.jpg", "1.768.000  VND", "08 Ngõ Thọ Xương, Phố Ấu Triệu, Phường Hàng Trống, Quận Hoàn Kiếm, Hà Nội, Việt Nam, 100000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí"));
                HotelList.Add(new Hotel("Classy Boutique Hotel", "ks3.jpg", "754.000  VND", "Đường Đại Dương, Quận Gia Lâm, Hà Nội, Việt Nam, 100000", "thật khó chịu1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí"));
                HotelList.Add(new Hotel("Pan Pacific Hanoi", "ks4.jpg", "1.303.000  VND", "1 Thanh Niên, Trúc Bạch, Quận Ba Đình, Hà Nội, Việt Nam, 100000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí"));

            }
            else if (city.Citynum == 1)
            {
                HotelList.Add(new Hotel("The Hotel Nicecy", "ks5.jpg", "968.000  VND", "178 Bùi Viện, Phạm Ngũ Lão, Phạm Ngũ Lão, Quận 1, Thành phố Hồ Chí Minh, Việt Nam, 711248", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("ACE Hotel Saigon", "ks6.jpg", "2.348.000  VND", "202 Hoàng Văn Thụ, Phường 9, Phường 9, Quận Phú Nhuận, Thành phố Hồ Chí Minh, Việt Nam, 700000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("La Vela Saigon Hotel", "ks7.jpg", "1.768.000  VND", "261C Nguyen Van Troi, Ward 10, Phu Nhuan, Ho Chi Minh, phường 10, Quận Phú Nhuận, Thành phố Hồ Chí Minh, Việt Nam, 700000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("Khách sạn Cozrum Lux", "ks8.jpg", "2.845.000  VND", "271 Lê Thánh Tôn, Phường Bến Thành, Quận 1, Thành phố Hồ Chí Minh, Việt Nam, 711035", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
            }
            else if (city.Citynum == 3)
            {
                HotelList.Add(new Hotel("Terracotta Hotel & Resort Dalat", "ks9.jpg", "1.968.000  VND", "117 Bùi Thị Xuân, Phường 2, Phường 2, Đà Lạt, Tỉnh Lâm Đồng, Việt Nam, 670000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("Khách Sạn Marigold Đà Lạt", "ks10.jpg", "2.348.000  VND", "83 Bui Thi Xuan, Phường 2, Đà Lạt, Tỉnh Lâm Đồng, Việt Nam, 670000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("Pontus Hotel", "ks11.jpg", "768.000  VND", "10 Phan Bội Châu, Phường 1, Đà Lạt, Tỉnh Lâm Đồng, Việt Nam, 670000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("Hôtel Colline Dalat", "ks12.jpg", "5.458.000  VND", "51 Nam Kỳ Khởi Nghĩa, Phường 1, Đà Lạt, Tỉnh Lâm Đồng, Việt Nam, 671552", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));

            }
            else if (city.Citynum == 4)
            {
                HotelList.Add(new Hotel("The Herriott Hotel & Suite", "ks13.jpg", "931.000  VND", "6 Lê Quang Đạo, Mỹ An, Ngũ Hành Sơn, Đà Nẵng, Việt Nam, 550000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("Seashore Hotel & Apartment", "ks14.jpg", "5.348.000  VND", "31 Hà Bổng, Phường Phước Mỹ, Phước Mỹ, Sơn Trà, Đà Nẵng, Việt Nam, 550000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("Raon Danang Beach Hotel", "ks15.jpg", "168.000  VND", "962 Ngô Quyền, An Hải Tây, Sơn Trà, Đà Nẵng, Việt Nam", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));
                HotelList.Add(new Hotel("Zalo Sea Hotel", "ks16.jpg", "9.458.000  VND", "Lô 7 & 8 Lê Văn Quý, An Hải Bắc, Sơn Trà, Đà Nẵng, Việt Nam, 550000", "1 Giường Đôi Hoặc 2 Giường Đơn\r\n2 khách\r\n(3 phòng trống)\r\nKhông gồm bữa sáng\r\nWiFi miễn phí\r\nKhông hút thuốc\r\nHủy phòng có thu phí\r\nXem Chính sách huỷ phòng\r\nThanh toán khi nhận phòng\r\nĐặt KHÔNG cần thanh toán trước! Tiết kiệm cho đến khi nhận phòng!"));

            }
            dshotel.ItemsSource= HotelList;
        }

        private void dshotel_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Hotel ks = (Hotel)dshotel.SelectedItem;
            Navigation.PushAsync( new HotelDetailView(ks));
        }
    }
}