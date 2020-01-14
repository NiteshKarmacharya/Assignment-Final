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
            if (shapeType == "line")
            {
                return new Draw();
            }

            if (shapeType == "rectangle")
            {
                return new Rectangle();
            }

            if (shapeType == "circle")
            {
                return new Circle();
            }

            if (shapeType == "triangle")
            {
                return new Triangle();
            }

            //if (shapeType == "polygon")
            //{
            //    return new Polygon();
            //}

            return null;
        }
    }
}
