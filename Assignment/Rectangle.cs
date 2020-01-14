using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    /// <summary>
    /// Rectangle class is used to draw rectangle. This class inherit ShapeInterface. 
    /// </summary>
    public class Rectangle : ShapeInterface
    {
        Pen p = new Pen(Color.Red,2);
        /// <summary>
        /// Variables to store length and beadth. 
        /// </summary>
        public int length, breadth, pos1, pos2;
        /// <summary>
        /// Inside rectangele class, to draw rectangle.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pos1"></param>
        /// <param name="pos2"></param>
        /// <param name="getResult"></param>
        public void drawshape(Graphics g, int pos1, int pos2, params string[] getResult)
        {
            if (getResult[1] == "length" && getResult[2] == "breadth")
            {
                length = 50;
                breadth = 50;
            }
            else if (getResult[1] == "breadth" && getResult[2] == "length")
            {
                length = 50;
                breadth = 50;
            }
            else
            {
                length = Convert.ToInt32(getResult[1]);
                breadth = Convert.ToInt32(getResult[2]);
            }
            
            g.DrawRectangle(p, pos1, pos2,  length, breadth);
        }
    }
}
