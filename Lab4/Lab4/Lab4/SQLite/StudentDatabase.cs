using Lab4.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Lab4.SQLite
{
    public class StudentDatabase
    {
        private readonly SQLiteConnection db;
        public StudentDatabase()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            db = new SQLiteConnection(System.IO.Path.Combine(folder, "StudentDatabase.db3"));
            db.CreateTable<Student>();
            
        }

        //Student
        public bool CreateStudent(Student student)
        {
            try
            {
                db.Insert(student);
                return true;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }
        public List<Student> ReadStudents()
        {
            try
            {
                return db.Table<Student>().ToList();
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return null;
                throw;
            }
        }
        public bool UpdateStudent(Student student)
        {
            try
            {
                db.Update(student);
                return true;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }
        public bool DeleteStudent(Student student)
        {
            try
            {
                db.Delete(student);
                return true;
            }
            catch (SQLiteException e)
            {
                Debug.WriteLine(e);
                return false;
                throw;
            }
        }
    }
}
