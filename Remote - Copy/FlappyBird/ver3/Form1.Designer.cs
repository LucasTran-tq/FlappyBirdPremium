namespace ver3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ongduoi1 = new System.Windows.Forms.PictureBox();
            this.ongtren1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nutplay = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbldiem = new System.Windows.Forms.Label();
            this.ongtren2 = new System.Windows.Forms.PictureBox();
            this.ongduoi2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).BeginInit();
            this.SuspendLayout();
            // 
            // ongduoi1
            // 
            this.ongduoi1.BackColor = System.Drawing.Color.Transparent;
            this.ongduoi1.Image = ((System.Drawing.Image)(resources.GetObject("ongduoi1.Image")));
            this.ongduoi1.Location = new System.Drawing.Point(311, 420);
            this.ongduoi1.Margin = new System.Windows.Forms.Padding(4);
            this.ongduoi1.Name = "ongduoi1";
            this.ongduoi1.Size = new System.Drawing.Size(79, 534);
            this.ongduoi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongduoi1.TabIndex = 2;
            this.ongduoi1.TabStop = false;
            // 
            // ongtren1
            // 
            this.ongtren1.BackColor = System.Drawing.Color.Transparent;
            this.ongtren1.Image = ((System.Drawing.Image)(resources.GetObject("ongtren1.Image")));
            this.ongtren1.Location = new System.Drawing.Point(299, -92);
            this.ongtren1.Margin = new System.Windows.Forms.Padding(4);
            this.ongtren1.Name = "ongtren1";
            this.ongtren1.Size = new System.Drawing.Size(79, 360);
            this.ongtren1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongtren1.TabIndex = 3;
            this.ongtren1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nutplay
            // 
            this.nutplay.BackColor = System.Drawing.Color.Transparent;
            this.nutplay.Image = ((System.Drawing.Image)(resources.GetObject("nutplay.Image")));
            this.nutplay.Location = new System.Drawing.Point(0, 4);
            this.nutplay.Margin = new System.Windows.Forms.Padding(4);
            this.nutplay.Name = "nutplay";
            this.nutplay.Size = new System.Drawing.Size(80, 75);
            this.nutplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nutplay.TabIndex = 7;
            this.nutplay.TabStop = false;
            this.nutplay.Click += new System.EventHandler(this.nutplay_Click);
            // 
            // lbldiem
            // 
            this.lbldiem.BackColor = System.Drawing.Color.Transparent;
            this.lbldiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiem.ForeColor = System.Drawing.Color.Black;
            this.lbldiem.Location = new System.Drawing.Point(4, 699);
            this.lbldiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(200, 62);
            this.lbldiem.TabIndex = 8;
            this.lbldiem.Text = "Score: ";
            // 
            // ongtren2
            // 
            this.ongtren2.BackColor = System.Drawing.Color.Transparent;
            this.ongtren2.Image = ((System.Drawing.Image)(resources.GetObject("ongtren2.Image")));
            this.ongtren2.Location = new System.Drawing.Point(583, -30);
            this.ongtren2.Margin = new System.Windows.Forms.Padding(4);
            this.ongtren2.Name = "ongtren2";
            this.ongtren2.Size = new System.Drawing.Size(69, 298);
            this.ongtren2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongtren2.TabIndex = 9;
            this.ongtren2.TabStop = false;
            // 
            // ongduoi2
            // 
            this.ongduoi2.BackColor = System.Drawing.Color.Transparent;
            this.ongduoi2.Image = ((System.Drawing.Image)(resources.GetObject("ongduoi2.Image")));
            this.ongduoi2.Location = new System.Drawing.Point(583, 440);
            this.ongduoi2.Margin = new System.Windows.Forms.Padding(4);
            this.ongduoi2.Name = "ongduoi2";
            this.ongduoi2.Size = new System.Drawing.Size(69, 381);
            this.ongduoi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongduoi2.TabIndex = 10;
            this.ongduoi2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(757, 786);
            this.Controls.Add(this.ongduoi2);
            this.Controls.Add(this.ongtren2);
            this.Controls.Add(this.ongtren1);
            this.Controls.Add(this.ongduoi1);
            this.Controls.Add(this.nutplay);
            this.Controls.Add(this.lbldiem);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(783, 857);
            this.MinimumSize = new System.Drawing.Size(783, 857);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ongduoi1;
        private System.Windows.Forms.PictureBox ongtren1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox nutplay;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbldiem;
        private System.Windows.Forms.PictureBox ongtren2;
        private System.Windows.Forms.PictureBox ongduoi2;

    }
}

