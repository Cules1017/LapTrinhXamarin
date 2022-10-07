using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TH2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void bai1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }

        private void bai2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());

        }

        private void bai3_Clicked(object sender, EventArgs e)
        {

        }
    }
}
