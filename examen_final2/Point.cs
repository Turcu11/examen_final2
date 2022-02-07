using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_final2
{
    public class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Translate(int dx, int dy)
        {
            X = X + dx;
            Y = Y + dy;
        }

        public void Rotate(int angle)
        {
            X = X * angle - Y * angle;
            Y = X * angle + Y * angle;
        }
    }
}
