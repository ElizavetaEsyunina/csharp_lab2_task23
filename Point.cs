using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_task_2_3_
{
    internal class Point
    {
        //задание 2

        private double x;
        private double y;

        public double X
        {
            get { return x; }
            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        //конструктор по умолчанию
        public Point()
        {
            x = 0;
            y = 0;
        }

        //конструктор с параметрами
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        //конструктор копирования
        public Point(Point point)
        {
            x = point.x;
            y = point.y;
        }

        public override string ToString()
        {
            return $"X: {x} | Y: {y}";
        }

        //метод (расстояние от точки до начала координат)
        public double DistanceToOrigin()
        {
            double result = Math.Sqrt(x * x + y * y);
            return Math.Round(result, 3);
        }

        //задание 3 (перегрузка операций)
        //унарные операции
        //уменьшение координат x и y на 1
        public static Point operator --(Point p)
        {
            p.x--;
            p.y--;
            return p;
        }

        //поменять координаты x и y местами
        public static Point operator -(Point p)
        {
            return new Point(p.y, p.x);
        }

        //операции приведения типа
        //int (неявная) – результатом является целая часть координаты х;
        public static implicit operator int(Point p)
        {
            return (int)p.x;
        }

        //double(явная) – результатом является координата y
        public static explicit operator double(Point p)
        {
            return p.y;
        }

        //бинарные операции
        //- Point p, целое число (левосторонняя операция, уменьшается координата х);
        public static Point operator -(Point p, int value)
        {
            return new Point(Math.Round(p.x - value, 2), p.y);
        }

        //- целое число, Point p (правосторонняя операция, уменьшается координата y);
        public static Point operator -(int value, Point p)
        {
            return new Point(p.x, Math.Round(p.y - value, 2));
        }

        //-  Point p – вычисляется расстояние до точки p, результатом должно быть вещественное число.
        public static double operator -(Point p1, Point p2)
        {
            double distance_x = Math.Max(p1.x, p2.x) - Math.Min(p1.x, p2.x);
            double distance_y = Math.Max(p1.y, p2.y) - Math.Min(p1.y, p2.y);
            double result = Math.Sqrt(distance_x * distance_x + distance_y * distance_y);
            return Math.Round(result, 3);
        }
    }
}