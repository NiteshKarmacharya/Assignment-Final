using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public class Validate
    {
        public string[] getValidate(string Input)
        {
            string[] retu = { };
            string[] InputText = Input.Split(' ',',');
            if (InputText[0] == "")
            {
                MessageBox.Show("Command not found !!!");
            }
            else if (InputText.Length > 1)
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
                        int x = Convert.ToInt32(InputText[1]);
                        int y = Convert.ToInt32(InputText[2]);
                        string penpos1 = Convert.ToString(x);
                        string penpos2 = Convert.ToString(y);
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
                        int x = Convert.ToInt32(InputText[1]);
                        int y = Convert.ToInt32(InputText[2]);
                        string pointx = Convert.ToString(x);
                        string pointy = Convert.ToString(y);
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
                        int x = Convert.ToInt32(InputText[1]);
                        int y = Convert.ToInt32(InputText[2]);
                        string length = Convert.ToString(x);
                        string breadth = Convert.ToString(y);
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
                        int x = Convert.ToInt32(InputText[1]);
                        string radius = Convert.ToString(x);
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
