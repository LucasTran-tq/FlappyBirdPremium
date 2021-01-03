using System;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Media;



namespace WindowsFormsApplication1
{ 
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


         
        CtrlGame ctrg = new CtrlGame();
        Pipe pipe = new Pipe();
        Coins coins = new Coins();
        HighScoreInfo highScore = new HighScoreInfo();
        int iChooseBG = 1;

        int iSpeed = 1;
        Rocket rocket = new Rocket();
        Gift gift = new Gift();
        Bird bird = new Bird();

        Heart heart = new Heart();
        LifeSpan lifeSpan = new LifeSpan();

        Timer timer_Bird = new Timer();

        Timer timer2 = new Timer();

        int speedOfGame;
        private void Form2_Load(object sender, EventArgs e)
        {

            

            // add coins
            this.Controls.Add(coins.picBoxCoins);

            // add heart
            this.Controls.Add(heart.picBoxHearts);


            //// add rocket
            
            this.Controls.Add(rocket.picBoxEmergency);
            this.Controls.Add(rocket.picBoxFire);

            // add gift
            this.Controls.Add(gift.picBoxGift);
            this.Controls.Add(gift.picBoxThunder);


            pipe.DrawPipe(this, pipe);
            ////items.DrawCoins();


            timer_Bird.Interval = 25;
            timer_Bird.Tick += Timer_Bird_Tick;

            timer2.Interval = 70;
            timer2.Tick += Timer2_Tick;

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            /////////////////////// NEW VERSION////

            // draw pipe
            if (pipe.pipe_Above1_Appearance)
            {
                pipe.Draw_Pipe_Above_1(e.Graphics);
            }
            if (pipe.pipe_Bottom1_Appearance)
            {
                pipe.Draw_Pipe_Bottom_1(e.Graphics);
            }
            if (pipe.pipe_Above2_Appearance)
            {
                pipe.Draw_Pipe_Above_2(e.Graphics);
            }
            if (pipe.pipe_Bottom2_Appearance)
            {
                pipe.Draw_Pipe_Bottom_2(e.Graphics);
            }

            // draw rocket
            if (rocket.rocket_Apearance)
            {
                rocket.Draw_Rocket(e.Graphics);
            }

            // draw bird
            if (bird.bird_Appearance)
            {
                bird.Draw(e.Graphics);

            }

            // life_span
            if (lifeSpan.life_Span1_Appearance)
            {
                lifeSpan.Draw_Heart_1(e.Graphics);

            }

            if (lifeSpan.life_Span2_Appearance)
            {
                lifeSpan.Draw_Heart_2(e.Graphics);

            }

            if (lifeSpan.life_Span3_Appearance)
            {
                lifeSpan.Draw_Heart_3(e.Graphics);

            }

            // draw shield
            if (lifeSpan.shield_Apearance)
            {
                lifeSpan.Draw_Shield(e.Graphics);
            }
        }


        private void Timer_Bird_Tick(object sender, EventArgs e)
        {
         
            bird.Impact_Bird_pipe(this, pipe, rocket, gift, lifeSpan, timer1, timer2, ctrg, ga);
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            /////////////////////// NEW VERSION////
            ///

            //pipe
            if (iSpeed == 1)
            {
                speedOfGame = 5;

                pipe.PipeInGame(this, pipe, bird, speedOfGame);
                rocket.RocketInGame(bird, speedOfGame);
                gift.GiftInGame(bird,speedOfGame);
                heart.HeartsInGame(bird, speedOfGame);
                coins.CoinsInGame(bird, speedOfGame);
            }
               
            else if (iSpeed == 2)
            {
                speedOfGame = 7;

                pipe.PipeInGame(this, pipe, bird, speedOfGame);
                rocket.RocketInGame(bird, speedOfGame);
                gift.GiftInGame(bird, speedOfGame);
                heart.HeartsInGame(bird, speedOfGame);
                coins.CoinsInGame(bird, speedOfGame);
            }
                
            else if (iSpeed == 3)
            {
                speedOfGame = 10;

                pipe.PipeInGame(this, pipe, bird, speedOfGame);
                rocket.RocketInGame(bird, speedOfGame);
                gift.GiftInGame(bird, speedOfGame);
                heart.HeartsInGame(bird, speedOfGame);
                coins.CoinsInGame(bird, speedOfGame);
            }
                

            //// coins
            coins.GetCoins(this, bird, pipe);
            
            coins.Impact_Coins_Bird(bird);

            //// hearts
            heart.GetHearts(this, bird, pipe);
            
            heart.Impact_Hearts_Bird(bird);


            /// lifespan
            lifeSpan.DrawLifeSpan();

            if (heart.sign_getHearts)
            {
                lifeSpan.Increase(heart);
                //heart.sign_getHearts = false;
            }

            // shield character
            if (lifeSpan.GetCount() == 1)
            {
                lifeSpan.shield_Apearance = false;
            }

            if (lifeSpan.GetCount() > 1)
            {
                lifeSpan.SetVisibleOn(bird);
            }

            lifeSpan.Impact_Shield_Rocket(rocket, bird);
            lifeSpan.Impact_Shield_Pipes(pipe, bird, heart);
            if (heart.sign_decreaseHearts)
            {
                lifeSpan.Decrease(heart);
            }

            // rocket
            rocket.GetRocket(this, bird, pipe);
            
            rocket.Impact_Rocket_Bird(bird, gift, lifeSpan, timer_Bird, timer1);
            rocket.InvisibleEmergency(this);

            //Gift
            gift.GetGift(this, pipe);
            
            gift.Impact_Gift_Bird(bird, timer1, timer_Bird, timer2);

            Invalidate();
            // bird
            bird.GetScore(pipe, label1);
            highScore.HighScore();
           
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            gift.count_Flash++;
        }


