using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Triangle : ShapeInterface
    {
        Pen p = new Pen(Color.Red, 2);
        int side1, side2, side3 , side;
        public void drawshape(Graphics g, int x = 0, int y = 0, params string[] getResult)
        {
            for(int i=1; i < getResult.Length; i++ )
            {
                if (getResult[i] == "adjcent" || getResult[i] == "base" || getResult[i] == "hypotenuse")
                {
                    side1 = 50;
                    side2 = 50;
                    side3 = 50;
                }
                else
                {
                    side1 = Convert.ToInt32(getResult[1]);
                    side2 = Convert.ToInt32(getResult[2]);
                    side3 = Convert.ToInt32(getResult[3]);
                    break;
                }
            }
            //Point[] points = { new Point(x,y), new Point(x+side1, y), new Point(x+side1, y + side2), new Point(x+side3, y+side3) };
            //g.DrawPolygon(p, points);
            g.DrawLine(p, x, y, x+side1,y );
            g.DrawLine(p, x+side1, y, x+side1, y+side2);
            g.DrawLine(p, x, y, x + side3, y + side3);
        }
    }
}
