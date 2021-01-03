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
    class Coins
    {
        int X_Coins;
        int Y_Coins;
        int coins_Count = 0;
        int distance_2pipe = 150;
        int randomNext_Coins = 2;

        Random random = new Random();

        HighScoreInfo highScore = new HighScoreInfo();

        public Bitmap coins = new Bitmap(Properties.Resources.coin);
        
        WindowsMediaPlayer soundCash = new WMPLib.WindowsMediaPlayer();

        string path_SoundCash = string.Format("{0}Resources\\Cash Register.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        public PictureBox picBoxCoins = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.coin,
            Location = new System.Drawing.Point(700, 110),
            Name = "pictureCoins",
            Size = new System.Drawing.Size(40, 40),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
        };

        
        public void SoundCash()
        {
            soundCash.URL = path_SoundCash;
            soundCash.controls.play();
        }

        public void GetCoins(Form form, Bird bird, Pipe pipe)
        {
            
            // bird pass through pipe
            if(pipe.X_pipePairs1 + pipe.recPipe.Width <= 0)
            {
                coins_Count++;
                if(coins_Count == randomNext_Coins)
                {
                    picBoxCoins.Visible = true;

                    DrawCoins(form, pipe);
                    coins_Count = 0;
                    randomNext_Coins = random.Next(4,5);
                }
            }
        }

        

        public void DrawCoins(Form form, Pipe pipe)
        {
            X_Coins = form.Width + 150 + pipe.recPipe.Width + random.Next(0, distance_2pipe);

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
            if(bird.X_Bird + bird.recBird.Width >= X_Coins)
            {
                // increase score
                if(bird.Y_Bird + bird.recBird.Height >= Y_Coins && bird.Y_Bird <= Y_Coins + picBoxCoins.Height)
                {
                    SoundCash();
                    if (picBoxCoins.Visible)
                    {
                       highScore.scoreOfGame += 3;
                    }
                    picBoxCoins.Visible = false;
                }
                
            }
        }

       



    }
}
