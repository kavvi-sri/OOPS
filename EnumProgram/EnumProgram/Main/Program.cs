using EnumProgram.Model;
using System;

namespace EnumProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum Creation
            Colors colors = Colors.Black;
            Console.WriteLine("colors");

            Roles roles = Roles.Admin;
            Console.WriteLine(roles);
            // we can't convert obj to string
            // we can convert the string to string
            // we can convert the object to object
            if (roles.ToString()=="User")
            // roles is a object it can convert to string
            {
                Console.WriteLine("welcome to Userpage");

            }
            else
            {
                Console.WriteLine("You are navigated to Home");
            }

        }
    }
}
