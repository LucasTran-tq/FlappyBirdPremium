using System;
using System.Windows.Forms;
using System.IO;
using WMPLib;
using System.Media;
using System.IO;

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
        
        Rocket rocket = new Rocket();
        Gift gift = new Gift();
        Bird bird = new Bird();

        Heart heart = new Heart();
        LifeSpan lifeSpan = new LifeSpan();

        Timer timer_Bird = new Timer();

        Timer timer2 = new Timer();
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
            // add pipe
            this.Controls.Add(pipe.picBoxPipeAbove1);
            this.Controls.Add(pipe.picBoxPipeAbove2);
            this.Controls.Add(pipe.picBoxPipeBottom1);
            this.Controls.Add(pipe.picBoxPipeBottom2);

            // add bird
            this.Controls.Add(bird.picBoxBird);

            // add items
            this.Controls.Add(coins.picBoxCoins);

            // add heart
            this.Controls.Add(heart.picBoxHearts);

            // add lifespan
            this.Controls.Add(lifeSpan.picBoxLifeSpan1);
            this.Controls.Add(lifeSpan.picBoxLifeSpan2);
            this.Controls.Add(lifeSpan.picBoxLifeSpan3);

            // add shield character
            this.Controls.Add(lifeSpan.picBoxShieldCharacter);

            // add rocket
            this.Controls.Add(rocket.picBoxRocket);
            this.Controls.Add(rocket.picBoxEmergency);
            this.Controls.Add(rocket.picBoxFire);

            // add gift
            this.Controls.Add(gift.picBoxGift);
            this.Controls.Add(gift.picBoxThunder);


            pipe.DrawPipe(this, pipe);
            //items.DrawCoins();


            timer_Bird.Interval = 70;
            timer_Bird.Tick += Timer_Bird_Tick;

            timer2.Interval = 70;
            timer2.Tick += Timer2_Tick;

        }

       

        private void Timer_Bird_Tick(object sender, EventArgs e)
        {
            bird.Impact_Bird_pipe(this, pipe, rocket, gift, lifeSpan, timer1, timer2);
            
            //rocket.Impact_Rocket_Bird(bird, timer_Bird, timer1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            //pipe
            pipe.PipeInGame(this, pipe, bird);

            //// coins
            coins.GetCoins(this, bird, pipe);
            coins.CoinsInGame();
            coins.Impact_Coins_Bird(bird);

            //// hearts
            heart.GetHearts(this, bird, pipe);
            heart.HeartsInGame();
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
                lifeSpan.picBoxShieldCharacter.Visible = false;
            }

            if (lifeSpan.GetCount() > 1)
            {
                lifeSpan.SetVisibleOn(bird.X_Bird + 37, bird.Y_Bird - 30);
            }

            //lifeSpan.Impact_Shield_Rocket(rocket, bird);
            lifeSpan.Impact_Shield_Pipes(pipe, bird, heart);
            if (heart.sign_decreaseHearts)
            {
                lifeSpan.Decrease(heart);
                MessageBox.Show(lifeSpan.GetCount().ToString());
            }
            //// rocket
            /*rocket.GetRocket(this, bird, pipe);
            rocket.RocketInGame();
            rocket.Impact_Rocket_Bird(bird, gift, lifeSpan, timer_Bird, timer1);
            rocket.InvisibleEmergency(this);

            //// Gift
            gift.GetGift(this, pipe);
            gift.GiftInGame();
            gift.Impact_Gift_Bird(bird, timer1, timer_Bird, timer2);*/
            // bird
            bird.GetScore(pipe, label1);

           
            label1.Text = bird.scoreOfGame.ToString();

            
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            gift.count_Flash++;
        }


        private void btt_Menu_Click(object sender, EventArgs e)
        {
            ctrg.MainScreenOff(btt_Play, btt_Menu, btt_Exit, pB_IntroBird);
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
        }

        private void btt_Play_Click(object sender, EventArgs e)
        {
            ctrg.MainScreenOff(btt_Play, btt_Menu, btt_Exit, pB_IntroBird);

            bird.picBoxBird.Visible = true;

            ctrg.SoundStartGame();

            timer1.Start();

            timer_Bird.Start();

           
        }

       
        private void btt_exit2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //this.Close();
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
                ctrg.MainScreenOn(btt_Play, btt_Menu, btt_Exit);
                ctrg.SubMenuOff(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium, btt_Back);
                ctrg.MenuOff(btt_scene, btt_speed, btt_item, btt_Back);
                pl_BgMenu.Visible = false;
            }
            else
            {
                ctrg.Item_SubMenuOff(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox, pl_BgMenu, choose_lb, btt_Back);
                ctrg.SubMenuOff(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium, btt_Back);
                pl_BgMenu.Visible = true;
                ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
            }                
        }

        private void btt_SpeedHard_Click(object sender, EventArgs e)
        {
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
        }

        private void btt_SpeedEasy_Click(object sender, EventArgs e)
        {
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
        }

        private void btt_SpeedMedium_Click(object sender, EventArgs e)
        {
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
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
                //MessageBox.Show("go into");
                //pB_IntroBird.Visible = false;
        }

        private void btt_item_Click(object sender, EventArgs e)
        {
            ctrg.SubMenuOff(btt_scene, btt_item, btt_speed, btt_Back);
            ctrg.Item_SubMenuOn(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox, pl_BgMenu, choose_lb, btt_Back);
        }

        private void yebirdPictureBox_Click(object sender, EventArgs e)
        {
            bird.index_bird = 1;
            ctrg.Item_SubMenuOff(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox, pl_BgMenu, choose_lb, btt_Back);
            ctrg.MainScreenOn(btt_Play, btt_Menu, btt_Exit);
        }

        private void blbirdPictureBox_Click(object sender, EventArgs e)
        {
            bird.index_bird = 2;
            ctrg.Item_SubMenuOff(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox, pl_BgMenu, choose_lb, btt_Back);
            ctrg.MainScreenOn(btt_Play, btt_Menu, btt_Exit);
        }

        private void rebirdPictureBox_Click(object sender, EventArgs e)
        {
            bird.index_bird = 3;
            ctrg.Item_SubMenuOff(yebirdPictureBox, blbirdPictureBox, rebirdPictureBox, pl_BgMenu, choose_lb, btt_Back);
            ctrg.MainScreenOn(btt_Play, btt_Menu, btt_Exit);
        }
    }
}