        private void btt_Menu_Click(object sender, EventArgs e)
        {
            ctrg.MainScreenOff(btt_Play, btt_Menu, pB_IntroBird);
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
        }

        private void btt_Play_Click(object sender, EventArgs e)
        {
            ctrg.MainScreenOff(btt_Play, btt_Menu, pB_IntroBird);

            bird.bird_Appearance = true;

            ctrg.SoundStartGame();

            timer1.Start();

            timer_Bird.Start();

            label1.Visible = true;
           
        }


        private void btt_speed_Click(object sender, EventArgs e)
        {
            ctrg.MenuOff(btt_scene, btt_speed, btt_item, btt_Back);
            ctrg.SubMenuOn(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium);
        }

        private void btt_Back_Click(object sender, EventArgs e)
        {
            if (ctrg.Check(btt_item, rebirdPictureBox) == 1)
            {
                ctrg.MainScreenOn(btt_Play, btt_Menu);
                ctrg.SubMenuOff(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium);
                ctrg.MenuOff(btt_scene, btt_speed, btt_item, btt_Back);
                pl_BgMenu.Visible = false;
            }
            else
            {
                
                ctrg.SubMenuOff(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium);
                pl_BgMenu.Visible = true;
                ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
            }                
        }

        private void btt_SpeedHard_Click(object sender, EventArgs e)
        {
            iSpeed = 3;

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);

