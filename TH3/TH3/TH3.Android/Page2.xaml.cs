using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TH3.Droid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public class Book
    {
        public string TitleBook { get; set; }
        public string ImgBook { get; set; }
    }
    public partial class Page2 : ContentPage
    {
        public List<Book> books;
        void ListBookInit()
        {
            books = new List<Book>();
            books.Add(new Book { TitleBook = "Cô Gái Có Râu", ImgBook = ".jpg"});
            books.Add(new Book { TitleBook = "Doraemon", ImgBook = ".jpg" });
            books.Add(new Book { TitleBook = "Conan", ImgBook = ".jpg" });
            books.Add(new Book { TitleBook = "Truyện Ma Có Thật", ImgBook = ".jpg" });
            books.Add(new Book { TitleBook = "Sọ Dừa", ImgBook = ".jpg" });

            aaa.ItemsSource = books;
        }

        public void GetBook(string title)
        {
            foreach (var book in books)
            {
                if (book.TitleBook == title){
                    List <Book> lb= new List<Book>();
                    lb.Add(book);
                    listB.ItemsSource = lb;
                }
                
            }
            
        }
        public Page2()
        {
            InitializeComponent();
            ListBookInit();
            GetBook(" ");
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pic=(Picker)sender;
            int picidx=pic.SelectedIndex;
            if (picidx >= 0) { 
                GetBook(pic.Items[picidx].ToString());
            }
        }
    }
}