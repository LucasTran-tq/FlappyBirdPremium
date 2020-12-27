using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using WMPLib;
using System.IO;
namespace WindowsFormsApplication1
{
    class Items
    {
        int X_Coins;
        int Y_Coins;
        int coins_Count = 0;
        int distance_2pipe = 150;
        int randomNext_Coins = 2;

        int X_Hearts;
        int Y_Hearts;
        int pipes_Count = 0;
        int randomNext_Hearts = 3;
        public bool sign_getHearts = false;


        Random random = new Random();
        public Bitmap coins = new Bitmap(Properties.Resources.Coins);
        public Bitmap hearts = new Bitmap(Properties.Resources.heart_item);

        WindowsMediaPlayer soundCash = new WMPLib.WindowsMediaPlayer();

        string path_SoundCash = string.Format("{0}Resources\\Cash Register.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        public PictureBox picBoxCoins = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.Coins,
            Location = new System.Drawing.Point(700, 110),
            Name = "pictureCoins",
            Size = new System.Drawing.Size(40, 40),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
            //TabIndex = 13,
            //TabStop = false,
        };

        

        public void SoundCash()
        {
            soundCash.URL = path_SoundCash;
            soundCash.controls.play();
        }

        public void GetCoins(Form form, Bird bird, Pipe pipe)
        {
            
            // bird pass through pipe
            if(pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width <= 0)
            {
                coins_Count++;
                if(coins_Count == randomNext_Coins)
                {
                    picBoxCoins.Visible = true;

                    //MessageBox.Show("hello");
                    DrawCoins(form, pipe);
                    coins_Count = 0;
                    randomNext_Coins = random.Next(4,5);
                }
            }
        }

        

        public void DrawCoins(Form form, Pipe pipe)
        {
            X_Coins = form.Width + 150 + pipe.picBoxPipeAbove1.Width + random.Next(0, distance_2pipe);

            Y_Coins = random.Next(0, form.Height - 40);
           
            picBoxCoins.Location = new Point(X_Coins, Y_Coins);
        }

        public void CoinsInGame()
        {
            X_Coins -= 5;

            picBoxCoins.Location = new Point(X_Coins, Y_Coins);
        }


        public void Impact_Coins_Bird(Bird bird)
        {
            // 50 is the skin of picboxCoins
            if(bird.X_Bird + bird.picBoxBird.Width >= X_Coins)
            {
                // increase score
                if(bird.Y_Bird + bird.picBoxBird.Height >= Y_Coins && bird.Y_Bird <= Y_Coins + picBoxCoins.Height)
                {
                    SoundCash();
                    if (picBoxCoins.Visible)
                    {
                        bird.scoreOfGame += 3;
                    }
                    picBoxCoins.Visible = false;
                }
                
            }
        }

        public PictureBox picBoxHearts = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.heart_item,
            Location = new System.Drawing.Point(100, 110),
            Name = "pictureHearts",
            Size = new System.Drawing.Size(40, 40),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            TabStop = false,
            Visible = false,
        };

        public void DrawHearts(Form form, Pipe pipe)
        {
            X_Hearts = form.Height + 150 + pipe.picBoxPipeAbove1.Width + random.Next(50, distance_2pipe);

            Y_Hearts = random.Next(0, form.Height - 30);

            picBoxHearts.Location = new Point(X_Hearts, Y_Hearts);

        }
        public void GetHearts(Form form, Bird bird, Pipe pipe)
        {

            // bird pass through pipe
            if (pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width <= 0)
            {
                pipes_Count++;
                if (pipes_Count == randomNext_Hearts)
                {
                    picBoxHearts.Visible = true;

                    //MessageBox.Show("hello");
                    DrawHearts(form, pipe);
                    pipes_Count = 0;
                    randomNext_Hearts = random.Next(4, 5);
                }
            }
        }

        public void HeartsInGame()
        {
            X_Hearts -= 5;

            picBoxHearts.Location = new Point(X_Hearts, Y_Hearts);
        }

        public void Impact_Hearts_Bird(Bird bird)
        {
            // 50 is the skin of picboxCoins
            if (bird.X_Bird + bird.picBoxBird.Width >= X_Hearts)
            {
                // increase score
                if (bird.Y_Bird + bird.picBoxBird.Height >= Y_Hearts && bird.Y_Bird <= Y_Hearts + picBoxHearts.Height)
                {
                    //MessageBox.Show("............................................");
                    picBoxHearts.Visible = false;
                    sign_getHearts = true;
                }

            }
            else sign_getHearts = false;
        }




    }
}
