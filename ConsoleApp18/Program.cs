using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите координату x1: ");
                double x1 = double.Parse(Console.ReadLine());

                Console.Write("Введите координату y1: ");
                double y1 = double.Parse(Console.ReadLine());

                Console.Write("Введите координату x2: ");
                double x2 = double.Parse(Console.ReadLine());

                Console.Write("Введите координату y2: ");
                double y2 = double.Parse(Console.ReadLine());

                double k = (y1 - y2) / (x1 - x2);

                double b = y2 - k * x2;

                Console.WriteLine($"Уравнение прямой: y = {k}x + {b}");
            }
            catch
            {
                Console.WriteLine("Введен неверный  тип данных");
            }
        }
    }
}
