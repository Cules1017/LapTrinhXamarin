using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4.Views.Booking
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddHotel : ContentPage
    {
        Hotel _hotel;
        public AddHotel(City selectedCity)
        {
            InitializeComponent();
            Title = "Thêm khách sạn mới";
            PkCityName.ItemsSource = App.BookingDb.ReadCities();
            for(var i = 0; i < PkCityName.ItemsSource.Count; i++)
            {
                if (PkCityName.Items[i] == selectedCity.CityName)
                    PkCityName.SelectedIndex = i;
            }
        }
        public AddHotel(Hotel hotel, City selectedCity)
        {
            InitializeComponent();
            Title = "Sửa khách sạn";
            PkCityName.ItemsSource = App.BookingDb.ReadCities();
            for (var i = 0; i < PkCityName.ItemsSource.Count; i++)
            {
                if (PkCityName.Items[i] == selectedCity.CityName)
                    PkCityName.SelectedIndex = i;
            }
            _hotel = hotel;
            EntHotelName.Text = hotel.HotelName;
            EntHotelImg.Text = hotel.HotelImageUrl;
        }
        protected override void OnAppearing()
        {
            EntHotelName.Focus();
        }
        private async void btnAddNewHotel_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntHotelImg.Text) || string.IsNullOrEmpty(EntHotelName.Text))
            {
                await DisplayAlert("Thông báo", "Vui lòng điền đầy đủ thông tin!!!","Đóng");
            }
            else if (_hotel != null)
            {
                _hotel.HotelName = EntHotelName.Text;
                _hotel.HotelImageUrl = EntHotelImg.Text;
                _hotel.CityName = (PkCityName.SelectedItem as City).CityName;
                
                App.BookingDb.UpdateHotel(_hotel);
                await Navigation.PopAsync();
            }
            else
            {
                Hotel hotel = new Hotel()
                {
                    HotelName = EntHotelName.Text,
                    HotelImageUrl = EntHotelImg.Text,
                    CityName = (PkCityName.SelectedItem as City).CityName
                };

                if (App.BookingDb.CreateHotel(hotel))
                {
                    await DisplayAlert("Thông báo", "Thêm mới thành công!!!", "Đóng");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Lỗi", "Thêm mới thất bại!!!", "Đóng");
                }
            }
        }
    }
}