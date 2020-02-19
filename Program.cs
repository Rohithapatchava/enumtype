using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumtype
{
    class Program
    {
        enum department
        {
            physics = 10;
            chemistry = 9;
            mathematics = 14;
            biology = 18;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("department id of mathematics is {0}",(int)department.mathematics);
            Console.ReadKey();
       }
    }
}
