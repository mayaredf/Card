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
using System.Media;

//September 22, 2017
//Created by Maya Redford-Haines
//This program demonstrates timing, images, sounds, and graphics.

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
            SolidBrush drawBrush2 = new SolidBrush(Color.LightSkyBlue);
            Pen drawPen2 = new Pen(Color.White, 10);
            Font drawFont = new Font("Arial", 10);
            //create a pen and a font

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

            formGraphics.DrawLine(drawPen, 32, 72, 32, 72);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 32, 72, 49, 79);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 49, 79, 95, 87);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 95, 87, 140, 95);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 140, 95, 260, 65);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 260, 65, 268, 62);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 268, 62, 191, 178);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 191, 178, 175, 193);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 175, 193, 84, 142);
            Thread.Sleep(300);
            formGraphics.DrawLine(drawPen, 84, 142, 32, 72);

            // audio
            SoundPlayer player = new SoundPlayer(Properties.Resources.star);
            player.Play();

            //info text
            formGraphics.DrawString("Capricornus is one of the 88 modern constellations, and was also ", drawFont, drawBrush2, 1, 400);
            Thread.Sleep(300);
            formGraphics.DrawString(" one of the 48 constellations listed by the 2nd century ", drawFont, drawBrush2, 1, 420);
            Thread.Sleep(300);
            formGraphics.DrawString("astronomer Ptolemy. Its name is Latin for horned goat, and ", drawFont, drawBrush2, 1, 440);
            Thread.Sleep(300);
            formGraphics.DrawString("it is commonly represented in the form of a sea-goat: a ", drawFont, drawBrush2, 1, 460);
            Thread.Sleep(300);
            formGraphics.DrawString("mythical creature that is half goat, half fish.", drawFont, drawBrush2, 1, 480);


        }
    }
}
