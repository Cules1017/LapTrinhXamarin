using Lab4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab4.Views.StudentInfo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddStudent : ContentPage
    {
        Student _student;
        public AddStudent()
        {
            InitializeComponent();
            Title = "Thêm sinh viên";
        }
        public AddStudent(Student student)
        {
            InitializeComponent();
            Title = "Sửa sinh viên";
            _student = student;
            EntStudentName.Text = _student.StudentName;
            EntStudentYear.Text = _student.StudentYear.ToString();
            EntStudentFaculty.Text = _student.StudentFaculty;
        }
        protected override void OnAppearing()
        {
            EntStudentName.Focus();
        }

        private async void btnAddNewStudent_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(EntStudentName.Text) || string.IsNullOrEmpty(EntStudentYear.Text) || string.IsNullOrEmpty(EntStudentFaculty.Text))
            {
                await DisplayAlert("Thông báo", "Hãy điền đầy đủ các trường!", "Đóng");
            }
            else if(Regex.IsMatch(EntStudentYear.Text, @"^\d+$") == false)
            {
                await DisplayAlert("Thông báo", "Điền vào trường sinh viên năm là số", "Đóng");
            }
            else if (_student != null)
            {
                _student.StudentName = EntStudentName.Text;
                _student.StudentYear = int.Parse(EntStudentYear.Text);
                _student.StudentFaculty = EntStudentFaculty.Text;

                App.StudentDb.UpdateStudent(_student);
                await Navigation.PopAsync();
            }
            else
            {
                Student student = new Student()
                {
                    StudentName = EntStudentName.Text,
                    StudentYear = int.Parse(EntStudentYear.Text),
                    StudentFaculty = EntStudentFaculty.Text 
                };

                if (App.StudentDb.CreateStudent(student))
                {
                    await DisplayAlert("Thông báo", "Thêm Thành Công Sinh Viên!", "Đóng");
                    await Navigation.PopAsync();
                }
                else
                {
                    await DisplayAlert("Error", "Fail to add new student!", "Close");
                }
            }
        }
    }
}