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
            // 1 //

            //int zero = 0;
            //double sum = 0;
            //double mult = 1;
            //Random rand = new Random();
            //double[,] arr = new double[10, 10];
            //for (int i = 0; i<10; i++)
            //{
            //    for(int j = 0; j<10; j++)
            //    {
            //        arr[i, j] = rand.Next(-10, 10);
            //    }
            //}
            //foreach(double num in arr)
            //{
            //    if(sum > 0)
            //    {
            //        sum += num;
            //    } else if (num < 0)
            //    {
            //        mult *= num;
            //    } else if (num == 0)
            //    {
            //        zero++;
            //    }
            //}
            //Console.WriteLine($" \n Sum: {sum}\n numbers: {mult}\n zeroes: {zero}");

            // 2 //

            //Console.WriteLine("Введите число");
            //int x = Int32.Parse(Console.ReadLine()); int count = 0;
            //while (x != 0)
            //{
            //    count++; x /= 10;
            //}
            //Console.WriteLine("Длина числа: " + count  " ");

            // 4 //

            //Console.Write("Введите число a: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Введите число b: ");
            //int b = int.Parse(Console.ReadLine());
            //if (a != 0 && b != 0) 
            //{
            //    if (a % b == 0 || b % a == 0)
            //    {
            //        Console.WriteLine(" одно из чисел является делителем другого.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Нет, ни одно из чисел не является делителем другого.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(" Невозможно определить делители.");
            //}

            // 5 //

            //Console.Write("Введите значение поворота часовой стрелки (градусы): ");
            //double deg = double.Parse(Console.ReadLine());
            //double hours = deg / 30;
            //double minutes = (hours - Math.Floor(hours)) * 60;
            //int roundedHours = (int)Math.Floor(hours);
            //int roundedMinutes = (int)Math.Round(minutes, MidpointRounding.ToEven);
            //Console.WriteLine($"С начала суток прошло {roundedHours} часов и {roundedMinutes} минут");
        }
    }
}
