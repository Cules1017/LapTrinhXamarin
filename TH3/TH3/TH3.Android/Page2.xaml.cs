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
            books.Add(new Book { TitleBook = "", ImgBook = ".jpg"});
            books.Add(new Book { TitleBook = "", ImgBook = ".jpg" });
            books.Add(new Book { TitleBook = "", ImgBook = ".jpg" });
            books.Add(new Book { TitleBook = "", ImgBook = ".jpg" });
            books.Add(new Book { TitleBook = "", ImgBook = ".jpg" });
        }

        public Book GetBook(string title)
        {
            foreach (var book in books)
            {
                if (book.TitleBook == title){
                    return book;
                }
                
            }
            return null;
        }
        public Page2()
        {
            InitializeComponent();
            ListBookInit();
            GetBook(" ");
        }

        private void Picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}