//*******************************************
//*                                         *
//* Complex.cs Created By Ben Amar Med 2014 *
//*                                         *
//*******************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    public class Complex
    {
        double real;
        double imaginaire;
        public Complex(double real , double imaginaire)
        {
            this.real = real;
            this.imaginaire = imaginaire;
        }
        //Operateurs Arithmétique;
        public static Complex operator +(Complex C1, Complex C2)
        {
            return new Complex(C1.real + C2.real, C1.imaginaire + C2.imaginaire);
        }
        public static Complex operator +(Complex C1, Double n)
        {
            return new Complex(n + C1.real, C1.imaginaire);
        }
        public static Complex operator +(Double n, Complex C1)
        {
            return new Complex(C1.real + n, C1.imaginaire);
        }
        public static Complex operator +(Complex C1)
        {
            return new Complex(C1.real, C1.imaginaire);
        }
        public static Complex operator -(Complex C1, Complex C2)
        {
            return new Complex(C1.real - C2.real, C1.imaginaire - C2.imaginaire);
        }
        public static Complex operator -(Complex C1, Double n)
        {
            return new Complex(C1.real - n, C1.imaginaire);
        }
        public static Complex operator -(Double n, Complex C1)
        {
            return new Complex(n - C1.real, -C1.imaginaire);
        }
        public static Complex operator -(Complex C1)
        {
            return new Complex(-C1.real, -C1.imaginaire);
        }
        public static Complex operator *(Complex C1, Complex C2)
        {
            return new Complex(C1.real*C2.real-C1.imaginaire*C2.imaginaire, C1.real*C2.imaginaire+C1.imaginaire*C2.real);
        }
        public static Complex operator *(Complex C1, Double n)
        {
            return new Complex(C1.real * n, C1.imaginaire * n);
        }
        public static Complex operator *(Double n, Complex C1)
        {
            return new Complex(C1.real * n, C1.imaginaire * n);
        }
        public static Complex operator /(Complex C1,Complex C2){
            Double r = 0;
            Double i = 0;
            if (C2.real == 0)
            {
                r = C1.imaginaire / C2.imaginaire;
                i = - C1.real / C2.imaginaire;
            }
            else if (C2.imaginaire == 0)
            {
                r = C1.real / C2.real;
                i = C1.imaginaire / C2.real;
            }
            else
            {
                r = C1.real / C2.real;
                i = C1.imaginaire / C2.imaginaire;
            }
            return new Complex(r, i);
        }
        public static Complex operator /(Complex C1, Double n)
        {
            double r = 0;
            if (C1.real == 0)
            {
                r = 0;
            }
            else
            {
                r = C1.real / n;
            }
            return new Complex(r / n, C1.imaginaire / n);
        }
        public static Complex operator /(Double n, Complex C1)
        {
            return new Complex(n / C1.real, n / C1.imaginaire);
        }
        //Operateurs Logique;
        public static bool operator ==(Complex C1, Complex C2)
        {
            return (C1.real == C2.real && C1.imaginaire == C2.imaginaire);
        }
        public static bool operator ==(Complex C1, Double n)
        {
            return (C1.imaginaire == 0 && C1.real == n);
        }
        public static bool operator ==(Double n, Complex C1)
        {
            return (C1.imaginaire == 0 && C1.real == n);
        }
        public static bool operator !=(Complex C1, Complex C2)
        {
            return (C1.real != C2.real || C1.imaginaire != C2.imaginaire);
        }
        public static bool operator !=(Complex C1, Double n)
        {
            return (C1.imaginaire != 0 || n != C1.real);
        }
        public static bool operator !=(Double n, Complex C1)
        {
            return  (C1.imaginaire != 0 || n != C1.real);
        }
        //Fonctions Mathématiques
        public static double Abs(Complex C1)
        {
            return (C1.real * C1.real + C1.imaginaire * C1.imaginaire);
        }
        public static double Arg(Complex C1)
        {
            return (Math.Atan(C1.imaginaire/C1.real));
        }
        public static Double Imaginaire(Complex c)
        {
            return c.imaginaire;
        }
        public static Double Real(Complex c)
        {
            return c.real;
        }
        public static Complex Conjug(Complex c){
            return new Complex(c.real,-c.imaginaire);
        }
        public Complex Conjug()
        {
            return new Complex(this.real,-this.imaginaire);
        }
        public Double Imaginaire()
        {
            return this.imaginaire;
        }
        public Double Real()
        {
            return this.real;
        }
        //Resolution

        public override string ToString()
        {
            string img ="";
            if (this.imaginaire > 0)
            {
                img += "+";
                if (this.imaginaire > 1 || (this.imaginaire <1 && this.imaginaire >0))
                {
                    img = img.Insert(1, imaginaire.ToString()+"i");
                }
                else
                {
                    img += " i";
                } 
            }
            if (this.imaginaire < 0)
            {
                if (this.imaginaire < -1 || this.imaginaire < 0)
                {
                    img = imaginaire.ToString() + " i";
                }
                else
                {
                    img = " -i";
                }
            }
            return (System.String.Format("{0} {1}",real,img));
        }
    }
}
