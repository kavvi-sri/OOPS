using System;
using System.Collections.Generic;

namespace List_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> age = new List<int>();
            age.Add(10);
            age.Add(20);
            age.Add(30);
            age.Add(40);
            age.Add(50);

            foreach(int i in age)
            {
                Console.WriteLine(i);
            }

            List<string> colors = new List<string>();
            colors.Add("Pink");
            colors.Add("Black");
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Red");

            // colors.Remove("Pink");

            //To Remove Duplicates
            HashSet<string> hashcolors = new HashSet<string>(colors);
            

            foreach (string color in hashcolors) 
            {
                Console.WriteLine(color);
            }


           /* string s = "kavya";

            int sLength = s.Length;

            Console.WriteLine(s+ +sLength);

            Console.WriteLine(s.ToUpper());*/




        }
    }
}
