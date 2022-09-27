using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Tuan1TH
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai3 : ContentPage
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Thông Báo", "Submit Thành Công", "Close");

        }
    }
}