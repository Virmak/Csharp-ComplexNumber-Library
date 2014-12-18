using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComplexNumber;

namespace ttt
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex a = new Complex(3,0);
            Complex b = new Complex(-2,0);
            Complex c = new Complex(1,0);
            Console.WriteLine(ComplexNumber.Resolution.getSollutionArray(a,b,c)[1]);
            Console.Read();
        }
    }
}
