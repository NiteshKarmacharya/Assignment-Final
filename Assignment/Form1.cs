using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment
{
    public partial class Form1 : Form
    {
        int pos1, pos2;
        Graphics g;
        /// <summary>
        /// Form1 is to create windows form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            g = pnlDrawField.CreateGraphics();
        }

        //Close button function

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //resoze button function

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UserInput.ResetText();
            txtMultiLine.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlDrawField.Refresh();
        }

        private void btnMultilineExecute_Click(object sender, EventArgs e)
        {
            string userInput = txtMultiLine.Text;
            string[] lineSeparate = userInput.Split('\n');

            foreach (string eachline in lineSeparate)
            {
                if (lineSeparate.Equals(" ") || lineSeparate.Equals(null))
                {

                }
                else
                {
                    string UserInput = eachline;
                    Validate validate = new Validate();
                    string[] getInput = validate.getValidate(UserInput);
                    if (getInput.Length > 1)
                    {
                        if (getInput[0].Equals("moveto"))
                        {
                            int x = Convert.ToInt32(getInput[1]);
                            int y = Convert.ToInt32(getInput[2]);
                            pos1 = x;
                            pos2 = y;
                        }

                        else if (getInput[0].Equals("line"))
                        {
                            Shape shape = new Shape();
                            ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                            shapeinterface.drawshape(g, pos1, pos2, getInput);
                        }

                        else if (getInput[0].Equals("rectangle"))
                        {
                            Shape shape = new Shape();
                            ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                            shapeinterface.drawshape(g, pos1, pos2, getInput);
                        }

                        else if (getInput[0].Equals("circle"))
                        {
                            Shape shape = new Shape();
                            ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                            shapeinterface.drawshape(g, pos1, pos2, getInput);
                        }

                        else if (getInput[0].Equals("triangle"))
                        {
                            Shape shape = new Shape();
                            ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                            shapeinterface.drawshape(g, pos1, pos2, getInput);
                        }

                        else if (getInput[0].Equals("polygon"))
                        {
                            Shape shape = new Shape();
                            ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                            shapeinterface.drawshape(g, pos1, pos2, getInput);
                        }

                        else
                        {
                            throw new Exception("Parameter Not Found !!!");
                        }
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                txtMultiLine.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                txtMultiLine.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }
        }
        /// <summary>
        /// Its a run button to run single line command and draw shape from single line command
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnRun_Click(object sender, EventArgs e)
        {
            string UserInput = this.UserInput.Text;
            Validate validate = new Validate();
            string[] getInput = validate.getValidate(UserInput);
            this.UserInput.ResetText();
            if (getInput.Length > 1)
            {
                if (getInput[0] == "moveto")
                {
                    int x = Convert.ToInt32(getInput[1]);
                    int y = Convert.ToInt32(getInput[2]);
                    pos1 = x;
                    pos2 = y;
                    
                }

                else if (getInput[0] == "line")
                {
                    Shape shape = new Shape();
                    ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                    shapeinterface.drawshape(g, pos1, pos2, getInput);
                }

                else if (getInput[0] == "rectangle")
                {
                    Shape shape = new Shape();
                    ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                    shapeinterface.drawshape(g, pos1, pos2, getInput);
                }

                else if (getInput[0] == "circle")
                {
                    Shape shape = new Shape();
                    ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                    shapeinterface.drawshape(g, pos1, pos2, getInput);
                }

                else if (getInput[0] == "triangle")
                {
                    Shape shape = new Shape();
                    ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                    shapeinterface.drawshape(g, pos1, pos2, getInput);
                }
                else if (getInput[0] == "polygon")
                {
                    Shape shape = new Shape();
                    ShapeInterface shapeinterface = shape.getShape(getInput[0]);
                    shapeinterface.drawshape(g, pos1, pos2, getInput);
                }

                else
                {
                    throw new Exception("Parameter Not Foundasdfasdf !!!");
                }
            }
        }
    }
}
