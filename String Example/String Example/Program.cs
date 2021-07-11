using System;

namespace String_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "I am Learning C#";
            string s1 = "I am DotNet Developer";
            string s2 = "I am DotNet Developer";
            string s3 = new string("I am DotNet Developer");

            Console.WriteLine(s.Length);//length
            Console.WriteLine(s.ToUpper());//converting into uppercase
            Console.WriteLine(s.ToLower());//converting into lowercase
            Console.WriteLine(s.Substring(0, 7));//extracts the string
            Console.WriteLine(s.StartsWith("I"));//returns true or false
            Console.WriteLine(s.EndsWith("#"));
            Console.WriteLine(s.Trim());
            Console.WriteLine(s.Equals(s1));
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1 == s2);
            Console.WriteLine(s2 == s3);
            Console.WriteLine(s1.GetHashCode());//object Reference Number
            Console.WriteLine(s2.GetHashCode());
            Console.WriteLine(s3.Replace("I", "Are"));


           

        }
    }
}
