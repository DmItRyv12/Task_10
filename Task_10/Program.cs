using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                try
                {
                    Console.WriteLine("Значение градусов угла (от 0 до 360): ");
                    int grad = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Значение минут угла (от 0 до 60): ");
                    int min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Значение секунд угла (от 0 до 60): ");
                    int sec = Convert.ToInt32(Console.ReadLine());

                    Corners corner = new Corners(grad, min, sec);
                    double Rad = ToRadians(corner.Gradus, corner.Minute, corner.Sec);
                    Console.WriteLine();

                    if (grad <= 360 && grad >= 0 && min <= 60 && min >= 0 && sec <= 60 && sec >= 0) // Допустимые значения.
                    {
                        Console.WriteLine("Угол задан в {0} градусов {1} минут {2} секунд \nЗначение в радианах = {3:f2}", grad, min, sec, Rad); // градусы, минуты, секунды и радианы выводимые.
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введены недопустимые значения угла!");
                    }
                    Console.ReadKey();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}", ex.Message);
                    Console.ReadLine();
                    continue;

                }

            }
        }
        static double ToRadians(double grad, double min, double sec)
        {
            double G = grad + (((min + sec) / 60)) / 60;
            double Rad = G * Math.PI / 180;
            return Rad;
        }
    }
    class Corners
    {
        private int gradus;
        private int minute;
        private int sec;
        public int Gradus
        {
            set
            {
                if (value <= 360 && value >= 0) // Допустимые значения.
                {
                    gradus = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение градусов принимается от 0 до 360!"); 
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Minute
        {
            set
            {
                if (value <= 60 && value >= 0) // Допустимые значения.
                {
                    minute = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение минут принимается от 0 до 60!"); //  В некоторых странах принята система измерения минут в 100 ед.!
                }
            }
            get
            {
                return minute;
            }
        }
        public int Sec
        {
            set
            {
                if (value <= 60 && value >= 0) // Допустимые значения.
                {
                    sec = value;
                }
                else
                {
                    Console.WriteLine("Ошибка! Значение секунд принимается от 0 до 60!"); // В некоторых странах принята система измерения секунд в 100 ед.!
                }
            }
            get
            {
                return sec;
            }
        }
        public Corners(int gradus, int minute, int sec)
        {
            Gradus = gradus;
            Minute = minute;
            Sec = sec;
        }

    }


}
