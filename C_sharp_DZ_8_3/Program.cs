using System;
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





    class Program
    {


        static void Main(string[] args)
        {


        }
    }
}
