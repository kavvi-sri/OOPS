using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorpishm.Model
{
    class Addition
    {
        public int add(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);
            return num1 + num2;
        }

        public int add(int num1, int num2,int num3)
        {
            Console.WriteLine(num1 + num2 + num3);
            return num1 + num2 + num3;
        }

        public int add(int num1, float num2)
        {
            Console.WriteLine((int)((float)num1 + num2));
            return (int)((float)num1 + num2);
        }
    }
}
