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
    public partial class AddCity : ContentPage
    {
        City _city; 
        public AddCity()
        {
            InitializeComponent();
            Title = "Thêm thành phố mới";
        }
        public AddCity(City city)
        {
            InitializeComponent();
            Title = "Sửa thành phố";
            _city = city;
            EntCityName.Text = city.CityName;
            EntCityImg.Text = city.CityImageUrl;
        }
        protected override void OnAppearing()
        {
            EntCityName.Focus();
        }
        private async void btnAddNewCity_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntCityName.Text) || string.IsNullOrEmpty(EntCityImg.Text))
            {
                await DisplayAlert("Thông báo", "Vui lòng điền đủ thông tin!", "Đóng");
            }
            else if (_city != null)
            {
                _city.CityName = EntCityName.Text;
                _city.CityImageUrl = EntCityImg.Text;

                App.BookingDb.UpdateCity(_city);
                await Navigation.PopAsync();
            }
            else
            {
                City city = new City()
                {
                    CityName= EntCityName.Text,
                    CityImageUrl= EntCityImg.Text
                };

                if(App.BookingDb.CreateCity(city))
                {
                    await DisplayAlert("Thông báo", "Thêm mới thành công!", "Đóng");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Lỗi", "Thêm mới thất bại!", "Đóng");
                }
            }
        }
    }
}