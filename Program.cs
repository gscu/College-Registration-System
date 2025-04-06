using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Gheorghe Georgescu 301377303
namespace Veritsu_sws120Project
{
    internal class Program
    {
        //static lists to make them available across all static methods
        static List<Student> students = new List<Student>();
        static List<Faculty> faculties = new List<Faculty>();
        static List<Course> courses = new List<Course>();
        static List<Enrolment> enrolments = new List<Enrolment>();
        static List<CollegeProgram> programs = new List<CollegeProgram>();
        static void Main(string[] args)
        {
            //while loop menu utilizing switch cases
            while (true)
            {
                Console.WriteLine("\n----- COLLEGE REGISTRATION SYSTEM -----");
                Console.WriteLine("   1 - Register a Student");
                Console.WriteLine("   2 - Create a Course");
                Console.WriteLine("   3 - Designate a Faculty");
                Console.WriteLine("   4 - Add a Program");
                Console.WriteLine("   5 - Enroll a Student for a Course");
                Console.WriteLine("   6 - Display a Student's Enrolled Courses");
                Console.WriteLine("   7 - Display Enrollment for a Course");
                Console.WriteLine("   8 - Display Courses taught by Faculty");
                Console.WriteLine("   9 - Display Students in Program");
                Console.WriteLine("   0 - EXIT");
                Console.Write("Select an option (enter number): ");
                
                switch (Console.ReadLine())
                {
                    case "1": Console.WriteLine(); RegisterStudent(); break;
                    case "2": Console.WriteLine(); CreateCourse(); break;
                    case "3": Console.WriteLine(); AddFaculty(); break;
                    case "4": Console.WriteLine(); AddProgram(); break;
                    case "5": Console.WriteLine(); EnrollStudent(); break;
                    case "6": Console.WriteLine(); DisplayStudentCourses(); break;
                    case "7": Console.WriteLine(); DisplayCourseStudents(); break;
                    case "8": Console.WriteLine(); DisplayFacultyCourses(); break;
                    case "9": Console.WriteLine(); DisplayStudentsInProgram(); break;
                    case "0": Console.WriteLine("Logging off... \n\nSuccessfully logged out. \n"); return; //ends program.
                    default: Console.WriteLine("Invalid option. Please try again. \n Enter a valid number as indicated. \n"); break;
                }
            }
        }

