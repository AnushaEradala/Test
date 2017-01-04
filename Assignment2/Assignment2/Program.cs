using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("abc","xyz", 121291, "abc@gmail.com");
            Student s2 = new Student("asdf","ghjk", 1191, "bgb@gmail.com");
            Student s3 = new Student();
            s3.dob=1290;
            s3.firstName="sdf";
            s3.lastName="fgh";
            s3.email="sdf@dfgdf";

            int i = Student.GetCount();
            
            

            Console.WriteLine("Student1 details are: \n Firstname: {0}  \n Lastname: {1} \n email: {2} \n DOB: {3}", s1.firstName, s1.lastName, s1.email, s1.dob);
            Console.WriteLine("Student ID: {0}", Student.count + 1000);
            Console.WriteLine("Student2 details are: \n Firstname: {0}  \n Lastname: {1} \n email: {2} \n DOB: {3}", s2.firstName, s2.lastName, s2.email, s2.dob);
            Console.WriteLine("Student ID: {0}", Student.count + 1000);
            Console.WriteLine("Student3 details are: \n Firstname: {0}  \n Lastname: {1} \n email: {2} \n DOB: {3}", s3.firstName, s3.lastName, s3.email, s3.dob);
            Console.WriteLine("Student ID: {0}", Student.count + 1000);
            Console.WriteLine("The total count of students is: {0}" , i);
            Console.ReadLine();


        }

        public class Student
        {
            public static int count=0;
            public int dob;
            public string email;
            public string firstName;
            public string lastName;
            public int studentId=1000;

            public Student()
            {
                count++;
            }

            public Student(string firstName, string lastName, int dob, string email):this()
            {
                this.studentId = studentId + count;
                this.dob=dob;
                this.email=email;
                this.firstName = firstName;
                this.lastName = lastName;

            }

            public static int GetCount()
            {
                
                return count;
                
                

            }


        }
    }
}
