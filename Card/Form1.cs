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
            //27,67 px 
            

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            titleLabel.Visible = false;
            nameLabel.Visible = false;
            dateLabel.Visible = false;
            


            Graphics formGraphics = this.CreateGraphics();
            SolidBrush drawBrush = new SolidBrush(Color.White);
            formGraphics.FillPie(drawBrush, 27, 67, 10, 10, 90, 360);
        }
    }
}
