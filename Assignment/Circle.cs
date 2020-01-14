using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    /// <summary>
    /// Circle class is used to draw circle. This class inherit ShapeInterface. 
    /// </summary>
    public class Circle: ShapeInterface
    {
        Pen p = new Pen(Color.Red, 2);
        /// <summary>
        /// Radius is a variable to draw circle with fixed radius that is 50.
        /// </summary>
        public int radius;
        /// <summary>
        /// drawshape is method which was inherited from shapeinterface with prameter. It allows 4 parameter graphic position 1, position 2 and string array(radius only for circle).
        /// </summary>
        /// <param name="g"></param>
        /// <param name="pos1"></param>
        /// <param name="pos2"></param>
        /// <param name="getResult"></param>
        public void drawshape(Graphics g, int pos1, int pos2, params string[] getResult)
        {
            try
            {
                if (getResult[1].Equals("radius"))
                {
                    radius = 50;
                }
                else
                {
                    radius = Convert.ToInt32(getResult[1]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + getResult[1]);
            }
            g.DrawEllipse(p, pos1, pos2, 2 * radius, 2 * radius);
        }
    }
}
