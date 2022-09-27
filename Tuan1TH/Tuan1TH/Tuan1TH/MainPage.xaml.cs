using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tuan1TH
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Btn_Bai1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai1());
        }

        private void Btn_Bai2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai2());

        }

        private void Btn_Bai3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai3());

        }
        private void Btn_Bai4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai4());

        }

        private void Btn_Bai5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Bai5());
        }
    }
}
