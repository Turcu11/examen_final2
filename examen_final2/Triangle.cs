using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_final2
{
    class Triangle : Shape
    {
        public Triangle(Point a, Point b, Point c)
        {
            P1 = a;
            P2 = b;
            P3 = c;
        }

        Point P1 { get; set; }
        Point P2 { get; set; }
        Point P3 { get; set; }

        public override int Area()
        {
            //AREA = 1 / 2 * (xA * yB + xB * yC + xC * yA - xC * yB - xB * yA - xA * yC)
            return 1 / 2 * P1.X * P2.Y + P2.X * P3.Y + P3.X * P1.Y - P3.X * P2.Y - P2.X * P1.Y - P1.X * P2.Y;
        }

        public override void Translate(int move)
        {
            P1.Translate(move, move);
            P2.Translate(move, move);
            P3.Translate(move, move);
        }
        public override void Rotate(int angle)
        {
            P1.Rotate(angle);
            P2.Rotate(angle);
            P3.Rotate(angle);
        }
    }
}
