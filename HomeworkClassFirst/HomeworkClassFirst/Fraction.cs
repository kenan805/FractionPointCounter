using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassFirst
{
    class Fraction
    {

        public int Numerator { get; set; }
        private int denominator;

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if (value == 0) Console.WriteLine("Exception !!!");
                else denominator = value;
            }
        }

        public Fraction()
        {

        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction Add(in Fraction other)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * other.Denominator + other.Numerator * Denominator;
            result.Denominator = Denominator * other.Denominator;
            return result;
        }
        public Fraction Minus(in Fraction other)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * other.Denominator - other.Numerator * Denominator;
            result.Denominator = Denominator * other.Denominator;
            return result;
        }
        public Fraction Multiply(in Fraction other)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * other.Numerator;
            result.Denominator = Denominator * other.Denominator;
            return result;
        }
        public Fraction Divide(in Fraction other)
        {
            Fraction result = new Fraction();
            result.Numerator = Numerator * other.Denominator;
            result.Denominator = Denominator * other.Numerator;
            return result;
        }




        public void Simplify(in Fraction other)
        {
            for (int i = 2; i < Denominator; i++)
            {
                if (Denominator % i == 0 && Numerator % i == 0)
                {
                    Denominator /= i;
                    Numerator /= i;
                    i = 1;
                }
            }
        }
        public void PrintFranction()
        {
            Console.WriteLine();
            if (Denominator == 1) Console.WriteLine(Numerator);
            else if (Numerator % Denominator == 0) Console.WriteLine(Numerator / Denominator);
            else Console.WriteLine($"{Numerator}\n{(char)22}{(char)22}\n{Denominator}");
        }
    }
}
