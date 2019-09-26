using System;

namespace project2
{
    class Program
    {
        public static void Main()
        {
            double Perimetr_triangle,a1,a2,a,b,z,x,v;
            double x1, x2, x3, y1, y2, y3;

            #region Площадь равностороннего треугольника
            Console.WriteLine("Введите периметр треугольника");
            Perimetr_triangle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь треугольника с периметром " + Perimetr_triangle + " = " + square_triangle(Perimetr_triangle));
            Console.WriteLine();
            #endregion


            #region ср. арифмет. кубов
            Console.WriteLine("Введите 2 числа");
            a1 = Convert.ToDouble(Console.ReadLine());
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Среднее арифметическо кубов чисел = "+average(a1, a2));
            Console.WriteLine();
            #endregion


            #region Нахождение гипотенузы 
            Console.WriteLine("Введите стороны треугольника а и b ");
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("гипотенуза треугольника равна " + hypo(a, b));
            Console.WriteLine();
            #endregion


            #region Периметр прямоугольника
            Console.WriteLine("Введите стороны прямоугольного треугольника z x");
            z = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("периметр прямоугольного треугольника равен " + perim(z, x));
            Console.WriteLine();
            #endregion


            #region Ребро куба 
            Console.Write("Введите объём куба v = ");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ребро куба = " + rebro(v));
            Console.WriteLine();
            #endregion


            #region Периметр треугольника 
            Console.WriteLine("Введине координаты каждой вершины треугольника");
                   x1 = Convert.ToDouble(Console.ReadLine()); y1 = Convert.ToDouble(Console.ReadLine());
                   x2 = Convert.ToDouble(Console.ReadLine()); y2 = Convert.ToDouble(Console.ReadLine());
                   x3 = Convert.ToDouble(Console.ReadLine()); y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Периметр треугольника равен" + perim_traiangle(x1, y1, x2, y2, x3, y3));
            Console.WriteLine();
            #endregion


            #region Площадь круга
            Console.Write("Введите дли окружности  l = ");
            Double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Площадь окружности длинной l = " + l + " равна " + perimokr(l));
            Console.WriteLine();
            #endregion


            #region  Площадь трапеции
            Console.WriteLine("Введите основани m и n и угол при большем оснавание A");
            double m = Convert.ToDouble(Console.ReadLine()), n = Convert.ToDouble(Console.ReadLine()), A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Площадь трапеции = " + pltrap(m, n, A));
            Console.WriteLine();
            #endregion


            #region Радиус вписанной окружности 
            Console.WriteLine("Введите сторону треугольника");
            Double storona = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Радиус окружности вписанной в треугольник = " + radius(storona));
            Console.WriteLine();
            #endregion

        }
        #region Решение 
        public static double square_triangle(double p)
        {
            return Math.Pow(p / 3, 2.0) * Math.Sqrt(3.0) / 4;
        }
        public static double average(double a1, double a2)
        {
            return (Math.Pow(a1, 3.0) + Math.Pow(a2, 3.0)) / 2;
        }
        public static double hypo(double a, double b)
        {
            return Math.Sqrt(a * a + b * b);
        }
        public static double rebro(double v)
        {
            return Math.Pow (v, 1 / 3f);
        }
        public static double perim(double z, double x)
        {
            return (Math.Sqrt(z * z + x * x) + z + x);
        }
        public static double perim_traiangle(Double x1, Double y1, Double x2, Double y2, Double x3, Double y3)

        {
            double lenght1 = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double lenght2 = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double lenght3 = Math.Sqrt((x3 - x1) * (x3 - x1) + (y3 - y1) * (y3 - y1));
            double c = lenght1 + lenght2 + lenght3;
            return c;
        }
        public static double perimokr(double l)
        {
            Double s = (l * l / 4 / 3.14);
            return s;
        }
        public static double pltrap(double m, double n, double A)
        {
            double h = Math.Abs(m - n) / Math.Tan(A);
            return h * (m + n) / 2;
        }
        public static double radius(double storona)
        {
            double lenght = storona / 2 / Math.Sqrt(3.0);
            return lenght;
        }
        #endregion
    }
}
