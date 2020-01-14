﻿using System;
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
                throw new Exception("Command not found !!!");
            }
            else if (InputText.Length > 1)
            {
                if (InputText[0].ToLower() == "moveto")
                {
                    if (InputText.Length < 2)
                    {
                        throw new Exception("No parameter found !!! \n Input two paramater !!!");
                    }
                    else if (InputText.Length < 3)
                    {
                        throw new Exception("Parameter length not match !!! \nOne more parameter needed !!!");
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
                        throw new Exception("Parameter length not match !!! \nOnly two parameter is valid !!!");
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
                        throw new Exception("Only one parameter found !!! \nOne more parameter needed !!!");
                    }
                    else
                    {
                        throw new Exception("Parameter length not match !!! \nOnly two parameter is valid !!!");
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
                        throw new Exception("Only one parameter found !!! \nOne more parameter needed !!!");
                    }
                    else
                    {
                        throw new Exception("Parameter length not match !!! \nOnly two parameter is valid !!!");
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
                        throw new Exception("Parameter length not match !!! \nOnly radius is valid !!!");
                    }
                }

                else if (InputText[0].ToLower() == "triangle")
                {
                    if (InputText.Length == 3)
                    {
                        throw new Exception("Three side required !!! \nEnter 3 sides of triangle !!!");
                    }

                    else if (InputText.Length < 5 && InputText.Length > 2)
                    {
                        //int x = Convert.ToInt32(InputText[1]);
                        //int y = Convert.ToInt32(InputText[2]);
                        //int z = Convert.ToInt32(InputText[3]);
                        string side1 = InputText[1];
                        string side2 = InputText[2];
                        string side3 = InputText[3];
                        string[] k = { "triangle", side1, side2, side3 };
                        retu = k;
                    }
                    
                    else
                    {
                        throw new Exception("Parameter length not match !!! \nOnly three side is valid !!!");
                    }
                }

                else
                {
                    //MessageBox.Show("Command not found "+InputText[0]+" !!!");
                    throw new Exception("Command not found " + InputText[0] + " !!!");
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