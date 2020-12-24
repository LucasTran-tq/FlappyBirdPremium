namespace WindowsFormsApplication1
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
            this.pl_ScreenGame = new System.Windows.Forms.Panel();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btt_sound = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_exit3 = new Guna.UI.WinForms.GunaCircleButton();
            this.lb_highscore = new System.Windows.Forms.Label();
            this.pB_playerHighSorce = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_playerName = new System.Windows.Forms.TextBox();
            this.pB_Player = new System.Windows.Forms.PictureBox();
            this.pB_title = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pB_playerHighSorce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_title)).BeginInit();
            this.SuspendLayout();
            // 
            // pl_ScreenGame
            // 
            this.pl_ScreenGame.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pl_ScreenGame.Location = new System.Drawing.Point(22, 28);
            this.pl_ScreenGame.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pl_ScreenGame.Name = "pl_ScreenGame";
            this.pl_ScreenGame.Size = new System.Drawing.Size(733, 849);
            this.pl_ScreenGame.TabIndex = 0;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 8;
            this.gunaElipse2.TargetControl = this.pl_ScreenGame;
            // 
            // btt_sound
            // 
            this.btt_sound.AnimationHoverSpeed = 0.05F;
            this.btt_sound.AnimationSpeed = 0.01F;
            this.btt_sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_sound.BackgroundImage")));
            this.btt_sound.BaseColor = System.Drawing.Color.Transparent;
            this.btt_sound.BorderColor = System.Drawing.Color.Black;
            this.btt_sound.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_sound.FocusedColor = System.Drawing.Color.Empty;
            this.btt_sound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_sound.ForeColor = System.Drawing.Color.White;
            this.btt_sound.Image = null;
            this.btt_sound.ImageSize = new System.Drawing.Size(62, 64);
            this.btt_sound.Location = new System.Drawing.Point(893, 489);
            this.btt_sound.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btt_sound.Name = "btt_sound";
            this.btt_sound.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_sound.OnHoverImage")));
            this.btt_sound.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_sound.Size = new System.Drawing.Size(114, 116);
            this.btt_sound.TabIndex = 14;
            // 
            // btt_exit3
            // 
            this.btt_exit3.AnimationHoverSpeed = 0.05F;
            this.btt_exit3.AnimationSpeed = 0.01F;
            this.btt_exit3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_exit3.BackgroundImage")));
            this.btt_exit3.BaseColor = System.Drawing.Color.Transparent;
            this.btt_exit3.BorderColor = System.Drawing.Color.Black;
            this.btt_exit3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_exit3.FocusedColor = System.Drawing.Color.Empty;
            this.btt_exit3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_exit3.ForeColor = System.Drawing.Color.White;
            this.btt_exit3.Image = null;
            this.btt_exit3.ImageSize = new System.Drawing.Size(62, 64);
            this.btt_exit3.Location = new System.Drawing.Point(1018, 489);
            this.btt_exit3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btt_exit3.Name = "btt_exit3";
            this.btt_exit3.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_exit3.OnHoverImage")));
            this.btt_exit3.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_exit3.Size = new System.Drawing.Size(114, 116);
            this.btt_exit3.TabIndex = 15;
            this.btt_exit3.Click += new System.EventHandler(this.btt_exit3_Click);
            // 
            // lb_highscore
            // 
            this.lb_highscore.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highscore.Location = new System.Drawing.Point(988, 731);
            this.lb_highscore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_highscore.Name = "lb_highscore";
            this.lb_highscore.Size = new System.Drawing.Size(160, 46);
            this.lb_highscore.TabIndex = 13;
            this.lb_highscore.Text = "10";
            this.lb_highscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pB_playerHighSorce
            // 
            this.pB_playerHighSorce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pB_playerHighSorce.Image = ((System.Drawing.Image)(resources.GetObject("pB_playerHighSorce.Image")));
            this.pB_playerHighSorce.Location = new System.Drawing.Point(876, 700);
            this.pB_playerHighSorce.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pB_playerHighSorce.Name = "pB_playerHighSorce";
            this.pB_playerHighSorce.Size = new System.Drawing.Size(98, 98);
            this.pB_playerHighSorce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_playerHighSorce.TabIndex = 12;
            this.pB_playerHighSorce.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(917, 635);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "HIGH SCORE";
            // 
            // tB_playerName
            // 
            this.tB_playerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tB_playerName.Location = new System.Drawing.Point(869, 423);
            this.tB_playerName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tB_playerName.Name = "tB_playerName";
            this.tB_playerName.Size = new System.Drawing.Size(275, 29);
            this.tB_playerName.TabIndex = 10;
            this.tB_playerName.TabStop = false;
            this.tB_playerName.Text = "Player1";
            this.tB_playerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pB_Player
            // 
            this.pB_Player.BackColor = System.Drawing.Color.NavajoWhite;
            this.pB_Player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pB_Player.Image = ((System.Drawing.Image)(resources.GetObject("pB_Player.Image")));
            this.pB_Player.Location = new System.Drawing.Point(922, 227);
            this.pB_Player.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pB_Player.Name = "pB_Player";
            this.pB_Player.Size = new System.Drawing.Size(180, 181);
            this.pB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Player.TabIndex = 9;
            this.pB_Player.TabStop = false;
            // 
            // pB_title
            // 
            this.pB_title.Image = ((System.Drawing.Image)(resources.GetObject("pB_title.Image")));
            this.pB_title.Location = new System.Drawing.Point(788, 70);
            this.pB_title.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pB_title.Name = "pB_title";
            this.pB_title.Size = new System.Drawing.Size(444, 140);
            this.pB_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_title.TabIndex = 8;
            this.pB_title.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1283, 923);
            this.Controls.Add(this.btt_sound);
            this.Controls.Add(this.btt_exit3);
            this.Controls.Add(this.lb_highscore);
            this.Controls.Add(this.pB_playerHighSorce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_playerName);
            this.Controls.Add(this.pB_Player);
            this.Controls.Add(this.pB_title);
            this.Controls.Add(this.pl_ScreenGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pB_playerHighSorce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pl_ScreenGame;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaCircleButton btt_sound;
        private Guna.UI.WinForms.GunaCircleButton btt_exit3;
        private System.Windows.Forms.Label lb_highscore;
        private System.Windows.Forms.PictureBox pB_playerHighSorce;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_playerName;
        private System.Windows.Forms.PictureBox pB_Player;
        private System.Windows.Forms.PictureBox pB_title;
    }
}

