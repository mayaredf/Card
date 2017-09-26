namespace Card
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.titleLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.infoLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Source Code Pro", 18F);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.titleLabel.Location = new System.Drawing.Point(31, 51);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(336, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Capricorn Greeting Card";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.nameLabel.Location = new System.Drawing.Point(94, 402);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(195, 21);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "by Maya Redford-Haines";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dateLabel.Location = new System.Drawing.Point(104, 424);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(174, 18);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "September 22, 2017";
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.infoLabel2.Location = new System.Drawing.Point(9, 378);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(10, 13);
            this.infoLabel2.TabIndex = 3;
            this.infoLabel2.Text = " ";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.infoLabel.Location = new System.Drawing.Point(9, 350);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(10, 13);
            this.infoLabel.TabIndex = 4;
            this.infoLabel.Text = " ";
            // 
            // infoLabel3
            // 
            this.infoLabel3.AutoSize = true;
            this.infoLabel3.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.infoLabel3.Location = new System.Drawing.Point(9, 402);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(10, 13);
            this.infoLabel3.TabIndex = 5;
            this.infoLabel3.Text = " ";
            // 
            // infoLabel4
            // 
            this.infoLabel4.AutoSize = true;
            this.infoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.infoLabel4.Location = new System.Drawing.Point(9, 424);
            this.infoLabel4.Name = "infoLabel4";
            this.infoLabel4.Size = new System.Drawing.Size(10, 13);
            this.infoLabel4.TabIndex = 6;
            this.infoLabel4.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(397, 513);
            this.Controls.Add(this.infoLabel4);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.titleLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = ".   * . Greeting Card  *   .  *";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label infoLabel4;
    }
}

