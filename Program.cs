﻿using System;
//Перевірити істинність вислову: "Дані числа x, у є координатами точки, що лежить у другому квадранті ".
//Перевірити істинність вислову: "Дані числа x, у є координатами точки, що лежить у першому або третьому квадранті". 

namespace Ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int x,y;

            Console.WriteLine("Введите число x");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);
            Console.WriteLine("Введите число y");
            str = Console.ReadLine();
            y = Convert.ToInt32(str);
            if (x<0 && y>0)
            {
                Console.WriteLine("Лежить у першому квадрати");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Лежить у другому квадрати");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Лежить у третьому квадрати");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Лежить у четвертому квадрати");
            }
            else { Console.WriteLine("На початку коордынат"); }
        }
    }
}
