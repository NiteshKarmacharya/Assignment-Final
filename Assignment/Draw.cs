using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Draw : ShapeInterface
    {
        Pen p = new Pen(Color.Red, 2);
        public int point1,point2;
        public void drawshape(Graphics g, int pos1, int pos2, params string[] getResult)
        {
            point1 = Convert.ToInt32(getResult[1]);
            point2 = Convert.ToInt32(getResult[2]);
            g.DrawLine(p, pos1, pos2, point1, point2);
        }
    }
}
