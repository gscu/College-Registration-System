using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritsu_sws120Project
{
    internal class Course
    {
        private int courseCode;
        private string courseName;
        public int facultyID;
        private int creditHours;

        public int CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        public int FacultyID
        {
            get { return facultyID; }
            set { facultyID = value; }
        }
        public int CreditHours
        {
            get { return creditHours; }
            set { creditHours = value; }
        }

        public Course (int CourseCode, string CourseName, int FacultyID, int CreditHours)
        {
           courseCode = CourseCode;
           courseName = CourseName;
           facultyID = FacultyID;
           creditHours = CreditHours;
        }

        public override string ToString()
        {
            return $"\nCourse Code: {CourseCode} \nCourse Name: {CourseName} \nFaculty ID: {FacultyID} " +
                $"\nCreditHours: {CreditHours}\n";
        }
    }
}
