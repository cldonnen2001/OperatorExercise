using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           int x = 2;
           int y = 1;
           Console.WriteLine(x + y); // result addition 3
           {
               int c = 40;
               int d = 20;
                Console.WriteLine(c - d); // result subtraction 20
           }
           {
               int g = 5;
                Console.WriteLine(x + g); //result multiplication 7
           }
           {
               int i = 50;
               int j = 5;
                Console.WriteLine(i / j);// result division 10
           }
           {
               int l = 17;
               int m = 4;
               int quotient = l / m;
               int remiander = l % m;

               if (l == 17 && m == 4)
                    Console.WriteLine("17/4 is 4 remainder 1");

            }
            {
                int a = 17;
                int b = 4;

                a += b;
                a -= b;
                a *= b;
                a /= b;

                int quotient = a / b;
                int remainder = a % b;
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");
            }
            double areaofcircle()
            {
                var radius = double.Parse(Console.ReadLine());
                double pie = 3.14;
                double area = pie * (radius * radius);
                return area;
            }
            {
                double circlearea = areaofcircle();
                Console.WriteLine(circlearea);
            }
         
    }
}
