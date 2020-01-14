using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    interface ShapeInterface
    {
        void drawshape(Graphics g, int k, int l, params string[] getResult);
    }
}