        static void RegisterStudent()
        {
            int studentID = 0;
            int programCode = 1;
            while (true)
            {
                bool exist = false;
                //inputs for student registration 
                Console.Write("Enter Student ID: ");
                studentID = ReadInt(); //check the ReadInt() method made at the bottom for further details 
                
                //checks if id student ID already exist in the students list; ID must be unique
                foreach (var check in students)
                    if (check.StudentID == studentID)
                        { exist = true; break; }

                if (exist)
                    Console.WriteLine("Student ID taken! Please enter a new student ID. ");
                else 
                    break; //if it doesn't exist then we can proceed
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Phone number (no dashes or brackets): ");
            int phoneNum = ReadInt();

            while (true)
            {
                bool exist = false;
                //checking programCode
                Console.Write("Enter Program Code: ");
                programCode = ReadInt();

                if (programCode == 0)
                {
                    Console.WriteLine("\nOperation cancelled. Returning to previous menu. ");
                    return; //exits RegisterStudent method
                }

                //checks if program code already exist in the programs list; must be unique
                foreach (var check in programs)
                    if (check.ProgramCode == programCode)
                    { exist = true; break; }

                if (exist)
                    break;

                else
                    Console.WriteLine("Program code doesn't exist! Please enter a valid program code or type 0 to cancel. "); //if it doesn't exist then we can proceed
            }

            //new student object + adding it to students list
            Student student = new Student(studentID, firstName, lastName, email, phoneNum, programCode);
            students.Add(student);
            student.Register(); //confirmation of registration   
        }

        static void CreateCourse()
        {
            int courseCode = 0;
            int facultyID = 1;

            while (true)
            {
                bool exist = false;
                //input for course details
                Console.Write("Enter the Course Code: ");
                courseCode = ReadInt();

                //checks if course code already exist in the courses list; must be unique
                foreach (var check in courses)
                    if (check.CourseCode == courseCode)
                        { exist = true; break; }

                if (exist)
                    Console.WriteLine("Course code taken! Please enter a new course code. ");
                else
                    break; //if it doesn't exist then we can proceed
            }

            Console.Write("Enter the Course Name: ");
            string courseName = Console.ReadLine();

            while (true)
            {
                bool exist = false;
                //checking facultyID
                Console.Write("Enter Faculty ID: ");
                facultyID = ReadInt();

                if (facultyID == 0)
                {
                    Console.WriteLine("\nOperation cancelled. Returning to previous menu. ");
                    return; //exits CreateCourse method
                }

                //checks if faculty ID already exist in the faculties list; must be unique
                foreach (var check in faculties)
                    if (check.FacultyID == facultyID)
                        { exist = true; break; }

                if (exist)
                    break;
                    
                else
                    Console.WriteLine("Faculty ID doesn't exist! Please enter a valid faculty ID or type 0 to cancel. "); //if it doesn't exist then we can proceed
            }

            Console.Write("Enter Total Credit Hours: ");
            int creditHours = ReadInt();

            //adding the new course object to the courses list
            Course course = new Course(courseCode, courseName, facultyID, creditHours);
            courses.Add(course);
        }

        static void AddFaculty()
        {
            int facultyID = 1;

            while (true)
            {
                bool exist = false;
                //input for faculty
                Console.Write("Enter Faculty ID: ");
                facultyID = ReadInt();

                //checks if faculty ID already exist in the faculties list; must be unique
                foreach (var check in faculties)
                    if (check.FacultyID == facultyID)
                        { exist = true; break; }

                if (exist)
                    Console.WriteLine("Faculty ID taken! Please enter a new faculty ID. ");
                else
                    break; //if it doesn't exist then we can proceed
            }

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            int phoneNum = ReadInt();

            //adding new faculty object to the faculties list
            Faculty faculty = new Faculty(facultyID, firstName, lastName, email, phoneNum);
            faculties.Add(faculty);
        }
        static void AddProgram()
        {
            int programCode = 0;

            while (true)
            {
                bool exist = false;
                //input for college program
                Console.Write("Enter the Program Code: ");
                programCode = ReadInt();

                //checks if program code already exist in the programs list; must be unique
                foreach (var check in programs)
                    if (check.ProgramCode == programCode)
                        { exist = true; break; }

                if (exist)
                    Console.WriteLine("Program code taken! Please enter a new program code. ");
                else
                    break; //if it doesn't exist then we can proceed
            }

            Console.Write("Enter the Program Title: ");
            string programTitle = Console.ReadLine();

            Console.Write("Enter Credential: ");
            string credential = Console.ReadLine();

            //adding new CollegeProgram object to the programs list
            CollegeProgram program = new CollegeProgram(programCode, programTitle, credential);
            programs.Add(program);
        }

        static void EnrollStudent()
        {
            //input for enrolling student to a course
            Console.Write("Enter the Student ID: ");
            int studentID = ReadInt();

            Console.Write("Enter the Course Code: ");
            int courseCode = ReadInt();

            Console.Write("Enter Section Number: ");
            int sectionNum = ReadInt();

            //add new Enrolment object to the enrolments list
            Enrolment enrollment = new Enrolment(studentID, courseCode, sectionNum);
            enrolments.Add(enrollment);
        }

        //methods non-class related
        static void DisplayStudentCourses()
        {
            //input of specific Student ID
            Console.Write("Enter Student ID: ");
            int studentID = ReadInt();

            //search for courses enrolled for the inputted student ID 
            List<string> studentCourses = new List<string>(); //create student course list
            foreach (var enrolment in enrolments) 
            {
                if (enrolment.studentID == studentID) //scans for student ID match, via looping enrolment list
                {
                    studentCourses.Add((enrolment.CourseCode).ToString()); //if a course is found for the student ID then it is added to the studentCourses list
                }
            }

            //finds additional course details and displays it
            foreach (var courseCode in studentCourses)
            {
                //going through each courseCode added studentCourse list, we now extract it more details from the courses list
                foreach (var course in courses) 
                {
                    if (course.CourseCode == int.Parse(courseCode)) 
                    {
                        Console.WriteLine(course.ToString()); //if matched, display information set in Course.cs 
                    }
                }
            }
        }

        static void DisplayCourseStudents()
        {
            //input of specific course code
            Console.Write("Enter the Course Code: ");
            int courseCode = ReadInt();

            //search for all student IDs enrolled for specific course
            List<string> studentIDs = new List<string>(); //created list for ID collection
            foreach (var enrolment in enrolments)
            {
                if (enrolment.CourseCode == courseCode) //checks if inputted courseCode entered is in the enrolment list
                {
                    studentIDs.Add((enrolment.studentID).ToString()); //if so, we add its student ID
                }
            }

            //display the student info for each student ID collected
            foreach (var studentID in studentIDs)
            {
                foreach (var student in students)
                {
                    if (student.StudentID == int.Parse(studentID)) //field is a int so it needs parsing
                    {
                        Console.WriteLine(student.ToString()); //display all info from override ToString() of Student.cs
                    }
                }
            }
        }

        static void DisplayFacultyCourses()
        {
            //input Faculty ID
            Console.Write("Enter Faculty ID: ");
            int facultyID = ReadInt();

            //search through all courses for specified faculty ID association
            foreach (var course in courses)
            {
                if (course.facultyID == facultyID) 
                {
                    Console.WriteLine(course.ToString()); //if matched, print out course details from Course.cs override ToString()
                }
            }
        }

        static void DisplayStudentsInProgram()
        {
            //input college program code
            Console.Write("Enter the Program Code: ");
            int programCode = ReadInt();

            //loop through students list to find those enrolled in the specified program
            foreach (var student in students)
            {
                if (student.ProgramCode == programCode)
                {
                    Console.Write(student.ToString()); //if matched, output student info accordingly
                }
            }
        }

        //validator method for needed int inputs
        static int ReadInt() //validation + parsing into one method for int data types
        {
            int num;
            while (!int.TryParse(Console.ReadLine(), out num)) //as long as it is incompatible to parse the while .ReadLine() to an int, it will keep displaying the error message
            {
                Console.WriteLine();
                Console.Write("Invalid input. \nPlease enter a valid number (no dots, dashes, or special characters): ");
            }
            return num; //returns it as a parsed int. 
        }
    }
}
