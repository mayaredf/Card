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
            //OVER 5 DOWN FIVE TO MAKE IT SYNC!!!!!!! DONT FORGET!!!!!!!!!!!!
            //DELETE THIS WHEN YOURE DONE
            //YOU DID 50 INSTEAD OF 5!!!!!!!!!!!!!! FIX THIS
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
            
            formGraphics.DrawLine(drawPen, 77, 117, 94, 124);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 94, 124, 140, 132);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 140, 132, 185, 140);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 185, 140, 300, 128); 

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 300, 128, 305, 110);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 305, 110, 313, 107);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 313, 107, 236, 223);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 236, 223, 220, 238);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 220, 238, 79, 137);

            Thread.Sleep(300);

            formGraphics.DrawLine(drawPen, 79, 137, 27, 67);
            
            // audio
            SoundPlayer player = new SoundPlayer(Properties.Resources.star);
            player.Play();



            //info text
            formGraphics.DrawString("Capricornus is one of the 88 modern constellations, and was also one of the 48", drawFont, drawBrush, 10, 10);
            
            Thread.Sleep(300);

            infoLabel2.Text = "constellations listed by the 2nd century astronomer Ptolemy.";
            Thread.Sleep(300);

            infoLabel3.Text = "Its name is Latin for horned goat, and it is commonly represented in the form";
            Thread.Sleep(300);

            infoLabel4.Text = "of a sea-goat: a mythical creature that is half goat, half fish.";

            
        }
    }
}
