using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Shape
    {
       public ShapeInterface getShape(string shapeType)
        {
            shapeType = shapeType.Trim();
            if (shapeType.Equals("line"))
            {
                return new Draw();
            }

            if (shapeType.Equals("rectangle"))
            {
                return new Rectangle();
            }

            if (shapeType.Equals("circle"))
            {
                return new Circle();
            }

            if (shapeType.Equals("triangle"))
            {
                return new Triangle();
            }

            if (shapeType.Equals("polygon"))
            {
                return new Polygon();
            }

            return null;
        }
    }
}
