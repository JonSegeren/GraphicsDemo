using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 3);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            formGraphics.Clear(Color.White);
            formGraphics.DrawLine(drawPen, 100, 0, 100, 100);
            formGraphics.DrawRectangle(drawPen, 30, 30, 100, 200);
            formGraphics.FillRectangle(drawBrush, 30, 30, 100, 200);
            formGraphics.DrawEllipse(drawPen, 100, 100, 100, 200);
            formGraphics.FillEllipse(drawBrush, 100, 100, 100, 200);

            formGraphics.DrawArc(drawPen, 300, 20, 50, 50, 30, 300);
            formGraphics.DrawPie(drawPen, 20, 300, 50, 50, 30, 300);







        }
    }
}
