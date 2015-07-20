using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2._1
{
    class Point
    {
        int _X, _Y; //координаты точки
        double _Vector;//расстояние от начала точки и до начала координат
        public Point()
        {
            _X = 0;
            _Y = 0;
        }
        public bool IsXZero()
        {
            return (_X == 0);
        }
        public bool IsYZero()
        {
            return (_Y == 0);
        }
        public void MovePoint(int n, int m)
        {
            _X = _X + n;
            _Y = _Y + m; //движение точек по коррдинатом
        }
        public int X
        {
            set { _X = value; }
            get { return _X; }//Свойства кординат X
        }
        public int Y
        {
            set { _Y = value; }
            get { return _Y; }//Свойства кординат Y
        }
        public double Vector
        {
            get
            {
                _Vector = Math.Sqrt(_X + _X + _Y + _Y);
                return _Vector;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point P = new Point();
            int n, m;
            Console.WriteLine("Введите кординаты X");
            P.X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кординаты Y");
            P.Y = Convert.ToInt32(Console.ReadLine());
            if (P.IsXZero()) Console.WriteLine("Точка лежит на оси X");
            if (P.IsXZero()) Console.WriteLine("Точка лежит на оси Y");
            Console.WriteLine("Расстояние до начала координат равно " + P.Vector);
            Console.WriteLine("Для продолжение напжмите любую клавишу");
            Console.ReadKey();
            Console.WriteLine("Введите перемещение на оси X");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите перемещение на оси Y");
            m = Convert.ToInt32(Console.ReadLine());
            P.MovePoint(n, m);
            Console.WriteLine("Координаты после перемещения");
            Console.WriteLine("X=" + P.X + "Y=" + P.Y);
            if (P.IsXZero()) Console.WriteLine("Точка лежит на оси X");
            if (P.IsYZero()) Console.WriteLine("Точка лежит на оси Y");
            Console.WriteLine("расстояние после перемещение равно " + P.Vector);
            Console.ReadKey();
        }
    }
}