            ctrg.SubMenuOff(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium);
        }

        private void btt_SpeedEasy_Click(object sender, EventArgs e)
        {
            iSpeed = 1;

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);

            ctrg.SubMenuOff(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium);
        }

        private void btt_SpeedMedium_Click(object sender, EventArgs e)
        {
            iSpeed = 2;

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);

            ctrg.SubMenuOff(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                if (bird.isAlive)
                {
                    bird.Move_Bird_Up();
                }
                
            }

            if (e.KeyCode == Keys.Space)
                e.Handled = true;
         
        }

        private void btt_item_Click(object sender, EventArgs e)
        {
            ctrg.MenuOff(btt_scene, btt_speed, btt_item, btt_Back);
            ctrg.SubMenuOn(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox);
           
        }

        private void yebirdPictureBox_Click(object sender, EventArgs e)
        {
            bird.index_bird = 1;

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
            ctrg.SubMenuOff(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox);
          
        }

        private void blbirdPictureBox_Click(object sender, EventArgs e)
        {
            bird.index_bird = 2;

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
            ctrg.SubMenuOff(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox);
            
        }

        private void rebirdPictureBox_Click(object sender, EventArgs e)
        {
            bird.index_bird = 3;

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
            ctrg.SubMenuOff(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox);
            
        }

        private void btt_scene_Click(object sender, EventArgs e)
        {
            ctrg.MenuOff(btt_scene, btt_speed, btt_item, btt_Back);
            ctrg.SubMenuOn(btt_scenceChrist, btt_scenceHallow, btt_scenceOrigin);
        }

      //  Form1 F = new Form1();

        public bool buttonOriWasClicked = false;

        private void btt_scenceOrigin_Click(object sender, EventArgs e)
        {
            buttonOriWasClicked = true;

            if (buttonHaloWasClicked == true || buttonChristWasClicked == true)
            {
               buttonOriWasClicked = false;
            }

            iChooseBG = 1;
           
        //    Properties.Settings.Default

            // ctrg.ChooseBgGameForm1(1, F);
             //Form1.BackgroundImage = Properties.Resources.ori_bg;
             //F.pictureBox1.BackgroundImage = Properties.Resources.ori_logo;
            // F.panel1.BackgroundImage = Properties.Resources.ori_fame;

            Properties.Settings.Default.Bg = iChooseBG.ToString();
            Properties.Settings.Default.Save();

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
            ctrg.SubMenuOff(btt_scenceOrigin, btt_scenceHallow, btt_scenceChrist);
            


            btt_Play.BackgroundImage = Properties.Resources.btt_ori;
            btt_Play.OnHoverImage = Properties.Resources.btt_ori;
            btt_Play.Size = new System.Drawing.Size(150, 60);
            btt_Play.ImageSize = new System.Drawing.Size(151, 63);
            btt_Play.Location = new System.Drawing.Point(124, 225);

            btt_scene.OnHoverImage = Properties.Resources.season_ori;
            btt_scene.BackgroundImage = Properties.Resources.season_ori;

            btt_speed.OnHoverImage = Properties.Resources.speed_ori;
            btt_speed.BackgroundImage = Properties.Resources.speed_ori;

            btt_item.OnHoverImage = Properties.Resources.item_ori;
            btt_item.BackgroundImage = Properties.Resources.item_ori;

            btt_Menu.OnHoverImage = Properties.Resources.menu_ori;
            btt_Menu.BackgroundImage = Properties.Resources.menu_ori;


            ctrg.ChooseBgGame(iChooseBG, this);

        }

        public bool buttonChristWasClicked = false;

        private void btt_scenceChrist_Click(object sender, EventArgs e)
        {
            buttonChristWasClicked = true;

          //  if (buttonHaloWasClicked == true || buttonOriWasClicked == true)
          //  {
                //buttonChristWasClicked = false;
           // }

            iChooseBG = 2;

            Properties.Settings.Default.Bg = iChooseBG.ToString();
            Properties.Settings.Default.Save();

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
            ctrg.SubMenuOff(btt_scenceOrigin, btt_scenceHallow, btt_scenceChrist);

            btt_Play.BackgroundImage = Properties.Resources.play_christ;
            btt_Play.OnHoverImage = Properties.Resources.play_christ;
            btt_Play.Size = new System.Drawing.Size(135, 60);
            btt_Play.ImageSize = new System.Drawing.Size(138, 61);
            btt_Play.Location = new System.Drawing.Point(130, 225);

            btt_scene.OnHoverImage = Properties.Resources.season_christ;
            btt_scene.BackgroundImage = Properties.Resources.season_christ;

            btt_speed.OnHoverImage = Properties.Resources.speed_christ;
            btt_speed.BackgroundImage = Properties.Resources.speed_christ;

            btt_item.OnHoverImage = Properties.Resources.item_christ;
            btt_item.BackgroundImage = Properties.Resources.item_christ;

            btt_Menu.OnHoverImage = Properties.Resources.menu_christ;
            btt_Menu.BackgroundImage = Properties.Resources.menu_christ;

            ctrg.ChooseBgGame(iChooseBG, this);

           
        }
        public bool buttonHaloWasClicked = false;

        private void btt_scenceHallow_Click(object sender, EventArgs e)
        {
           buttonHaloWasClicked = true;

          //  if (buttonOriWasClicked == true || buttonOriWasClicked == true)
           // {
             //   buttonHaloWasClicked = false;
           // }


            iChooseBG = 3;

            Properties.Settings.Default.Bg = iChooseBG.ToString();
            Properties.Settings.Default.Save();

            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
            ctrg.SubMenuOff(btt_scenceOrigin, btt_scenceHallow, btt_scenceChrist);

            btt_Play.BackgroundImage = Properties.Resources.pl;
            btt_Play.OnHoverImage = Properties.Resources.pl;
            btt_Play.Size = new System.Drawing.Size(153, 67);
            btt_Play.ImageSize = new System.Drawing.Size(158, 69);
            btt_Play.Location = new System.Drawing.Point(124, 225);


            btt_scene.OnHoverImage = Properties.Resources.season_hallow;
            btt_scene.BackgroundImage = Properties.Resources.season_hallow;

            btt_speed.OnHoverImage = Properties.Resources.speed_hallow;
            btt_speed.BackgroundImage = Properties.Resources.speed_hallow;

            btt_item.OnHoverImage = Properties.Resources.item_hallow;
            btt_item.BackgroundImage = Properties.Resources.item_hallow;

            btt_Menu.OnHoverImage = Properties.Resources.menu_hallow;
            btt_Menu.BackgroundImage = Properties.Resources.menu_hallow;
            

            ctrg.ChooseBgGame(iChooseBG, this);
          

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
