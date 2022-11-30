using Lab4.SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4
{
    public partial class App : Application
    {
        public static BookingDatabase BookingDb = new BookingDatabase();
        public static StudentDatabase StudentDb = new StudentDatabase();
        
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
