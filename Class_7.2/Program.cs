using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба: ");
            int a = Convert.ToInt32(Console.ReadLine());
            double V, S;
            GetCube(a, out V, out S);
            Console.WriteLine("Объём куба = {0:F1} м3. Площадь куба = {1:F1} м2.", V, S);
            Console.ReadKey();
        }
        static void GetCube(int a, out double V, out double S)
        {
            V = Math.Pow(a, 3);
            S = Math.Pow(a, 2) * 6;
        }
    }
}
