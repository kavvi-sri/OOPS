using Polymorpishm.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpishm
{
    class Program
    {
        static void Main(string[] args)
        {
            Addition ad = new Addition();
            ad.add(10, 20);
            ad.add(10, 20, 30);
            ad.add(10, 28.0f);
            Console.WriteLine(ad);
            Console.ReadLine();

            Child child = new Child();
            child.add();
        }
    }
}
