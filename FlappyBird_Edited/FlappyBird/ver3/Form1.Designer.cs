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
            this.lbldiem = new System.Windows.Forms.Label();
            this.ongtren2 = new System.Windows.Forms.PictureBox();
            this.ongduoi2 = new System.Windows.Forms.PictureBox();
            this.pb_Title = new System.Windows.Forms.PictureBox();
            this.pb_GameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // ongduoi1
            // 
            this.ongduoi1.BackColor = System.Drawing.Color.Transparent;
            this.ongduoi1.Image = ((System.Drawing.Image)(resources.GetObject("ongduoi1.Image")));
            this.ongduoi1.Location = new System.Drawing.Point(149, 244);
            this.ongduoi1.Margin = new System.Windows.Forms.Padding(2);
            this.ongduoi1.Name = "ongduoi1";
            this.ongduoi1.Size = new System.Drawing.Size(52, 250);
            this.ongduoi1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongduoi1.TabIndex = 2;
            this.ongduoi1.TabStop = false;
            // 
            // ongtren1
            // 
            this.ongtren1.BackColor = System.Drawing.Color.Transparent;
            this.ongtren1.Image = ((System.Drawing.Image)(resources.GetObject("ongtren1.Image")));
            this.ongtren1.Location = new System.Drawing.Point(149, -137);
            this.ongtren1.Margin = new System.Windows.Forms.Padding(2);
            this.ongtren1.Name = "ongtren1";
            this.ongtren1.Size = new System.Drawing.Size(52, 250);
            this.ongtren1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongtren1.TabIndex = 3;
            this.ongtren1.TabStop = false;
            this.ongtren1.Paint += new System.Windows.Forms.PaintEventHandler(this.ongtren1_Paint);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nutplay
            // 
            this.nutplay.BackColor = System.Drawing.Color.Transparent;
            this.nutplay.Image = ((System.Drawing.Image)(resources.GetObject("nutplay.Image")));
            this.nutplay.Location = new System.Drawing.Point(126, 172);
            this.nutplay.Margin = new System.Windows.Forms.Padding(2);
            this.nutplay.Name = "nutplay";
            this.nutplay.Size = new System.Drawing.Size(102, 68);
            this.nutplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nutplay.TabIndex = 7;
            this.nutplay.TabStop = false;
            this.nutplay.Click += new System.EventHandler(this.nutplay_Click);
            // 
            // lbldiem
            // 
            this.lbldiem.BackColor = System.Drawing.Color.Transparent;
            this.lbldiem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldiem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbldiem.Location = new System.Drawing.Point(11, 9);
            this.lbldiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldiem.Name = "lbldiem";
            this.lbldiem.Size = new System.Drawing.Size(60, 32);
            this.lbldiem.TabIndex = 8;
            this.lbldiem.Text = "0";
            this.lbldiem.Click += new System.EventHandler(this.lbldiem_Click);
            // 
            // ongtren2
            // 
            this.ongtren2.BackColor = System.Drawing.Color.Transparent;
            this.ongtren2.Image = ((System.Drawing.Image)(resources.GetObject("ongtren2.Image")));
            this.ongtren2.Location = new System.Drawing.Point(300, -137);
            this.ongtren2.Margin = new System.Windows.Forms.Padding(2);
            this.ongtren2.Name = "ongtren2";
            this.ongtren2.Size = new System.Drawing.Size(52, 250);
            this.ongtren2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongtren2.TabIndex = 9;
            this.ongtren2.TabStop = false;
            // 
            // ongduoi2
            // 
            this.ongduoi2.BackColor = System.Drawing.Color.Transparent;
            this.ongduoi2.Image = ((System.Drawing.Image)(resources.GetObject("ongduoi2.Image")));
            this.ongduoi2.Location = new System.Drawing.Point(300, 244);
            this.ongduoi2.Margin = new System.Windows.Forms.Padding(2);
            this.ongduoi2.Name = "ongduoi2";
            this.ongduoi2.Size = new System.Drawing.Size(52, 250);
            this.ongduoi2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ongduoi2.TabIndex = 10;
            this.ongduoi2.TabStop = false;
            // 
            // pb_Title
            // 
            this.pb_Title.BackColor = System.Drawing.Color.Transparent;
            this.pb_Title.Image = ((System.Drawing.Image)(resources.GetObject("pb_Title.Image")));
            this.pb_Title.Location = new System.Drawing.Point(54, 83);
            this.pb_Title.Name = "pb_Title";
            this.pb_Title.Size = new System.Drawing.Size(266, 72);
            this.pb_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Title.TabIndex = 11;
            this.pb_Title.TabStop = false;
            // 
            // pb_GameOver
            // 
            this.pb_GameOver.BackColor = System.Drawing.Color.Transparent;
            this.pb_GameOver.Image = ((System.Drawing.Image)(resources.GetObject("pb_GameOver.Image")));
            this.pb_GameOver.Location = new System.Drawing.Point(49, 99);
            this.pb_GameOver.Name = "pb_GameOver";
            this.pb_GameOver.Size = new System.Drawing.Size(271, 68);
            this.pb_GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_GameOver.TabIndex = 11;
            this.pb_GameOver.TabStop = false;
            this.pb_GameOver.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(364, 416);
            this.Controls.Add(this.lbldiem);
            this.Controls.Add(this.pb_GameOver);
            this.Controls.Add(this.pb_Title);
            this.Controls.Add(this.ongduoi2);
            this.Controls.Add(this.ongtren2);
            this.Controls.Add(this.ongtren1);
            this.Controls.Add(this.ongduoi1);
            this.Controls.Add(this.nutplay);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(380, 455);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nutplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongtren2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ongduoi2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ongduoi1;
        private System.Windows.Forms.PictureBox ongtren1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox nutplay;
        private System.Windows.Forms.PictureBox ongtren2;
        private System.Windows.Forms.PictureBox ongduoi2;
        private System.Windows.Forms.PictureBox pb_Title;
        private System.Windows.Forms.PictureBox pb_GameOver;
        private System.Windows.Forms.Label lbldiem;

    }
}

