using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Circle: ShapeInterface
    {
        Pen p = new Pen(Color.Red, 2);
        public int radius;
        public void drawshape(Graphics g, int pos1, int pos2, params string[] getResult)
        {
            if(getResult[1] == "radius")
            {
                radius = 50;

            }
            else
            {
                radius = Convert.ToInt32(getResult[1]);
            }
            g.DrawEllipse(p, pos1, pos2, 2 * radius, 2 * radius);
        }
    }
}
