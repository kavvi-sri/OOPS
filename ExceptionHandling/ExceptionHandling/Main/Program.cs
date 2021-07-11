using System;

namespace ExceptionHandling
{
    class Program
    {
        /*Exception Handling--->Distrbence occured when we run the program
                            ---> That's why we use try & catch blocks
            try--> if it may raise a exception we should put inside a try block
               --> if exception occurs that flow of control jumps into the catch block

            catch --> It is async Exception Hadler where we can perform an action
                  --> it can take the parameter of the exception type we get the details of the

            Finally ---> It is always will be excuted either the excution is raised or not
             throw
             throws*/

        public static void displayException(int num1,int num2)
        {
            try
            {
                num1 = 40;
                num2 = 20;
            }
            catch(Exception e)
            {
                Console.WriteLine("Please should not divide with zero");
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter First number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine(result);

            Program.displayException(4, 20);
            Console.WriteLine("Hello World!");
        }
    }
}
