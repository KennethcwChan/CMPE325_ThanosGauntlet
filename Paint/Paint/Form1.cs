using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        float x1 = 0;
        float y1 = 0;
        bool mouseDown = false;
        SolidBrush brush = new SolidBrush(Color.Black);
        Pen pen = new Pen(Color.Black, 5);
        public Form1()
        {
            InitializeComponent();
            
        }
       
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //Graphics graphic = canvas.CreateGraphics();
            mouseDown = true;
            //SolidBrush sb = new SolidBrush(Color.Black);
          
            //graphic.FillRectangle(sb, e.X, e.Y, 20, 20);
              
            //mouseDown = false;
             x1 = e.X;
             y1 = e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            //x1 = null;
            //y1 = null;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Graphics graphic = canvas.CreateGraphics();
               
                //if ((Math.Abs(e.X - x1) > 3) || (Math.Abs(e.Y - y1) > 3)) { 
                graphic.DrawLine(pen, x1, y1, e.X, e.Y);
                x1 = e.X;
                y1 = e.Y;
               //}
                
               // graphic.FillEllipse(brush, e.X, e.Y, 5, 5);

                //graphic.FillRectangle(brush, e.X, e.Y, 5, 5);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = button1.BackColor;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            pen.Color = button10.BackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pen.Color = button2.BackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pen.Color = button6.BackColor;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pen.Color = button9.BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pen.Color = button8.BackColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pen.Color = button7.BackColor;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pen.Color = button3.BackColor;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pen.Color = button4.BackColor;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pen.Color = button5.BackColor;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            pen.Color = button11.BackColor;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pen.Width = 1;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pen.Width = 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pen.Width = 10;
        }
    }
}
