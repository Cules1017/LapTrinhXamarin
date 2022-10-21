using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public List<Country> CountryList1 { get; set; }
        void InitData()
        {
            Country VN = new Country("Việt Nam");
            VN.Add(new City { CityName = "Hà Nội", CtyImg = "hn.jpg" });
            VN.Add(new City { CityName = "Đà Nẵng", CtyImg = "dn.jpg" });
            VN.Add(new City { CityName = "TP Hồ Chí Minh", CtyImg = "hcm.jpg" });
            VN.Add(new City { CityName = "Hải Phòng", CtyImg = "hp.jpg" });
            VN.Add(new City { CityName = "Cần Thơ", CtyImg = "ct.jpg" });

            Country JP = new Country("Nhật Bản");
            JP.Add(new City { CityName = "ToKyo", CtyImg = "tk.jpg" });
            JP.Add(new City { CityName = "Kyoto", CtyImg = "kt.jpg" });
            JP.Add(new City { CityName = "Osaka", CtyImg = "os.jpg" });
            JP.Add(new City { CityName = "Hiroshima", CtyImg = "hr.jpg" });
            Country ALL = new Country("ALL");
            List<City> CityList = new List<City>();
            CityList.Add(new City { CityName = "Hà Nội", CtyImg = "hn.jpg" });
            CityList.Add(new City { CityName = "Đà Nẵng", CtyImg = "dn.jpg" });
            CityList.Add(new City { CityName = "TP Hồ Chí Minh", CtyImg = "hcm.jpg" });
            CityList.Add(new City { CityName = "Hải Phòng", CtyImg = "hp.jpg" });
            CityList.Add(new City { CityName = "Cần Thơ", CtyImg = "ct.jpg" });
            CityList.Add(new City { CityName = "ToKyo", CtyImg = "tk.jpg" });
            CityList.Add(new City { CityName = "Kyoto", CtyImg = "kt.jpg" });
            CityList.Add(new City { CityName = "Osaka", CtyImg = "os.jpg" });
            CityList.Add(new City { CityName = "Hiroshima", CtyImg = "hr.jpg" });
            GroupedView11111.ItemsSource = CityList;
            CountryList1 = new List<Country>();
            CountryList1.Add(VN);
            CountryList1.Add(JP);
            CountryList1.Add(ALL);
            aaa1.ItemsSource = CountryList1;


        }
        public void GetCityinCountry(string title)
        {
            List<City> lb = new List<City>();
            
                if (title == "Nhật Bản")
                {
                    lb.Add(new City { CityName = "ToKyo", CtyImg = "tk.jpg" });
                    lb.Add(new City { CityName = "Kyoto", CtyImg = "kt.jpg" });
                    lb.Add(new City { CityName = "Osaka", CtyImg = "os.jpg" });
                    lb.Add(new City { CityName = "Hiroshima", CtyImg = "hr.jpg" });
                }
                else if(title=="ALL")
            {
                lb.Add(new City { CityName = "ToKyo", CtyImg = "tk.jpg" });
                lb.Add(new City { CityName = "Kyoto", CtyImg = "kt.jpg" });
                lb.Add(new City { CityName = "Osaka", CtyImg = "os.jpg" });
                lb.Add(new City { CityName = "Hiroshima", CtyImg = "hr.jpg" });
                lb.Add(new City { CityName = "Hà Nội", CtyImg = "hn.jpg" });
                lb.Add(new City { CityName = "Đà Nẵng", CtyImg = "dn.jpg" });
                lb.Add(new City { CityName = "TP Hồ Chí Minh", CtyImg = "hcm.jpg" });
                lb.Add(new City { CityName = "Hải Phòng", CtyImg = "hp.jpg" });
                lb.Add(new City { CityName = "Cần Thơ", CtyImg = "ct.jpg" });
            }
                else
                {
                    lb.Add(new City { CityName = "Hà Nội", CtyImg = "hn.jpg" });
                    lb.Add(new City { CityName = "Đà Nẵng", CtyImg = "dn.jpg" });
                    lb.Add(new City { CityName = "TP Hồ Chí Minh", CtyImg = "hcm.jpg" });
                    lb.Add(new City { CityName = "Hải Phòng", CtyImg = "hp.jpg" });
                    lb.Add(new City { CityName = "Cần Thơ", CtyImg = "ct.jpg" });
                }
                GroupedView11111.ItemsSource = lb;

            

        }
        public Page3()
        {
            InitializeComponent();
            InitData();
            Title = "Country List";
        }

        private void aaa1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pic = (Picker)sender;
            int picidx = pic.SelectedIndex;
            if (picidx >= 0)
            {
                GetCityinCountry(pic.Items[picidx].ToString());
            }
        }
    }
}