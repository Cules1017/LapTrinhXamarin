using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalDetailView : ContentPage
    {
        public AnimalDetailView(Animal a)
        {
            InitializeComponent();
            BindingContext = a;
            Title = $"Thông tin về {a.Aname}";
        }
    }
}