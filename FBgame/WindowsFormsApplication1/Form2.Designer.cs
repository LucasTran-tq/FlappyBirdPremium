namespace WindowsFormsApplication1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btt_Play = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_exit2 = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_replay = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_Exit = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_Menu = new Guna.UI.WinForms.GunaCircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pB_IntroBird = new System.Windows.Forms.PictureBox();
            this.pl_BgMenu = new System.Windows.Forms.Panel();
            this.rebirdPictureBox = new System.Windows.Forms.PictureBox();
            this.choose_lb = new System.Windows.Forms.Label();
            this.blbirdPictureBox = new System.Windows.Forms.PictureBox();
            this.yebirdPictureBox = new System.Windows.Forms.PictureBox();
            this.btt_Back = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_scene = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_speed = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_item = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_SpeedEasy = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_SpeedHard = new Guna.UI.WinForms.GunaCircleButton();
            this.btt_SpeedMedium = new Guna.UI.WinForms.GunaCircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB_IntroBird)).BeginInit();
            this.pl_BgMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rebirdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blbirdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yebirdPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 8;
            this.gunaElipse1.TargetControl = this;
            // 
            // btt_Play
            // 
            this.btt_Play.AnimationHoverSpeed = 0.05F;
            this.btt_Play.AnimationSpeed = 0.01F;
            this.btt_Play.BackColor = System.Drawing.Color.Transparent;
            this.btt_Play.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_Play.BackgroundImage")));
            this.btt_Play.BaseColor = System.Drawing.Color.Transparent;
            this.btt_Play.BorderColor = System.Drawing.Color.Black;
            this.btt_Play.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Play.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Play.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Play.ForeColor = System.Drawing.Color.White;
            this.btt_Play.Image = null;
            this.btt_Play.ImageSize = new System.Drawing.Size(160, 70);
            this.btt_Play.Location = new System.Drawing.Point(186, 346);
            this.btt_Play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_Play.Name = "btt_Play";
            this.btt_Play.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_Play.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_Play.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_Play.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_Play.OnHoverImage")));
            this.btt_Play.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_Play.Size = new System.Drawing.Size(230, 103);
            this.btt_Play.TabIndex = 2;
            this.btt_Play.Click += new System.EventHandler(this.btt_Play_Click);
            // 
            // btt_exit2
            // 
            this.btt_exit2.AnimationHoverSpeed = 0.05F;
            this.btt_exit2.AnimationSpeed = 0.01F;
            this.btt_exit2.BackColor = System.Drawing.Color.Transparent;
            this.btt_exit2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_exit2.BackgroundImage")));
            this.btt_exit2.BaseColor = System.Drawing.Color.Transparent;
            this.btt_exit2.BorderColor = System.Drawing.Color.Black;
            this.btt_exit2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_exit2.FocusedColor = System.Drawing.Color.Empty;
            this.btt_exit2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_exit2.ForeColor = System.Drawing.Color.White;
            this.btt_exit2.Image = null;
            this.btt_exit2.ImageSize = new System.Drawing.Size(62, 64);
            this.btt_exit2.Location = new System.Drawing.Point(387, 460);
            this.btt_exit2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_exit2.Name = "btt_exit2";
            this.btt_exit2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_exit2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_exit2.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_exit2.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_exit2.OnHoverImage")));
            this.btt_exit2.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_exit2.Size = new System.Drawing.Size(93, 98);
            this.btt_exit2.TabIndex = 9;
            this.btt_exit2.Visible = false;
            this.btt_exit2.Click += new System.EventHandler(this.btt_exit2_Click);
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
            this.btt_replay.Location = new System.Drawing.Point(120, 458);
            this.btt_replay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_replay.Name = "btt_replay";
            this.btt_replay.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_replay.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_replay.OnHoverImage")));
            this.btt_replay.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_replay.Size = new System.Drawing.Size(93, 98);
            this.btt_replay.TabIndex = 10;
            this.btt_replay.Visible = false;
            // 
            // btt_Exit
            // 
            this.btt_Exit.AnimationHoverSpeed = 0.03F;
            this.btt_Exit.AnimationSpeed = 0.01F;
            this.btt_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btt_Exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_Exit.BackgroundImage")));
            this.btt_Exit.BaseColor = System.Drawing.Color.Transparent;
            this.btt_Exit.BorderColor = System.Drawing.Color.Black;
            this.btt_Exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Exit.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Exit.ForeColor = System.Drawing.Color.White;
            this.btt_Exit.Image = null;
            this.btt_Exit.ImageSize = new System.Drawing.Size(133, 68);
            this.btt_Exit.Location = new System.Drawing.Point(334, 458);
            this.btt_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_Exit.Name = "btt_Exit";
            this.btt_Exit.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_Exit.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_Exit.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_Exit.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_Exit.OnHoverImage")));
            this.btt_Exit.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_Exit.Size = new System.Drawing.Size(195, 100);
            this.btt_Exit.TabIndex = 8;
            this.btt_Exit.Click += new System.EventHandler(this.btt_exit2_Click);
            // 
            // btt_Menu
            // 
            this.btt_Menu.AnimationHoverSpeed = 0.05F;
            this.btt_Menu.AnimationSpeed = 0.01F;
            this.btt_Menu.BackColor = System.Drawing.Color.Transparent;
            this.btt_Menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btt_Menu.BackgroundImage")));
            this.btt_Menu.BaseColor = System.Drawing.Color.Transparent;
            this.btt_Menu.BorderColor = System.Drawing.Color.Black;
            this.btt_Menu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btt_Menu.FocusedColor = System.Drawing.Color.Empty;
            this.btt_Menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btt_Menu.ForeColor = System.Drawing.Color.White;
            this.btt_Menu.Image = null;
            this.btt_Menu.ImageSize = new System.Drawing.Size(133, 68);
            this.btt_Menu.Location = new System.Drawing.Point(68, 458);
            this.btt_Menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_Menu.Name = "btt_Menu";
            this.btt_Menu.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_Menu.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_Menu.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_Menu.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_Menu.OnHoverImage")));
            this.btt_Menu.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_Menu.Size = new System.Drawing.Size(195, 100);
            this.btt_Menu.TabIndex = 7;
            this.btt_Menu.Click += new System.EventHandler(this.btt_Menu_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pB_IntroBird
            // 
            this.pB_IntroBird.BackColor = System.Drawing.Color.Transparent;
            this.pB_IntroBird.Image = ((System.Drawing.Image)(resources.GetObject("pB_IntroBird.Image")));
            this.pB_IntroBird.Location = new System.Drawing.Point(230, 112);
            this.pB_IntroBird.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pB_IntroBird.Name = "pB_IntroBird";
            this.pB_IntroBird.Size = new System.Drawing.Size(141, 118);
            this.pB_IntroBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pB_IntroBird.TabIndex = 11;
            this.pB_IntroBird.TabStop = false;
            // 
            // pl_BgMenu
            // 
            this.pl_BgMenu.BackColor = System.Drawing.Color.Transparent;
            this.pl_BgMenu.Controls.Add(this.rebirdPictureBox);
            this.pl_BgMenu.Controls.Add(this.choose_lb);
            this.pl_BgMenu.Controls.Add(this.blbirdPictureBox);
            this.pl_BgMenu.Controls.Add(this.yebirdPictureBox);
            this.pl_BgMenu.Controls.Add(this.btt_Back);
            this.pl_BgMenu.Controls.Add(this.btt_scene);
            this.pl_BgMenu.Controls.Add(this.btt_speed);
            this.pl_BgMenu.Controls.Add(this.btt_item);
            this.pl_BgMenu.Controls.Add(this.btt_SpeedEasy);
            this.pl_BgMenu.Controls.Add(this.btt_SpeedHard);
            this.pl_BgMenu.Controls.Add(this.btt_SpeedMedium);
            this.pl_BgMenu.Location = new System.Drawing.Point(190, 297);
            this.pl_BgMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pl_BgMenu.Name = "pl_BgMenu";
            this.pl_BgMenu.Size = new System.Drawing.Size(237, 360);
            this.pl_BgMenu.TabIndex = 12;
            this.pl_BgMenu.Visible = false;
            // 
            // rebirdPictureBox
            // 
            this.rebirdPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.rebirdPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.rebirdPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rebirdPictureBox.Image")));
            this.rebirdPictureBox.Location = new System.Drawing.Point(81, 229);
            this.rebirdPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rebirdPictureBox.Name = "rebirdPictureBox";
            this.rebirdPictureBox.Size = new System.Drawing.Size(80, 55);
            this.rebirdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rebirdPictureBox.TabIndex = 19;
            this.rebirdPictureBox.TabStop = false;
            this.rebirdPictureBox.Visible = false;
            this.rebirdPictureBox.Click += new System.EventHandler(this.rebirdPictureBox_Click);
            // 
            // choose_lb
            // 
            this.choose_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choose_lb.Location = new System.Drawing.Point(34, 34);
            this.choose_lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.choose_lb.Name = "choose_lb";
            this.choose_lb.Size = new System.Drawing.Size(195, 37);
            this.choose_lb.TabIndex = 15;
            this.choose_lb.Text = "CHOOSE ONE";
            this.choose_lb.Visible = false;
            // 
            // blbirdPictureBox
            // 
            this.blbirdPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.blbirdPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.blbirdPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("blbirdPictureBox.Image")));
            this.blbirdPictureBox.Location = new System.Drawing.Point(81, 162);
            this.blbirdPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blbirdPictureBox.Name = "blbirdPictureBox";
            this.blbirdPictureBox.Size = new System.Drawing.Size(80, 58);
            this.blbirdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blbirdPictureBox.TabIndex = 18;
            this.blbirdPictureBox.TabStop = false;
            this.blbirdPictureBox.Visible = false;
            this.blbirdPictureBox.Click += new System.EventHandler(this.blbirdPictureBox_Click);
            // 
            // yebirdPictureBox
            // 
            this.yebirdPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.yebirdPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.yebirdPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("yebirdPictureBox.Image")));
            this.yebirdPictureBox.Location = new System.Drawing.Point(81, 91);
            this.yebirdPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yebirdPictureBox.Name = "yebirdPictureBox";
            this.yebirdPictureBox.Size = new System.Drawing.Size(80, 60);
            this.yebirdPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yebirdPictureBox.TabIndex = 17;
            this.yebirdPictureBox.TabStop = false;
            this.yebirdPictureBox.Visible = false;
            this.yebirdPictureBox.Click += new System.EventHandler(this.yebirdPictureBox_Click);
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
            this.btt_Back.Location = new System.Drawing.Point(4, 314);
            this.btt_Back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_Back.Name = "btt_Back";
            this.btt_Back.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_Back.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_Back.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_Back.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_Back.OnHoverImage")));
            this.btt_Back.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_Back.Size = new System.Drawing.Size(44, 31);
            this.btt_Back.TabIndex = 8;
            this.btt_Back.Click += new System.EventHandler(this.btt_Back_Click);
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
            this.btt_scene.Location = new System.Drawing.Point(15, 0);
            this.btt_scene.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_scene.Name = "btt_scene";
            this.btt_scene.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_scene.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_scene.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_scene.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_scene.OnHoverImage")));
            this.btt_scene.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_scene.Size = new System.Drawing.Size(195, 100);
            this.btt_scene.TabIndex = 7;
            this.btt_scene.Visible = false;
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
            this.btt_speed.Location = new System.Drawing.Point(15, 197);
            this.btt_speed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_speed.Name = "btt_speed";
            this.btt_speed.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_speed.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_speed.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_speed.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_speed.OnHoverImage")));
            this.btt_speed.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_speed.Size = new System.Drawing.Size(195, 108);
            this.btt_speed.TabIndex = 7;
            this.btt_speed.Visible = false;
            this.btt_speed.Click += new System.EventHandler(this.btt_speed_Click);
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
            this.btt_item.Location = new System.Drawing.Point(15, 100);
            this.btt_item.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_item.Name = "btt_item";
            this.btt_item.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_item.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_item.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_item.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_item.OnHoverImage")));
            this.btt_item.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_item.Size = new System.Drawing.Size(195, 100);
            this.btt_item.TabIndex = 7;
            this.btt_item.Click += new System.EventHandler(this.btt_item_Click);
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
            this.btt_SpeedEasy.Location = new System.Drawing.Point(15, 5);
            this.btt_SpeedEasy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_SpeedEasy.Name = "btt_SpeedEasy";
            this.btt_SpeedEasy.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedEasy.OnHoverImage")));
            this.btt_SpeedEasy.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_SpeedEasy.Size = new System.Drawing.Size(206, 77);
            this.btt_SpeedEasy.TabIndex = 6;
            this.btt_SpeedEasy.Visible = false;
            this.btt_SpeedEasy.Click += new System.EventHandler(this.btt_SpeedEasy_Click);
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
            this.btt_SpeedHard.Location = new System.Drawing.Point(10, 194);
            this.btt_SpeedHard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_SpeedHard.Name = "btt_SpeedHard";
            this.btt_SpeedHard.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedHard.OnHoverImage")));
            this.btt_SpeedHard.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_SpeedHard.Size = new System.Drawing.Size(214, 91);
            this.btt_SpeedHard.TabIndex = 6;
            this.btt_SpeedHard.Visible = false;
            this.btt_SpeedHard.Click += new System.EventHandler(this.btt_SpeedHard_Click);
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
            this.btt_SpeedMedium.Location = new System.Drawing.Point(10, 91);
            this.btt_SpeedMedium.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btt_SpeedMedium.Name = "btt_SpeedMedium";
            this.btt_SpeedMedium.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.OnHoverForeColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.OnHoverImage = ((System.Drawing.Image)(resources.GetObject("btt_SpeedMedium.OnHoverImage")));
            this.btt_SpeedMedium.OnPressedColor = System.Drawing.Color.Transparent;
            this.btt_SpeedMedium.OnPressedDepth = 100;
            this.btt_SpeedMedium.Size = new System.Drawing.Size(210, 97);
            this.btt_SpeedMedium.TabIndex = 6;
            this.btt_SpeedMedium.Visible = false;
            this.btt_SpeedMedium.Click += new System.EventHandler(this.btt_SpeedMedium_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("STCaiyun", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(255, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 47);
            this.label1.TabIndex = 13;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 6;
            this.gunaElipse2.TargetControl = this.label1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(725, 753);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Salmon;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(454, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 839);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pl_BgMenu);
            this.Controls.Add(this.pB_IntroBird);
            this.Controls.Add(this.btt_exit2);
            this.Controls.Add(this.btt_replay);
            this.Controls.Add(this.btt_Exit);
            this.Controls.Add(this.btt_Menu);
            this.Controls.Add(this.btt_Play);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pB_IntroBird)).EndInit();
            this.pl_BgMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rebirdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blbirdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yebirdPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaCircleButton btt_Play;
        private Guna.UI.WinForms.GunaCircleButton btt_exit2;
        private Guna.UI.WinForms.GunaCircleButton btt_replay;
        private Guna.UI.WinForms.GunaCircleButton btt_Exit;
        private Guna.UI.WinForms.GunaCircleButton btt_Menu;
        private System.Windows.Forms.PictureBox pB_IntroBird;
        private System.Windows.Forms.Panel pl_BgMenu;
        private Guna.UI.WinForms.GunaCircleButton btt_Back;
        private Guna.UI.WinForms.GunaCircleButton btt_scene;
        private Guna.UI.WinForms.GunaCircleButton btt_speed;
        private Guna.UI.WinForms.GunaCircleButton btt_item;
        private Guna.UI.WinForms.GunaCircleButton btt_SpeedEasy;
        private Guna.UI.WinForms.GunaCircleButton btt_SpeedHard;
        private Guna.UI.WinForms.GunaCircleButton btt_SpeedMedium;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox rebirdPictureBox;
        private System.Windows.Forms.Label choose_lb;
        private System.Windows.Forms.PictureBox blbirdPictureBox;
        private System.Windows.Forms.PictureBox yebirdPictureBox;
        public System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button1;
    }
}