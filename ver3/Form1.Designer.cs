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
            this.ongtren2 = new System.Windows.Forms.PictureBox();
            this.ongduoi2 = new System.Windows.Forms.PictureBox();
            this.conchim = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nutplay = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbldiem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutplay)).BeginInit();
            this.SuspendLayout();
            // 
            // ongduoi1
            // 
            this.ongduoi1.Image = ((System.Drawing.Image)(resources.GetObject("ongduoi1.Image")));
            this.ongduoi1.Location = new System.Drawing.Point(212, 174);
            this.ongduoi1.Name = "ongduoi1";
            this.ongduoi1.Size = new System.Drawing.Size(274, 1001);
            this.ongduoi1.TabIndex = 2;
            this.ongduoi1.TabStop = false;
            // 
            // ongtren1
            // 
            this.ongtren1.Image = ((System.Drawing.Image)(resources.GetObject("ongtren1.Image")));
            this.ongtren1.Location = new System.Drawing.Point(222, -902);
            this.ongtren1.Name = "ongtren1";
            this.ongtren1.Size = new System.Drawing.Size(264, 993);
            this.ongtren1.TabIndex = 3;
            this.ongtren1.TabStop = false;
            // 
            // ongtren2
            // 
            this.ongtren2.Image = ((System.Drawing.Image)(resources.GetObject("ongtren2.Image")));
            this.ongtren2.Location = new System.Drawing.Point(539, -825);
            this.ongtren2.Name = "ongtren2";
            this.ongtren2.Size = new System.Drawing.Size(264, 993);
            this.ongtren2.TabIndex = 4;
            this.ongtren2.TabStop = false;
            // 
            // ongduoi2
            // 
            this.ongduoi2.Image = ((System.Drawing.Image)(resources.GetObject("ongduoi2.Image")));
            this.ongduoi2.Location = new System.Drawing.Point(529, 194);
            this.ongduoi2.Name = "ongduoi2";
            this.ongduoi2.Size = new System.Drawing.Size(274, 1001);
            this.ongduoi2.TabIndex = 5;
            this.ongduoi2.TabStop = false;
            // 
            // conchim
            // 
            this.conchim.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("conchim.BackgroundImage")));
            this.conchim.Image = ((System.Drawing.Image)(resources.GetObject("conchim.Image")));
            this.conchim.Location = new System.Drawing.Point(0, 114);
            this.conchim.Name = "conchim";
            this.conchim.Size = new System.Drawing.Size(163, 112);
            this.conchim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conchim.TabIndex = 6;
            this.conchim.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nutplay
            // 
            this.nutplay.BackColor = System.Drawing.Color.White;
            this.nutplay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nutplay.BackgroundImage")));
            this.nutplay.Image = ((System.Drawing.Image)(resources.GetObject("nutplay.Image")));
            this.nutplay.Location = new System.Drawing.Point(0, 12);
            this.nutplay.Name = "nutplay";
            this.nutplay.Size = new System.Drawing.Size(49, 50);
            this.nutplay.TabIndex = 7;
            this.nutplay.TabStop = false;
            this.nutplay.Click += new System.EventHandler(this.nutplay_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbldiem
            // 
            this.lbldiem.AutoSize = true;
            this.lbldiem.BackColor = System.Drawing.Color.White;
            this.lbldiem.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiem.Location = new System.Drawing.Point(0, 229);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(196, 68);
            this.lbldiem.TabIndex = 8;
            this.lbldiem.Text = "Score: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1282, 550);
            this.Controls.Add(this.lbldiem);
            this.Controls.Add(this.nutplay);
            this.Controls.Add(this.conchim);
            this.Controls.Add(this.ongduoi2);
            this.Controls.Add(this.ongtren2);
            this.Controls.Add(this.ongtren1);
            this.Controls.Add(this.ongduoi1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conchim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ongduoi1;
        private System.Windows.Forms.PictureBox ongtren1;
        private System.Windows.Forms.PictureBox ongtren2;
        private System.Windows.Forms.PictureBox ongduoi2;
        private System.Windows.Forms.PictureBox conchim;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox nutplay;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbldiem;
    }
}

