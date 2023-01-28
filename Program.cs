using System;
//Перевірити істинність вислову: "Точка з координатами (x, у) лежить всередині прямокутника, ліва верхня вершина якого має координати (x1, y1), права нижня — (x2, y2),
//а сторони паралельні координатним осям".

namespace Ex_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int x1, y1,x2,y2,x,y;

            Console.WriteLine("Write X");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);
            Console.WriteLine("Write Y");
            str = Console.ReadLine();
            y = Convert.ToInt32(str);

            do
            {
                Console.WriteLine("Write X1");
                str = Console.ReadLine();
                x1 = Convert.ToInt32(str);
            } while (x1 > 0);
            do
            {
                Console.WriteLine("Write Y1");
                str = Console.ReadLine();
                y1 = Convert.ToInt32(str);
            } while (y1 < 0);
            Console.WriteLine("Левая верхняя точка имеет координаты"+x1+' '+y1);

            do
            {
                Console.WriteLine("Write X2");
                str = Console.ReadLine();
                x2 = Convert.ToInt32(str);
            } while (x2 < 0);
            do
            {
                Console.WriteLine("Write Y2");
                str = Console.ReadLine();
                y2 = Convert.ToInt32(str);
            } while (y2 > 0);
            Console.WriteLine("Правая нижняя точка имеет координаты" + x2 + ' ' + y2);

            if (x>x1 && x<x2 && y <y1 && y>y2)
            {
                Console.WriteLine("Точка лежит в квадрате");
            }
            else
            {
                Console.WriteLine("Точка не лежит в квадрате");
            }
        }
    }
}
