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
    public partial class ListHotel : ContentPage
    {
        City _selectedCity;
        public ListHotel(City selectedCity)
        {
            InitializeComponent();
            _selectedCity = selectedCity;
            Title = _selectedCity.CityName;
            CVHotel.ItemsSource = App.BookingDb.ReadHotels(_selectedCity);
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CVHotel.ItemsSource = App.BookingDb.ReadHotels(_selectedCity);
        }
        private void TIAddHotel_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddHotel(_selectedCity));
        }

        private async void SWDelete_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var hotel = swipeItem.CommandParameter as Hotel;

            bool answer = await DisplayAlert("Thông Báo", $"Bạn có muốn xóa {hotel.HotelName} không?", "Có", "Không");
            if (answer)
            {
                App.BookingDb.DeleteHotel(hotel);
                CVHotel.ItemsSource = App.BookingDb.ReadHotels(_selectedCity);
            }
        }

        private void SWEdit_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var hotel = swipeItem.CommandParameter as Hotel;

            Navigation.PushAsync(new AddHotel(hotel, _selectedCity));
        }
    }
}