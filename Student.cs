using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Gheorghe Georgescu 301377303
namespace Veritsu_sws120Project
{
    internal class Student : IRegister //use of interface
    {
        //fields
        private int studentID;
        private string firstName;
        private string lastName;
        private string email;
        private int phoneNumber;
        private int programCode;

        //properties
        public int StudentID
        {
            get { return studentID; }
            set 
            {
                if (value <= 0)
                    throw new Exception("\nStudent ID must be a positive acceptable number. ");
                studentID = value; 
            }
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
            set 
            {
                if (value <= 0)
                    throw new Exception("\nPhone Number must be a valid number. ");
                phoneNumber = value; 
            } 
        }
        public int ProgramCode
        { 
            get { return programCode; }
            set 
            {
                if (value <= 0)
                    throw new Exception("\nProgram COde must be a valid number. ");
                programCode = value; 
            } 
        }

        //constructor
        public Student(int StudentID, string FirstName, string LastName, string Email, int PhoneNumber, int ProgramCode)
        {
            studentID = StudentID;
            firstName = FirstName;
            lastName = LastName;
            email = Email;
            phoneNumber = PhoneNumber;
            programCode = ProgramCode;
        }

        public void Register() //made use of interface method
        {
            Console.WriteLine($"> Student #{studentID} successfully registered in program {programCode}. "); 
        }

        public override string ToString() //overriding ToString method for specific class Student.cs
        {
            return $"\nStudent ID: {StudentID} \nName: {FirstName} {LastName} \nEmail: {Email} " +
                $"\nPhone: {PhoneNumber} \nProgram Code: {ProgramCode}\n";
        }
    }
}
