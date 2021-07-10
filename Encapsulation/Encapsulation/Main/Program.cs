using Encapsulation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        public static void displayStudent()
        {

            Student std = new Student();
            std.Id = 101;
            std.Name = "kavya";
            std.Email = "sri@gmail.com";
            std.Mobilenumber = 9876654321;
            std.Course = "cse";
            std.Pincode = 505324;
            Console.WriteLine ("\nId:" + std.Id + "\nName:" + std.Name + "\nEmail:" + std.Email + "\nMobilenumber:" + std.Mobilenumber + "\nCourse:" + std.Course +
                "\nPincode:" + std.Pincode);
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            Program.displayStudent();

        }

       
    }
}
