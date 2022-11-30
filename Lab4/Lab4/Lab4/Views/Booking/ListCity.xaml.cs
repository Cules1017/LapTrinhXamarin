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
    public partial class ListCity : ContentPage
    {
        public ListCity()
        {
            InitializeComponent();
            CVCity.ItemsSource = App.BookingDb.ReadCities();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CVCity.ItemsSource = App.BookingDb.ReadCities();
        }
        private void TIAddCity_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddCity());
        }
        private async void SWDelete_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var city = swipeItem.CommandParameter as City;

            bool answer = await DisplayAlert("Thông Báo", $"Bạn có muốn xóa {city.CityName} không?", "Có", "Không");
            if (answer)
            {
                App.BookingDb.DeleteCity(city);
                CVCity.ItemsSource = App.BookingDb.ReadCities();
            }
        }

        private void SWEdit_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var city = swipeItem.CommandParameter as City;

            Navigation.PushAsync(new AddCity(city));
        }

        private void CVCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            City selectedCity = (City)CVCity.SelectedItem;
            Navigation.PushAsync(new ListHotel(selectedCity));
        }

    }
}