using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны первого треугольника");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стороны второго треугольника");
            int a1 = Convert.ToInt32(Console.ReadLine());
            int b1 = Convert.ToInt32(Console.ReadLine());
            int c1 = Convert.ToInt32(Console.ReadLine());
            double Sruard1 = Squard(a, b, c);
            double Sruard2 = Squard(a1, b1, c1);
            if (Sruard1 < Sruard2)
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника");
            }
            else
            {
                Console.WriteLine("Площадь первого треугольника больше площади второго треугольника");
            }
            Console.ReadKey();



        }
        //static void Squard (int a, int b, int c, double p, out double s)
        //{
        //    p = (a + b + c) / 2;
        //    s = p * (p - a) * (p - b) * (p - c);
        //}
        static double Squard(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double s = p * (p - a) * (p - b) * (p - c);
            return s;

        }

    }
}
