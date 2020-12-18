namespace Flappy_Bird
{
    partial class BackgroundGame
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
        protected void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackgroundGame));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pl_ScreenGame = new System.Windows.Forms.Panel();
            this.btt_exit2 = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_replay = new Guna.UI.WinForms.GunaCircleButton();
            this.pl_BgMenu = new System.Windows.Forms.Panel();
            this.btt_SpeedEasy = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_SpeedHard = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_SpeedMedium = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_Exit = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_Menu = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_Play = new Guna.UI.WinForms.GunaCircleButton();
            this.pB_IntroBird = new System.Windows.Forms.PictureBox();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pB_title = new System.Windows.Forms.PictureBox();
            this.pB_Player = new System.Windows.Forms.PictureBox();
            this.tB_playerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pB_playerHighSorce = new System.Windows.Forms.PictureBox();
            this.lB_playerHighScore = new System.Windows.Forms.Label();
            this.lb_highscore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btt_scene = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_item = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_speed = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_exit3 = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_sound = new Guna.UI.WinForms.GunaCircleButton();
            this.pB_GameOver = new System.Windows.Forms.PictureBox();
            this.btt_Back = new Guna.UI.WinForms.GunaCircleButton();
            this.pl_ScreenGame.SuspendLayout();
            this.pl_BgMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pB_IntroBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_playerHighSorce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_GameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // pl_ScreenGame
            // 
            this.pl_ScreenGame.BackColor = System.Drawing.Color.Transparent;
            this.pl_ScreenGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pl_ScreenGame.BackgroundImage")));
            this.pl_ScreenGame.Controls.Add(this.pl_BgMenu);
            this.pl_ScreenGame.Controls.Add(this.btt_exit2);
            this.pl_ScreenGame.Controls.Add(this.btt_replay);
            this.pl_ScreenGame.Controls.Add(this.btt_Exit);
            this.pl_ScreenGame.Controls.Add(this.btt_Menu);
            this.pl_ScreenGame.Controls.Add(this.btt_Play);
            this.pl_ScreenGame.Controls.Add(this.pB_IntroBird);
            this.pl_ScreenGame.Controls.Add(this.pB_GameOver);
            this.pl_ScreenGame.Location = new System.Drawing.Point(26, 25);
            this.pl_ScreenGame.Name = "pl_ScreenGame";
            this.pl_ScreenGame.Size = new System.Drawing.Size(400, 459);
            this.pl_ScreenGame.TabIndex = 0;
            // 
            // btt_exit2
            // 
            this.btt_exit2.AnimationHoverSpeed = 0.05F;
            this.btt_exit2.AnimationSpeed = 0.01F;
            this.btt_exit2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_exit2.BackgroundImage")));
            this.btt_exit2.BaseColor = System.Drawing.Color.Transparent;
            this.btt_exit2.BorderColor = System.Drawing.Color.Black;
            this.btt_exit2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_exit2.FocusedColor = System.Drawing.Color.Empty;
            this.btt_exit2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_exit2.ForeColor = System.Drawing.Color.White;
            this.btt_exit2.Image = null;
            this.btt_exit2.ImageSize = new System.Drawing.Size(62, 64);
            this.btt_exit2.Location = new System.Drawing.Point(254, 296);
            this.btt_exit2.Name = "btt_exit2";
            this.btt_exit2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_exit2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_exit2.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_exit2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_exit2.OnHoverImage")));
            this.btt_exit2.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_exit2.Size = new System.Drawing.Size(62, 64);
            this.btt_exit2.TabIndex = 6;
            this.btt_exit2.Visible = false;
            this.btt_exit2.Click += new System.EventHandler(this.btt_Exit_Click);
            // 
            // btt_replay
            // 
            this.btt_replay.AnimationHoverSpeed = 0.05F;
            this.btt_replay.AnimationSpeed = 0.01F;
            this.btt_replay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_replay.BackgroundImage")));
            this.btt_replay.BaseColor = System.Drawing.Color.Transparent;
            this.btt_replay.BorderColor = System.Drawing.Color.Black;
            this.btt_replay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_replay.FocusedColor = System.Drawing.Color.Empty;
            this.btt_replay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_replay.ForeColor = System.Drawing.Color.White;
            this.btt_replay.Image = null;
            this.btt_replay.ImageSize = new System.Drawing.Size(62, 64);
            this.btt_replay.Location = new System.Drawing.Point(76, 295);
            this.btt_replay.Name = "btt_replay";
            this.btt_replay.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_replay.OnHoverImage")));
            this.btt_replay.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_replay.Size = new System.Drawing.Size(62, 64);
            this.btt_replay.TabIndex = 6;
            this.btt_replay.Visible = false;
            this.btt_replay.Click += new System.EventHandler(this.btt_replay_Click);
            // 
            // pl_BgMenu
            // 
            this.pl_BgMenu.Controls.Add(this.btt_Back);
            this.pl_BgMenu.Controls.Add(this.btt_scene);
            this.pl_BgMenu.Controls.Add(this.btt_speed);
            this.pl_BgMenu.Controls.Add(this.btt_item);
            this.pl_BgMenu.Controls.Add(this.btt_SpeedEasy);
            this.pl_BgMenu.Controls.Add(this.btt_SpeedHard);
            this.pl_BgMenu.Controls.Add(this.btt_SpeedMedium);
            this.pl_BgMenu.Location = new System.Drawing.Point(125, 187);
            this.pl_BgMenu.Name = "pl_BgMenu";
            this.pl_BgMenu.Size = new System.Drawing.Size(150, 234);
            this.pl_BgMenu.TabIndex = 5;
            this.pl_BgMenu.Visible = false;
            // 
            // btt_SpeedEasy
            // 
            this.btt_SpeedEasy.AnimationHoverSpeed = 0.02F;
            this.btt_SpeedEasy.AnimationSpeed = 0.01F;
            this.btt_SpeedEasy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedEasy.BackgroundImage")));
            this.btt_SpeedEasy.BaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.BorderColor = System.Drawing.Color.Black;
            this.btt_SpeedEasy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_SpeedEasy.FocusedColor = System.Drawing.Color.Empty;
            this.btt_SpeedEasy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_SpeedEasy.ForeColor = System.Drawing.Color.White;
            this.btt_SpeedEasy.Image = null;
            this.btt_SpeedEasy.ImageSize = new System.Drawing.Size(140, 60);
            this.btt_SpeedEasy.Location = new System.Drawing.Point(10, 3);
            this.btt_SpeedEasy.Name = "btt_SpeedEasy";
            this.btt_SpeedEasy.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedEasy.OnHoverImage")));
            this.btt_SpeedEasy.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.Size = new System.Drawing.Size(137, 50);
            this.btt_SpeedEasy.TabIndex = 6;
            this.btt_SpeedEasy.Visible = false;
            // 
            // btt_SpeedHard
            // 
            this.btt_SpeedHard.AnimationHoverSpeed = 0.02F;
            this.btt_SpeedHard.AnimationSpeed = 0.01F;
            this.btt_SpeedHard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedHard.BackgroundImage")));
            this.btt_SpeedHard.BaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.BorderColor = System.Drawing.Color.Black;
            this.btt_SpeedHard.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_SpeedHard.FocusedColor = System.Drawing.Color.Empty;
            this.btt_SpeedHard.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_SpeedHard.ForeColor = System.Drawing.Color.White;
            this.btt_SpeedHard.Image = null;
            this.btt_SpeedHard.ImageSize = new System.Drawing.Size(150, 65);
            this.btt_SpeedHard.Location = new System.Drawing.Point(7, 126);
            this.btt_SpeedHard.Name = "btt_SpeedHard";
            this.btt_SpeedHard.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedHard.OnHoverImage")));
            this.btt_SpeedHard.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.Size = new System.Drawing.Size(143, 59);
            this.btt_SpeedHard.TabIndex = 6;
            this.btt_SpeedHard.Visible = false;
            // 
            // btt_SpeedMedium
            // 
            this.btt_SpeedMedium.AnimationHoverSpeed = 0.02F;
            this.btt_SpeedMedium.AnimationSpeed = 0.01F;
            this.btt_SpeedMedium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedMedium.BackgroundImage")));
            this.btt_SpeedMedium.BaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.BorderColor = System.Drawing.Color.Black;
            this.btt_SpeedMedium.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_SpeedMedium.FocusedColor = System.Drawing.Color.Empty;
            this.btt_SpeedMedium.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_SpeedMedium.ForeColor = System.Drawing.Color.White;
            this.btt_SpeedMedium.Image = null;
            this.btt_SpeedMedium.ImageSize = new System.Drawing.Size(158, 75);
            this.btt_SpeedMedium.Location = new System.Drawing.Point(7, 59);
            this.btt_SpeedMedium.Name = "btt_SpeedMedium";
            this.btt_SpeedMedium.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedMedium.OnHoverImage")));
            this.btt_SpeedMedium.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.OnPressedDepth = 100;
            this.btt_SpeedMedium.Size = new System.Drawing.Size(140, 63);
            this.btt_SpeedMedium.TabIndex = 6;
            this.btt_SpeedMedium.Visible = false;
            // 
            // btt_Exit
            // 
            this.btt_Exit.AnimationHoverSpeed = 0.03F;
            this.btt_Exit.AnimationSpeed = 0.01F;
            this.btt_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_Exit.BackgroundImage")));
            this.btt_Exit.BaseColor = System.Drawing.Color.Transparent;
            this.btt_Exit.BorderColor = System.Drawing.Color.Black;
            this.btt_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Exit.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Exit.ForeColor = System.Drawing.Color.White;
            this.btt_Exit.Image = null;
            this.btt_Exit.ImageSize = new System.Drawing.Size(133, 68);
            this.btt_Exit.Location = new System.Drawing.Point(219, 295);
            this.btt_Exit.Name = "btt_Exit";
            this.btt_Exit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_Exit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_Exit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_Exit.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_Exit.OnHoverImage")));
            this.btt_Exit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_Exit.Size = new System.Drawing.Size(130, 65);
            this.btt_Exit.TabIndex = 4;
            this.btt_Exit.Click += new System.EventHandler(this.btt_Exit_Click);
            // 
            // btt_Menu
            // 
            this.btt_Menu.AnimationHoverSpeed = 0.05F;
            this.btt_Menu.AnimationSpeed = 0.01F;
            this.btt_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_Menu.BackgroundImage")));
            this.btt_Menu.BaseColor = System.Drawing.Color.Transparent;
            this.btt_Menu.BorderColor = System.Drawing.Color.Black;
            this.btt_Menu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Menu.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Menu.ForeColor = System.Drawing.Color.White;
            this.btt_Menu.Image = null;
            this.btt_Menu.ImageSize = new System.Drawing.Size(133, 68);
            this.btt_Menu.Location = new System.Drawing.Point(41, 295);
            this.btt_Menu.Name = "btt_Menu";
            this.btt_Menu.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_Menu.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_Menu.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_Menu.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_Menu.OnHoverImage")));
            this.btt_Menu.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_Menu.Size = new System.Drawing.Size(130, 65);
            this.btt_Menu.TabIndex = 3;
            this.btt_Menu.Click += new System.EventHandler(this.btt_Menu_Click);
            // 
            // btt_Play
            // 
            this.btt_Play.AnimationHoverSpeed = 0.05F;
            this.btt_Play.AnimationSpeed = 0.01F;
            this.btt_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_Play.BackgroundImage")));
            this.btt_Play.BaseColor = System.Drawing.Color.Transparent;
            this.btt_Play.BorderColor = System.Drawing.Color.Black;
            this.btt_Play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Play.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Play.ForeColor = System.Drawing.Color.White;
            this.btt_Play.Image = null;
            this.btt_Play.ImageSize = new System.Drawing.Size(160, 70);
            this.btt_Play.Location = new System.Drawing.Point(123, 200);
            this.btt_Play.Name = "btt_Play";
            this.btt_Play.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_Play.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_Play.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_Play.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_Play.OnHoverImage")));
            this.btt_Play.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_Play.Size = new System.Drawing.Size(153, 67);
            this.btt_Play.TabIndex = 1;
            this.btt_Play.Click += new System.EventHandler(this.btt_Play_Click);
            // 
            // pB_IntroBird
            // 
            this.pB_IntroBird.Image = ((System.Drawing.Image)(resources.GetObject("pB_IntroBird.Image")));
            this.pB_IntroBird.Location = new System.Drawing.Point(153, 78);
            this.pB_IntroBird.Name = "pB_IntroBird";
            this.pB_IntroBird.Size = new System.Drawing.Size(94, 77);
            this.pB_IntroBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_IntroBird.TabIndex = 2;
            this.pB_IntroBird.TabStop = false;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 8;
            this.gunaElipse2.TargetControl = this.pl_ScreenGame;
            // 
            // pB_title
            // 
            this.pB_title.Image = ((System.Drawing.Image)(resources.GetObject("pB_title.Image")));
            this.pB_title.Location = new System.Drawing.Point(446, 50);
            this.pB_title.Name = "pB_title";
            this.pB_title.Size = new System.Drawing.Size(242, 76);
            this.pB_title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_title.TabIndex = 1;
            this.pB_title.TabStop = false;
            // 
            // pB_Player
            // 
            this.pB_Player.BackColor = System.Drawing.Color.NavajoWhite;
            this.pB_Player.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pB_Player.Image = ((System.Drawing.Image)(resources.GetObject("pB_Player.Image")));
            this.pB_Player.Location = new System.Drawing.Point(519, 135);
            this.pB_Player.Name = "pB_Player";
            this.pB_Player.Size = new System.Drawing.Size(100, 100);
            this.pB_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_Player.TabIndex = 2;
            this.pB_Player.TabStop = false;
            // 
            // tB_playerName
            // 
            this.tB_playerName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tB_playerName.Location = new System.Drawing.Point(490, 241);
            this.tB_playerName.Name = "tB_playerName";
            this.tB_playerName.Size = new System.Drawing.Size(152, 20);
            this.tB_playerName.TabIndex = 3;
            this.tB_playerName.TabStop = false;
            this.tB_playerName.Text = "Player1";
            this.tB_playerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "HIGH SCORE";
            // 
            // pB_playerHighSorce
            // 
            this.pB_playerHighSorce.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pB_playerHighSorce.Image = ((System.Drawing.Image)(resources.GetObject("pB_playerHighSorce.Image")));
            this.pB_playerHighSorce.Location = new System.Drawing.Point(494, 391);
            this.pB_playerHighSorce.Name = "pB_playerHighSorce";
            this.pB_playerHighSorce.Size = new System.Drawing.Size(55, 55);
            this.pB_playerHighSorce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_playerHighSorce.TabIndex = 5;
            this.pB_playerHighSorce.TabStop = false;
            // 
            // lB_playerHighScore
            // 
            this.lB_playerHighScore.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lB_playerHighScore.Location = new System.Drawing.Point(478, 459);
            this.lB_playerHighScore.Name = "lB_playerHighScore";
            this.lB_playerHighScore.Size = new System.Drawing.Size(87, 25);
            this.lB_playerHighScore.TabIndex = 6;
            this.lB_playerHighScore.Text = "player1";
            this.lB_playerHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_highscore
            // 
            this.lb_highscore.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_highscore.Location = new System.Drawing.Point(555, 408);
            this.lb_highscore.Name = "lb_highscore";
            this.lb_highscore.Size = new System.Drawing.Size(87, 25);
            this.lb_highscore.TabIndex = 6;
            this.lb_highscore.Text = "10";
            this.lb_highscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btt_scene
            // 
            this.btt_scene.AnimationHoverSpeed = 0.05F;
            this.btt_scene.AnimationSpeed = 0.01F;
            this.btt_scene.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_scene.BackgroundImage")));
            this.btt_scene.BaseColor = System.Drawing.Color.Transparent;
            this.btt_scene.BorderColor = System.Drawing.Color.Black;
            this.btt_scene.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_scene.FocusedColor = System.Drawing.Color.Empty;
            this.btt_scene.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_scene.ForeColor = System.Drawing.Color.White;
            this.btt_scene.Image = null;
            this.btt_scene.ImageSize = new System.Drawing.Size(133, 68);
            this.btt_scene.Location = new System.Drawing.Point(10, 3);
            this.btt_scene.Name = "btt_scene";
            this.btt_scene.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_scene.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_scene.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_scene.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_scene.OnHoverImage")));
            this.btt_scene.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_scene.Size = new System.Drawing.Size(130, 65);
            this.btt_scene.TabIndex = 7;
            this.btt_scene.Visible = false;
            // 
            // btt_item
            // 
            this.btt_item.AnimationHoverSpeed = 0.05F;
            this.btt_item.AnimationSpeed = 0.01F;
            this.btt_item.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_item.BackgroundImage")));
            this.btt_item.BaseColor = System.Drawing.Color.Transparent;
            this.btt_item.BorderColor = System.Drawing.Color.Black;
            this.btt_item.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_item.FocusedColor = System.Drawing.Color.Empty;
            this.btt_item.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_item.ForeColor = System.Drawing.Color.White;
            this.btt_item.Image = null;
            this.btt_item.ImageSize = new System.Drawing.Size(133, 68);
            this.btt_item.Location = new System.Drawing.Point(10, 65);
            this.btt_item.Name = "btt_item";
            this.btt_item.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_item.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_item.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_item.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_item.OnHoverImage")));
            this.btt_item.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_item.Size = new System.Drawing.Size(130, 65);
            this.btt_item.TabIndex = 7;
            // 
            // btt_speed
            // 
            this.btt_speed.AnimationHoverSpeed = 0.05F;
            this.btt_speed.AnimationSpeed = 0.01F;
            this.btt_speed.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_speed.BackgroundImage")));
            this.btt_speed.BaseColor = System.Drawing.Color.Transparent;
            this.btt_speed.BorderColor = System.Drawing.Color.Black;
            this.btt_speed.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_speed.FocusedColor = System.Drawing.Color.Empty;
            this.btt_speed.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_speed.ForeColor = System.Drawing.Color.White;
            this.btt_speed.Image = null;
            this.btt_speed.ImageSize = new System.Drawing.Size(133, 68);
            this.btt_speed.Location = new System.Drawing.Point(10, 128);
            this.btt_speed.Name = "btt_speed";
            this.btt_speed.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_speed.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_speed.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_speed.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_speed.OnHoverImage")));
            this.btt_speed.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_speed.Size = new System.Drawing.Size(130, 70);
            this.btt_speed.TabIndex = 7;
            this.btt_speed.Visible = false;
            this.btt_speed.Click += new System.EventHandler(this.btt_speed_Click);
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
            this.btt_exit3.Location = new System.Drawing.Point(571, 277);
            this.btt_exit3.Name = "btt_exit3";
            this.btt_exit3.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_exit3.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_exit3.OnHoverImage")));
            this.btt_exit3.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_exit3.Size = new System.Drawing.Size(62, 63);
            this.btt_exit3.TabIndex = 7;
            this.btt_exit3.Click += new System.EventHandler(this.btt_Exit_Click);
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
            this.btt_sound.Location = new System.Drawing.Point(503, 277);
            this.btt_sound.Name = "btt_sound";
            this.btt_sound.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_sound.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_sound.OnHoverImage")));
            this.btt_sound.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_sound.Size = new System.Drawing.Size(62, 63);
            this.btt_sound.TabIndex = 7;
            this.btt_sound.Click += new System.EventHandler(this.btt_Exit_Click);
            // 
            // pB_GameOver
            // 
            this.pB_GameOver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pB_GameOver.BackgroundImage")));
            this.pB_GameOver.Location = new System.Drawing.Point(19, 38);
            this.pB_GameOver.Name = "pB_GameOver";
            this.pB_GameOver.Size = new System.Drawing.Size(363, 156);
            this.pB_GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_GameOver.TabIndex = 7;
            this.pB_GameOver.TabStop = false;
            this.pB_GameOver.Visible = false;
            // 
            // btt_Back
            // 
            this.btt_Back.AnimationHoverSpeed = 0.05F;
            this.btt_Back.AnimationSpeed = 0.01F;
            this.btt_Back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_Back.BackgroundImage")));
            this.btt_Back.BaseColor = System.Drawing.Color.Transparent;
            this.btt_Back.BorderColor = System.Drawing.Color.Black;
            this.btt_Back.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Back.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Back.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Back.ForeColor = System.Drawing.Color.White;
            this.btt_Back.Image = null;
            this.btt_Back.ImageSize = new System.Drawing.Size(29, 20);
            this.btt_Back.Location = new System.Drawing.Point(3, 196);
            this.btt_Back.Name = "btt_Back";
            this.btt_Back.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_Back.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_Back.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_Back.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_Back.OnHoverImage")));
            this.btt_Back.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_Back.Size = new System.Drawing.Size(29, 20);
            this.btt_Back.TabIndex = 8;
            this.btt_Back.Click += new System.EventHandler(this.btt_Back_Click);
            // 
            // BackgroundGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.btt_sound);
            this.Controls.Add(this.btt_exit3);
            this.Controls.Add(this.lb_highscore);
            this.Controls.Add(this.lB_playerHighScore);
            this.Controls.Add(this.pB_playerHighSorce);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tB_playerName);
            this.Controls.Add(this.pB_Player);
            this.Controls.Add(this.pB_title);
            this.Controls.Add(this.pl_ScreenGame);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackgroundGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.BackgroundGame_Load);
            this.Click += new System.EventHandler(this.BackgroundGame_Click);
            this.pl_ScreenGame.ResumeLayout(false);
            this.pl_BgMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pB_IntroBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_playerHighSorce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_GameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.Panel pl_ScreenGame;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaCircleButton btt_Play;
        private System.Windows.Forms.PictureBox pB_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_playerName;
        private System.Windows.Forms.PictureBox pB_Player;
        private System.Windows.Forms.PictureBox pB_IntroBird;
        private System.Windows.Forms.Label lb_highscore;
        private System.Windows.Forms.Label lB_playerHighScore;
        private System.Windows.Forms.PictureBox pB_playerHighSorce;
        private Guna.UI.WinForms.GunaCircleButton btt_Menu;
        private Guna.UI.WinForms.GunaCircleButton btt_Exit;
        private Guna.UI.WinForms.GunaCircleButton btt_SpeedEasy;
        private System.Windows.Forms.Panel pl_BgMenu;
        private Guna.UI.WinForms.GunaCircleButton btt_SpeedHard;
        private Guna.UI.WinForms.GunaCircleButton btt_SpeedMedium;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaCircleButton btt_replay;
        private Guna.UI.WinForms.GunaCircleButton btt_exit2;
        private Guna.UI.WinForms.GunaCircleButton btt_scene;
        private Guna.UI.WinForms.GunaCircleButton btt_speed;
        private Guna.UI.WinForms.GunaCircleButton btt_item;
        private Guna.UI.WinForms.GunaCircleButton btt_exit3;
        private Guna.UI.WinForms.GunaCircleButton btt_sound;
        private Guna.UI.WinForms.GunaCircleButton btt_Back;
        private System.Windows.Forms.PictureBox pB_GameOver;

    }
}

