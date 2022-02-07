using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_final2
{
    public abstract class Shape
    {
        public abstract int Area();

        public abstract void Translate(int move);

        public abstract void Rotate(int angle);
    }
}
