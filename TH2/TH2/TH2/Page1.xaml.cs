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
            DSkhoa.Add(new khoa("NGÀNH CÔNG NGHỆ THÔNG TIN"));
            DSkhoa.Add(new khoa("NGÀNH HỆ THỐNG THÔNG TIN"));
            DSkhoa.Add(new khoa("NGÀNH KHOA HỌC MÁY TÍNH"));
            DSkhoa.Add(new khoa("NGÀNH KỸ THUẬT PHẦN MỀM"));
            DSkhoa.Add(new khoa("NGÀNH KỸ THUẬT MÁY TÍNH"));
            DSkhoa.Add(new khoa("NGÀNH MẠNG MÁY TÍNH & TRUYỀN THÔNG DỮ LIỆU"));
            DSkhoa.Add(new khoa("NGÀNH AN TOÀN THÔNG TIN"));
            DSkhoa.Add(new khoa("NGÀNH THƯƠNG MẠI ĐIỆN TỬ"));
            DSkhoa.Add(new khoa("NGÀNH KHOA HỌC DỮ LIỆU"));
            string[] DS = { "1","2","3" } ;
            InitializeComponent();
            dskhoa.ItemsSource = DSkhoa;
        }
    }
}