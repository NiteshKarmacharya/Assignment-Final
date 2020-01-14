using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Polygon : ShapeInterface
    {
        Pen p = new Pen(Color.Red, 2);
        int side1, side2, side3;
        public void drawshape(Graphics g, int x = 0, int y = 0, params string[] getResult)
        {
            side1 = Convert.ToInt32(getResult[1]);
            side2 = Convert.ToInt32(getResult[2]);
            side3 = Convert.ToInt32(getResult[3]);
            Point[] points = { new Point(x, y), new Point(x + side1, y), new Point(x + side1, y + side2), new Point(x + side3, y + side3) };
            g.DrawPolygon(p, points);
        }
    }
}
