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
        int x1,y1;
        int x2,y2;
        int x3,y3;
        int x4,y4;

        int[] xind = new int[4];
        int[] yind = new int[4];

        List<Point> points = new List<Point>();



        public void drawshape(Graphics g, int x = 0, int y = 0, params string[] getResult)
        {
            int i = 0;
            int j = 0;
            while (i < xind.Length)
            {
                xind[i] = Convert.ToInt32(getResult[j+1]);
                yind[i] = Convert.ToInt32(getResult[j+2]);
                i+=1;
                j+=2;
            }
            for (int i1 = 0; i1 < xind.Length; i1++)
            {
                MessageBox.Show(xind[i1].ToString() + " " + yind[i1].ToString());
            }
            sort();


            //x1 = Convert.ToInt32(getResult[1]);
            //y1 = Convert.ToInt32(getResult[2]);
            //x2 = Convert.ToInt32(getResult[3]);
            //y2 = Convert.ToInt32(getResult[4]);
            //x3 = Convert.ToInt32(getResult[5]);
            //y3 = Convert.ToInt32(getResult[6]);
            //x4 = Convert.ToInt32(getResult[7]);
            //y4 = Convert.ToInt32(getResult[8]);


            for(int i1=0; i1<xind.Length; i1++)
            {
                points.Add(new Point(xind[i1],yind[i1] ));
                MessageBox.Show(xind[i1].ToString()+ " " +yind[i1].ToString());
            }
            g.DrawPolygon(p, points.ToArray());
        }

        void sort()
        {
            for(int i = 0; i < xind.Length-1; i++ )
            {
                if(xind[i] > xind[i + 1])
                {
                    int temp = xind[i];
                    xind[i] = xind[i + 1];
                    xind[i + 1] = temp;

                    temp = yind[i];
                    yind[i] = yind[i + 1];
                    yind[i + 1] = temp;
                }
            }
        }

    }
}
