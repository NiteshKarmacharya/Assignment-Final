using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    /// <summary>
    /// Validate commands and parameters entered by end user.
    /// </summary>
    public class Validate
    {
        /// <summary>
        /// Get input as paramenter and pass to validate.
        /// </summary>
        /// <param name="Input"></param>
        /// <returns></returns>
        public string[] getValidate(string Input)
        {
            string[] retu = { };
            
            string[] InputText = Input.Split(' ',',');
            if (InputText.Length > 1)
            {
                if (InputText[0].ToLower() == "moveto")
                {
                    if (InputText.Length < 2)
                    {
                        MessageBox.Show("No parameter found !!! \n Input two paramater !!!");
                    }
                    else if (InputText.Length < 3)
                    {
                        MessageBox.Show("Parameter length not match !!! \nOne more parameter needed !!!");
                    }
                    
                    else if (InputText.Length < 4)
                    {
                        string penpos1 = InputText[1];
                        string penpos2 = InputText[2];
                        string[] k = { "moveto", penpos1, penpos2 };
                        retu = k;
                    }
                    else
                    {
                        MessageBox.Show("Parameter length not match !!! \nOnly two parameter is valid !!!");
                    }
                }

                else if (InputText[0].ToLower() == "drawto")
                {
                    if (InputText.Length < 4 && InputText.Length > 2)
                    {
                        string pointx = InputText[1];
                        string pointy = InputText[2];
                        string[] k = { "line", pointx, pointy };
                        retu = k;
                    }
                    else if (InputText.Length < 3)
                    {
                        MessageBox.Show("Only one parameter found !!! \nOne more parameter needed !!!");
                    }
                    else
                    {
                        MessageBox.Show("Parameter length not match !!! \nOnly two parameter is valid !!!");
                    }
                }

                else if (InputText[0].ToLower() == "rectangle")
                {
                    if (InputText.Length < 4 && InputText.Length > 2 )
                    {
                        string length = InputText[1];
                        string breadth = InputText[2];
                        string[] k = { "rectangle", length, breadth };
                        retu = k;
                    }
                    else if (InputText.Length < 3)
                    {
                        MessageBox.Show("Only one parameter found !!! \nOne more parameter needed !!!");
                    }
                    else
                    {
                        MessageBox.Show("Parameter length not match !!! \nOnly two parameter is valid !!!");
                    }
                }

                else if (InputText[0].ToLower() == "circle")
                {
                    if (InputText.Length < 3)
                    {
                        string radius = InputText[1];
                        string[] k = { "circle", radius };
                        retu = k;
                    }
                    else
                    {
                        MessageBox.Show("Parameter length not match !!! \nOnly radius is valid !!!");
                    }
                }

                else if (InputText[0].ToLower() == "triangle")
                {
                    if (InputText.Length == 3)
                    {
                        MessageBox.Show("Three side required !!! \nEnter 3 sides of triangle !!!");
                    }

                    else if (InputText.Length < 5 && InputText.Length > 2)
                    {
                        string side1 = InputText[1];
                        string side2 = InputText[2];
                        string side3 = InputText[3];
                        string[] k = { "triangle", side1, side2, side3 };
                        retu = k;
                    }
                    
                    else
                    {
                        MessageBox.Show("Parameter length not match !!! \nOnly three side is valid !!!");
                    }
                }

                else if (InputText[0].ToLower() == "polygon")
                {
                    if (InputText.Length == 9)
                    {
                        string x1 = InputText[1];
                        string y1 = InputText[2];
                        string x2 = InputText[3];
                        string y2 = InputText[4];
                        string x3 = InputText[5];
                        string y3 = InputText[6];
                        string x4 = InputText[7];
                        string y4 = InputText[8];
                        string[] k = { "polygon", x1, y1, x2, y2, x3, y3, x4, y4 };
                        retu = k;
                    }

                    else
                    {
                        MessageBox.Show("Parameter length not match !!! \nX and Y co-ordinates of each point required !!!");
                    }
                }

                else
                {
                    MessageBox.Show("Command not found " + InputText[0] + " !!!");
                }
            }
            else
            {
                MessageBox.Show("Parameter not found !!!");
            }
            
            return retu;
        }
    }
}
