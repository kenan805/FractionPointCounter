using System;

namespace HomeworkClassFirst
{

    class Program
    {
        static void PointHomework()
        {
            Point point = new Point()
            {
                X = 5,
                Y = 10
            };
            point.ShowData();
        }
        static void CounterHomework()
        {
            Counter counter = new Counter
            {
                Min = 2,
                Max = 10
            };

            for (int i = 0; i < 12; i++)
            {
                counter.Increment();
                Console.WriteLine($"{counter.GetCurrentData()}");
            }
        }
        static void FractionHomework()
        {
            Fraction f1 = new(3,6);
            Fraction f2 = new(5, 8);
            //Add
            Fraction result = f1.Add(f2);
            result.Simplify(result); //Ixtisar
            result.PrintFranction();
            //Minus
            result = f1.Minus(f2);
            result.Simplify(result); 
            result.PrintFranction();
            //Multiply
            result = f1.Multiply(f2);
            result.Simplify(result);
            result.PrintFranction();
            //Devide
            result = f1.Divide(f2);
            result.Simplify(result);
            result.PrintFranction();



        }

        static void Main(string[] args)
        {
            //PointHomework();
            //CounterHomework();
            FractionHomework();
         


        }
    }
}
