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
    public class khoa
    {
        public string Tenkhoa { get; set; }
        public khoa(string name)
        {
            this.Tenkhoa = name;    
        }
    }
    public partial class Page1 : ContentPage
    {
        public  List<khoa> DSkhoa;

        
        public Page1()
        {
            DSkhoa = new List<khoa>();
            DSkhoa.Add(new khoa("Khoa Khoa học máy tính"));
            DSkhoa.Add(new khoa("Khoa Kỹ thuật phần mềm"));
            DSkhoa.Add(new khoa("Khoa Hệ thống thông tin"));
            DSkhoa.Add(new khoa("Khoa Khoa học kỹ thuật thông tin"));
            DSkhoa.Add(new khoa("Khoa "));
            string[] DS = { "1","2","3" } ;
            InitializeComponent();
            dskhoa.ItemsSource = DSkhoa;
        }
    }
}