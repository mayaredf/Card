using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Card
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //coords:
            //27,67 px 
            //44, 74 px
            //90, 82
            //135, 90
            //250, 78
            //255, 60
            //263, 57
            //186, 173
            //170, 188
            //79, 137
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //making everything dissapear
            titleLabel.Visible = false;
            nameLabel.Visible = false;
            dateLabel.Visible = false;
            this.BackgroundImage = null;

            this.Refresh();
            //drawing the dots
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);

            formGraphics.FillPie(drawBrush, 27, 67, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 44, 74, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 90, 82, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 135, 90, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 255, 60, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 250, 78, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 263, 57, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 186, 173, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 170, 188, 10, 10, 90, 360);

            Thread.Sleep(300);

            formGraphics.FillPie(drawBrush, 79, 137, 10, 10, 90, 360);

            //drawing the lines 

            Thread.Sleep(650);

            Pen drawPen = new Pen(Color.White, 3);


            formGraphics.DrawLine(drawPen, 27, 67, 44, 74);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 44, 74, 90, 82);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 90, 82, 135, 90);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 135, 90, 250, 78);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 250, 78, 255, 60);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 255, 60, 263, 57);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 263, 57, 186, 173);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 186, 173, 170, 188);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 170, 188, 79, 137);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 79, 137, 27, 67);
        }
    }
}
