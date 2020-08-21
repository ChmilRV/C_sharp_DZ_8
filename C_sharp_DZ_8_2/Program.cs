using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*2. Создать необобщенный класс точки в трехмерном пространстве с целочисленными координатами (Point3D),
который наследуется от generic-класса Point2D<T>, рассмотренного в уроке.
Реализовать в классе:
■ конструктор с параметрами, который принимает начальные значения для координат точки;
■ метод ToString().*/
namespace C_sharp_DZ_8_2
{
    public class Point2D<T>
    {
        
        public T X { get; set; }
        public T Y { get; set; }
        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
        public Point2D()
        {
            X = default(T);
            Y = default(T);
        }
        public override string ToString()
        {
            return $"X={X}, Y={Y}";
        }
    }
    public class Point3D : Point2D<int>
    {
        public int Z { get; set; }

        public Point3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public override string ToString()
        {
            return base.ToString() + $", Z={Z}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point2D<int> point1 = new Point2D<int>();
            Point2D<int> point2 = new Point2D<int>(1,2);
            Point3D point3 = new Point3D(1, 2, 3);
            WriteLine(point1);
            WriteLine(point2);
            WriteLine(point3);
            ReadKey();
        }
    }
}
