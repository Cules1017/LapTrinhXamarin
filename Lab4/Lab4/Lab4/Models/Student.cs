using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4.Models
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentYear  { get; set; }
        public string StudentFaculty { get; set; }
    }
}
