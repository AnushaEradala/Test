using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu = new Student();


        
            string doYouWantToContinue;
            do
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Get Student Details");
                Console.WriteLine("5. Get Student Count");
                Console.Write("Please Select your operation:");
                int option = Convert.ToInt32(Console.ReadLine());
               

                switch (option)
                {
                    case 1:
                        Student.addStudent();
                        break;
                    case 2:
                        Student.updateStudent();
                        break;
                    case 3:
                        Student.deleteStudent();
                        break;
                    case 4:
                        Student.getStudentDetails();
                        break;
                    case 5:
                        Student.GetCount();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
                Console.Write("Do you wish to continue (y/n)?");
                doYouWantToContinue = Console.ReadLine();
            } while (doYouWantToContinue.ToLower() == "y");
        }
        public class Student
        {
            public static int count = 0;
            public static int dob;
            public static string email;
            public static string firstName;
            public static string lastName;
            public static int studentId = 1000;

            public Student()
            {
                
            }

            public static void addStudent()
            {
                Console.Write("Please enter Student's First name: ");
                firstName = Console.ReadLine();
                Console.Write("Please enter Student's Last name: ");
                lastName = Console.ReadLine();
                Console.Write("Please enter Student's Email id: ");
                email = Console.ReadLine();
                Console.Write("Please enter Student's DOB: ");
                dob = Convert.ToInt32(Console.ReadLine());

                count++;
                studentId = studentId + count;
                Console.WriteLine("The student id is: {0}", studentId);
                string sf = Student.firstName.Substring(0, 1);
                string sl = Student.lastName.Substring(0, 1);
                string ss = sf + sl;
                object sid = string.Concat(ss, studentId.ToString());

                String[] s = new string[] { "First Name:",firstName,"Last Name:",lastName, "Email:",email};
                if (File.Exists(@"C:\Users\Anu\Desktop\Demo\sid.txt"))
                {
                    File.WriteAllLines(@"C:\Users\Anu\Desktop\Demo\" + sid +".txt", s);
                    Console.WriteLine("Student details added successfully");
                  
                }
                else
                {
                    File.Create(@"C:\Users\Anu\Desktop\Demo\sid.txt").Close();
                    Console.WriteLine("File created successfully");
                    File.WriteAllLines(@"C:\Users\Anu\Desktop\Demo\"+sid+".txt", s);
                    Console.WriteLine("Student details added successfully");

                   
                }

            }

            public static void updateStudent()
            {
                Console.WriteLine("Please enter the student id to be updated: ");
                object s1 = Console.ReadLine();
                File.OpenWrite(@"C:\Users\Anu\Desktop\Demo\s1.txt");

                Console.Write("Please enter Student's First name: ");
                firstName = Console.ReadLine();
                Console.Write("Please enter Student's Last name: ");
                lastName = Console.ReadLine();
                Console.Write("Please enter Student's Email id: ");
                email = Console.ReadLine();
                Console.Write("Please enter Student's DOB: ");
                dob = Convert.ToInt32(Console.ReadLine());
                String[] s = new string[] { "First Name:", firstName, "Last Name:", lastName, "Email:", email };
                File.WriteAllLines(@"C:\Users\Anu\Desktop\Demo\" + s1 + ".txt", s);
                Console.WriteLine("Student details updated successfully");


            }

            public static void deleteStudent()
            {
                Console.WriteLine("Please enter the student id to be deleted: ");
                object s2 = Console.ReadLine();
                File.Delete(@"C:\Users\Anu\Desktop\Demo\"+s2+".txt");
                Console.WriteLine("Student details deleted successfully");
            }

            public static void getStudentDetails()
            {
                Console.WriteLine("Please enter the student id to display the details: ");
                object s3 = Console.ReadLine();
                string[] readText = File.ReadAllLines(@"C:\Users\Anu\Desktop\Demo\"+s3+".txt");
                foreach (string s in readText)
                {
                    Console.WriteLine(s);
                }
            }

            public static void GetCount()
            {
                
                Console.WriteLine("The total number of students are: {0}",count);
            }
        }
    }
}
