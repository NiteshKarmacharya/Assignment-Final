using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    class Polygon : ShapeInterface
    {
        Pen p = new Pen(Color.Red, 2);

        int[] xind = new int[4];
        int[] yind = new int[4];

        List<Point> points = new List<Point>();



        public void drawshape(Graphics g, int x = 0, int y = 0, params string[] getResult)
        {
            int i = 0;
            int j = 0;

            //accepting input into array
            while (i < xind.Length)
            {
                xind[i] = Convert.ToInt32(getResult[j + 1]);
                yind[i] = Convert.ToInt32(getResult[j + 2]);
                i += 1;
                j += 2;
            }

            sort();     // sorting the input points

            for (int i1 = 0; i1 < xind.Length; i1++)
            {
                points.Add(new Point(xind[i1], yind[i1]));  //Adding the sorted points individually
            }

            //plotting the added points
            g.DrawPolygon(p, points.ToArray());
        }

        void sort()
        {
            for (int i = 0; i < xind.Length - 1; i++)
            {
                for (int j = i + 1; j < xind.Length; j++)
                {
                    if (xind[i] > xind[j])
                    {
                        int temp = xind[i];
                        xind[i] = xind[j];
                        xind[j] = temp;

                        temp = yind[i];
                        yind[i] = yind[j];
                        yind[j] = temp;
                    }
                }
            }
        }
    }
}
