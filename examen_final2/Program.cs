using System;

namespace examen_final2
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 5);
            Point p2 = new Point(4, 2);
            Point p3 = new Point(3, 4);
            Triangle t1 = new Triangle(p1, p2, p3);
        }
    }
}
