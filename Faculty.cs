using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veritsu_sws120Project
{
    internal class Faculty
    {
        private int facultyID;
        private string firstName;
        private string lastName;
        private string email;
        private int phoneNumber;

        public int FacultyID
        {
            get { return facultyID; }
            set { facultyID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public Faculty(int FacultyID, string FirstName, string LastName, string Email, int PhoneNumber)
        {
            facultyID = FacultyID;
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            phoneNumber = PhoneNumber;
        }

        public override string ToString()
        {
            return $"Faculty ID: {FacultyID} \nName: {FirstName} {LastName} \nEmail: {Email} " +
                $"\nPhone: {PhoneNumber}";
        }
    }
}
