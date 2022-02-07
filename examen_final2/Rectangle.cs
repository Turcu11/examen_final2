using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_final2
{
    class Rectangle : Shape
    {
        public Rectangle(Point topLeft, int side1, int side2)
        {
            TopLeft = topLeft;
            TopRight.X = TopLeft.X;
            TopRight.Y = TopLeft.Y + side1;
            BottomRight.X = TopRight.X + side1;
            BottomRight.Y = TopRight.Y;
            BottomLeft.X = BottomRight.X;
            BottomLeft.Y = topLeft.Y;
        }

        Point TopLeft;
        Point TopRight;
        Point BottomRight;
        Point BottomLeft;
        int side1 { get; set; }
        int side2 { get; set; }

        public override int Area()
        {
            return side1 * side2;
        }

        public override void Rotate(int angle)
        {
            TopLeft.Rotate(angle);
            TopRight.Rotate(angle);
            BottomRight.Rotate(angle);
            BottomLeft.Rotate(angle);
        }

        public override void Translate(int move)
        {
            TopLeft.Translate(move, move);
            TopRight.Translate(move, move);
            BottomRight.Translate(move, move);
            BottomLeft.Translate(move, move);
        }
    }
}
