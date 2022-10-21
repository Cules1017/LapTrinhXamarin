using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public class City 
    {
        public  string CityName { get; set; }
        public string CtyImg { get; set; }
    }

    public class Country: List<City>
    {
        public string CountryName { get; set; }
        
        public Country(string countryName)
        {
            CountryName = countryName;
        }
    }
    public partial class Page1 : ContentPage
    {
        public List <Country> CountryList { get; set; }
        void InitData()
        {
            Country VN = new Country("Việt Nam");
            VN.Add(new City { CityName = "Hà Nội" , CtyImg ="hn.jpg"});
            VN.Add(new City { CityName = "Đà Nẵng", CtyImg = "dn.jpg" } );
            VN.Add(new City { CityName = "TP Hồ Chí Minh", CtyImg = "hcm.jpg" });
            VN.Add(new City { CityName = "Hải Phòng", CtyImg = "hp.jpg" });
            VN.Add(new City { CityName = "Cần Thơ", CtyImg = "ct.jpg" });

            Country JP = new Country("Nhật Bản");
            JP.Add(new City { CityName = "ToKyo", CtyImg = "tk.jpg" });
            JP.Add(new City { CityName = "Kyoto", CtyImg = "kt.jpg" });
            JP.Add(new City { CityName = "Osaka", CtyImg = "os.jpg" });
            JP.Add(new City { CityName = "Hiroshima", CtyImg = "hr.jpg" });

            CountryList = new List<Country>();
            CountryList.Add(VN);
            CountryList.Add(JP);

        }
        public Page1()
        {
            InitializeComponent();
            InitData();
            Title = "Country List";
            GroupedView.ItemsSource= CountryList;

        }
    }
}