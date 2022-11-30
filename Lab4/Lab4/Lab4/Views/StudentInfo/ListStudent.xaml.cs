using Lab4.Models;
using Lab4.Views.Booking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4.Views.StudentInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListStudent : ContentPage
    {
        ObservableCollection<Student> listStudent;
        public ListStudent()
        {
            InitializeComponent();
            listStudent= new ObservableCollection<Student>(App.StudentDb.ReadStudents());
            CVStudent.ItemsSource = listStudent;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            listStudent = new ObservableCollection<Student>(App.StudentDb.ReadStudents());
            CVStudent.ItemsSource = listStudent;
        }
        private void TIAddStudent_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AddStudent());
        }

        private async void SWDelete_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var student = swipeItem.CommandParameter as Student;

            bool answer = await DisplayAlert("Thông báo", $"Bạn có muốn xóa sinh viên '{student.StudentName}'? \nDữ liệu sẽ không thể khôi phục", "Xóa", "Không");
            if (answer)
            {
                App.StudentDb.DeleteStudent(student);
                listStudent = new ObservableCollection<Student>(App.StudentDb.ReadStudents());
                CVStudent.ItemsSource = listStudent;
            }
        }

        private void SWEdit_Invoked(object sender, EventArgs e)
        {
            var swipeItem = sender as SwipeItem;
            var student = swipeItem.CommandParameter as Student;

            Navigation.PushAsync(new AddStudent(student));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            CVStudent.ItemsSource = listStudent.Where(s => s.StudentName.ToLower().Contains(e.NewTextValue.ToLower()));
        }
    }
}