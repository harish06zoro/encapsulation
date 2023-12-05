using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            vehicle v = new vehicle();
            v.Regno = "57565";
            v.Wheels = 4;
            v.Litre = 10;


            Console.WriteLine(v);
        }
    }
}
