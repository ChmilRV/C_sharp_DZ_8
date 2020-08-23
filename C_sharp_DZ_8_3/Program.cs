using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*3. Создать обобщенный класс прямой на плоскости.
В классе предусмотреть 2 поля типа обобщенной точки — точки, через которые проходит прямая.
Реализовать в классе:
■ конструктор, который принимает 2 точки;
■ конструктор, которые принимает 4 координаты (x и у координаты для первой и второй точки);
■ метод ToString().*/
namespace C_sharp_DZ_8_3
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
    public class LineOnPlane<T>
    {
        public T X1 { get; set; }
        public T Y1 { get; set; }
        public T X2 { get; set; }
        public T Y2 { get; set; }
        public LineOnPlane(Point2D<T> p1, Point2D<T> p2)
        {
            X1 = p1.X;
            Y1 = p1.Y;
            X2 = p2.X;
            Y2 = p2.Y;
        }
        public LineOnPlane(T x1, T y1, T x2, T y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }
        public override string ToString()
        {
            return $"X1={X1}, Y1={Y1}\tX2={X2}, Y2={Y2}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Title = "C_sharp_DZ_8_3";
            Point2D<int> point1= new Point2D<int>(1, 2);
            Point2D<int> point2 = new Point2D<int>(3, 4);
            LineOnPlane<int> line1 = new LineOnPlane<int>(point1, point2);
            LineOnPlane<int> line2 = new LineOnPlane<int>(5,6,7,8);
            WriteLine(point1);
            WriteLine(point2);
            WriteLine(line1);
            WriteLine(line2);
            ReadKey();
        }
    }
}
