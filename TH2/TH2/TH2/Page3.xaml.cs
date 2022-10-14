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
    public class AnimalFamily
    {
        public int AFid { get; set; }
        public string AFname { get; set; }
        public string AFimg { get; set; }
        public AnimalFamily(int afid, string afname, string afimg)
        {
            AFid = afid;
            AFname = afname;
            AFimg = afimg;
        }


    }
    public partial class Page3 : ContentPage
    {
        public List<AnimalFamily> ListAF { get; set; }
        public Page3()
        {
            ListAF = new List<AnimalFamily>();
            ListAF.Add(new AnimalFamily(1, "Họ Chó", "C_00.jpg"));
            ListAF.Add(new AnimalFamily(2, "Họ Mèo", "M_00.jpg"));
            ListAF.Add(new AnimalFamily(3, "Họ Rùa", "R_00.jpg"));
            ListAF.Add(new AnimalFamily(4, "Họ Chim", "CM_00.jpg"));
            InitializeComponent();
            dsanimal.ItemsSource = ListAF;
        }

        private void dsanimal_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            AnimalFamily a = (AnimalFamily)dsanimal.SelectedItem;
            Navigation.PushAsync(new AnimalView(a));
        }

        private void SearchBar_SearchButtonPressed(object sender, EventArgs e)
        {
            string queryString=searchbar.Text;
            var normalizedQuery = queryString?.ToLower() ?? "";
            dsanimal.ItemsSource= ListAF.Where(f => f.AFname.ToLowerInvariant().Contains(normalizedQuery)).ToList();
        }
    }
}