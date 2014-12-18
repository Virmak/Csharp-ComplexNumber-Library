using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexNumber;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(3,4);
            Complex c2 = new Complex(1, 5);
            Console.WriteLine(Complex.Arg(c));
            Console.Read();

        }
    }
}
