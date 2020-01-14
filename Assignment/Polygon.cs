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
        int x1,y1;
        int x2,y2;
        int x3,y3;
        int x4,y4;
        public void drawshape(Graphics g, int x = 0, int y = 0, params string[] getResult)
        {
            x1 = Convert.ToInt32(getResult[1]);
            y1 = Convert.ToInt32(getResult[2]);
            x2 = Convert.ToInt32(getResult[3]);
            y2 = Convert.ToInt32(getResult[4]);
            x3 = Convert.ToInt32(getResult[5]);
            y3 = Convert.ToInt32(getResult[6]);
            x4 = Convert.ToInt32(getResult[7]);
            y4 = Convert.ToInt32(getResult[8]);
            Point[] points = { new Point(x, y), new Point(x1 ,y1), new Point(x2 , y2), new Point(x3 , y3), new Point(x4 , y4) };
            g.DrawPolygon(p, points);
        }
    }
}
