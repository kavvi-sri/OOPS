using Inheritance.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        public static void displaydata()
        {
            Rhombus rho = new Rhombus();
            rho.height = 5;
            rho.width = 5;
            rho.size = "small";
            rho.radius = 2;
            Console.WriteLine("\n heigth:" + rho.height + "\n width:" + rho.width + "\n size:" + rho.size + "\n radius" + rho.radius );
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Program.displaydata();
            
        }
    }
}
