using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Red", "Orange", "Black" };

            int[] values = { 10, 20, 30, 40, 50 };
            
            Console.WriteLine(arr.Length);
            Console.WriteLine(arr[1]);

            foreach(string s in arr) // to print total array.
             //string => datatype ,s=> variable,in => keyword,arr => array of string.
            {
                Console.WriteLine(s);
            }

            foreach(int i in values)
            {
                //Console.WriteLine(i);
                Console.WriteLine(i + 10);
            }


            //MATH PROPERTIES
           /* Console.WriteLine(Math.Sqrt(6));
            Console.WriteLine(Math.Pow(2, 6));
            Console.WriteLine(Math.Max(10, 20));
            Console.WriteLine(Math.Min(4, 8));
            Console.WriteLine(Math.Round(20.45342));*/



        }
    }
}
