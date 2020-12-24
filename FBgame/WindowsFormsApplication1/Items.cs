using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class Items
    {
        int X_Coins;
        int Y_Coins;
        int coins_Count = 0;
        int distance_2pipe = 150;
        int randomNext_Coins = 2;

        Random random = new Random();
        public Bitmap coins = new Bitmap(Properties.Resources.Coins);

        public PictureBox picBoxCoins = new PictureBox()
        {
            

            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.Coins,
            Location = new System.Drawing.Point(100, 110),
            Name = "pictureCoins",
            Size = new System.Drawing.Size(40, 40),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            TabIndex = 13,
            TabStop = false,
        };

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
            X_Coins = form.Height + 150 + pipe.picBoxPipeAbove1.Width + random.Next(50, distance_2pipe);

            Y_Coins = random.Next(0, form.Height);
           
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
                    //MessageBox.Show("............................................");
                    picBoxCoins.Visible = false;
                }
                
            }
        }
    }
}
