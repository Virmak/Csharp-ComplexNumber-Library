using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    public static class Resolution
    {
        public static Complex[] deltaSqrt(Complex delta)
        {
            Complex[] complexArray = new Complex[2];
            double x = 0;
            x = Math.Sqrt((delta.Real() + Math.Sqrt(Complex.Abs(delta))) / 2);
            if (x != 0)
            {
                complexArray[0] = new Complex(x, delta.Imaginaire() / (2 * x));
            }
            else
            {
                complexArray[0] = new Complex(x, Math.Sqrt(-delta.Real()));
            }
            
            x *= -1;
            complexArray[1] = new Complex(x, delta.Imaginaire() / (2 * x));
            return complexArray;
        }
        public static Complex getDelta(Complex a,Complex b, Complex c)
        {
            return (b * b) - (4 * a * c);
        }
        public static Complex[] getSollutionArray(Complex a,Complex b, Complex c)
        {
            Complex[] sollutionArray = new Complex[2];
            sollutionArray[0] = ((-b - deltaSqrt(getDelta(a, b, c))[0]) / (2 * a));
            sollutionArray[1] = ((-b + deltaSqrt(getDelta(a, b, c))[0]) / (2 * a));
            return sollutionArray;
        }
    }
}
