using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritsu_sws120Project
{
    internal class Enrolment
    {
        public int studentID;
        private int courseCode;
        private int sectionNumber;

        public int StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }

        public int CourseCode
        {
            get { return courseCode; }
            set { courseCode = value; }
        }

        public int SectionNumber
        {
            get { return sectionNumber; }
            set { sectionNumber = value; }
        }

        public Enrolment(int StudentID, int CourseCode, int SectionNumber)
        {
            studentID = StudentID;
            courseCode = CourseCode;
            sectionNumber = SectionNumber;
        }

        public override string ToString()
        {
            return $"Student ID: {StudentID} \nCourse Code: {CourseCode} \nSection Number: {SectionNumber} ";
        }
    }
}
