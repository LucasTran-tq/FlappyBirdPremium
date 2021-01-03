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
            this.label_name = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btt_replay = new Guna.UI.WinForms.GunaCircleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pB_playerHighSorce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pl_ScreenGame
            // 
            this.pl_ScreenGame.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pl_ScreenGame.Location = new System.Drawing.Point(18, 18);
            this.pl_ScreenGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pl_ScreenGame.Name = "pl_ScreenGame";
            this.pl_ScreenGame.Size = new System.Drawing.Size(600, 708);
            this.pl_ScreenGame.TabIndex = 0;
            this.pl_ScreenGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pl_ScreenGame_Paint);
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
            this.btt_sound.BackColor = System.Drawing.Color.Transparent;
            this.btt_sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_sound.BackgroundImage")));
            this.btt_sound.BaseColor = System.Drawing.Color.Transparent;
            this.btt_sound.BorderColor = System.Drawing.Color.Black;
            this.btt_sound.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_sound.FocusedColor = System.Drawing.Color.Empty;
            this.btt_sound.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_sound.ForeColor = System.Drawing.Color.White;
            this.btt_sound.Image = null;
            this.btt_sound.ImageSize = new System.Drawing.Size(62, 64);
            this.btt_sound.Location = new System.Drawing.Point(682, 352);
            this.btt_sound.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_sound.Name = "btt_sound";
            this.btt_sound.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_sound.OnHoverImage")));
            this.btt_sound.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_sound.Size = new System.Drawing.Size(93, 97);
            this.btt_sound.TabIndex = 14;
            // 
            // btt_exit3
            // 
            this.btt_exit3.AnimationHoverSpeed = 0.05F;
            this.btt_exit3.AnimationSpeed = 0.01F;
            this.btt_exit3.BackColor = System.Drawing.Color.Transparent;
            this.btt_exit3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_exit3.BackgroundImage")));
            this.btt_exit3.BaseColor = System.Drawing.Color.Transparent;
            this.btt_exit3.BorderColor = System.Drawing.Color.Black;
            this.btt_exit3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_exit3.FocusedColor = System.Drawing.Color.Empty;
            this.btt_exit3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_exit3.ForeColor = System.Drawing.Color.White;
            this.btt_exit3.Image = null;
            this.btt_exit3.ImageSize = new System.Drawing.Size(62, 64);
            this.btt_exit3.Location = new System.Drawing.Point(802, 352);
            this.btt_exit3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_exit3.Name = "btt_exit3";
            this.btt_exit3.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_exit3.OnHoverImage")));
            this.btt_exit3.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_exit3.Size = new System.Drawing.Size(93, 97);
            this.btt_exit3.TabIndex = 15;
            this.btt_exit3.Click += new System.EventHandler(this.btt_exit3_Click);
            // 
            // lb_highscore
            // 
            this.lb_highscore.BackColor = System.Drawing.Color.Transparent;
            this.lb_highscore.Font = new System.Drawing.Font("Snap ITC", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highscore.ForeColor = System.Drawing.Color.Black;
            this.lb_highscore.Location = new System.Drawing.Point(258, 139);
            this.lb_highscore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_highscore.Name = "lb_highscore";
            this.lb_highscore.Size = new System.Drawing.Size(130, 38);
            this.lb_highscore.TabIndex = 13;
            this.lb_highscore.Text = "10";
            this.lb_highscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_highscore.Click += new System.EventHandler(this.lb_highscore_Click);
            // 
            // pB_playerHighSorce
            // 
            this.pB_playerHighSorce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pB_playerHighSorce.Image = ((System.Drawing.Image)(resources.GetObject("pB_playerHighSorce.Image")));
            this.pB_playerHighSorce.Location = new System.Drawing.Point(43, 40);
            this.pB_playerHighSorce.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pB_playerHighSorce.Name = "pB_playerHighSorce";
            this.pB_playerHighSorce.Size = new System.Drawing.Size(118, 72);
            this.pB_playerHighSorce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_playerHighSorce.TabIndex = 12;
            this.pB_playerHighSorce.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::WindowsFormsApplication1.Properties.Resources.highScore;
            this.label1.Location = new System.Drawing.Point(108, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 51);
            this.label1.TabIndex = 11;
            this.label1.Text = "  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tB_playerName
            // 
            this.tB_playerName.BackColor = System.Drawing.Color.PeachPuff;
            this.tB_playerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tB_playerName.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_playerName.Location = new System.Drawing.Point(843, 267);
            this.tB_playerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tB_playerName.Name = "tB_playerName";
            this.tB_playerName.Size = new System.Drawing.Size(163, 39);
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
            this.pB_Player.Location = new System.Drawing.Point(33, 32);
            this.pB_Player.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pB_Player.Name = "pB_Player";
            this.pB_Player.Size = new System.Drawing.Size(133, 95);
            this.pB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Player.TabIndex = 9;
            this.pB_Player.TabStop = false;
            this.pB_Player.Click += new System.EventHandler(this.pB_Player_Click);
            // 
            // label_name
            // 
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Snap ITC", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_name.ForeColor = System.Drawing.Color.Black;
            this.label_name.Location = new System.Drawing.Point(237, 94);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(165, 41);
            this.label_name.TabIndex = 16;
            this.label_name.Text = "Player";
            this.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 5;
            this.gunaElipse5.TargetControl = this;
            // 
            // btt_replay
            // 
            this.btt_replay.AnimationHoverSpeed = 0.05F;
            this.btt_replay.AnimationSpeed = 0.01F;
            this.btt_replay.BackColor = System.Drawing.Color.Transparent;
            this.btt_replay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_replay.BackgroundImage")));
            this.btt_replay.BaseColor = System.Drawing.Color.Transparent;
            this.btt_replay.BorderColor = System.Drawing.Color.Black;
            this.btt_replay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_replay.FocusedColor = System.Drawing.Color.Empty;
            this.btt_replay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_replay.ForeColor = System.Drawing.Color.White;
            this.btt_replay.Image = null;
            this.btt_replay.ImageSize = new System.Drawing.Size(62, 64);
            this.btt_replay.Location = new System.Drawing.Point(941, 352);
            this.btt_replay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_replay.Name = "btt_replay";
            this.btt_replay.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_replay.OnHoverImage")));
            this.btt_replay.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_replay.Size = new System.Drawing.Size(93, 92);
            this.btt_replay.TabIndex = 19;
            this.btt_replay.Click += new System.EventHandler(this.btt_replay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.ori_logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(625, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 182);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_name);
            this.panel1.Controls.Add(this.lb_highscore);
            this.panel1.Location = new System.Drawing.Point(618, 440);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 286);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.pB_playerHighSorce);
            this.panel3.Location = new System.Drawing.Point(51, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 150);
            this.panel3.TabIndex = 0;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 8;
            this.gunaElipse4.TargetControl = this.panel1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.pB_Player);
            this.panel2.Location = new System.Drawing.Point(618, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 160);
            this.panel2.TabIndex = 0;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.TargetControl = this.tB_playerName;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 919);
            this.Controls.Add(this.tB_playerName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btt_exit3);
            this.Controls.Add(this.btt_sound);
            this.Controls.Add(this.btt_replay);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pl_ScreenGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pB_playerHighSorce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private Guna.UI.WinForms.GunaCircleButton btt_replay;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
    }
}

