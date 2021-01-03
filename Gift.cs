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
    class Gift
    {
        int X_Gift;
        int Y_Gift;
        int gift_Count = 0;
        int randomNext_Gift = 4;
        int distance_2pipe = 150;

        public int count_Flash = 0;

        Random random = new Random();

        

        public WindowsMediaPlayer soundThunder = new WMPLib.WindowsMediaPlayer();
        public WindowsMediaPlayer soundTheFlash = new WMPLib.WindowsMediaPlayer();

        string path_SoundThunder = string.Format("{0}Resources\\thunder.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        string path_SoundTheFlash = string.Format("{0}Resources\\TheFlash.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        public Bitmap img = new Bitmap(Properties.Resources.GiftOrigin);

        public bool gift_Flash_Appearance = false;

        public void CheckSeasion()
        {
            if (Properties.Settings.Default.Bg == "2")
                img = Properties.Resources.GiftChristmas;
            else if (Properties.Settings.Default.Bg == "3")
                img = Properties.Resources.GiftHalloween;
            else
                img =  Properties.Resources.GiftOrigin;
        }
            

        public PictureBox picBoxGift = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = Properties.Resources.GiftOrigin,
            Location = new System.Drawing.Point(500, 110),
            Name = "pictureGift",
            Size = new System.Drawing.Size(50, 50),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,

        };

        public PictureBox picBoxThunder = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.thunder_gif,
            Location = new System.Drawing.Point(300, 110),
            Name = "pictureThunder",
            Size = new System.Drawing.Size(50, 50),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,

        };

        public void SoundThunder()
        {
            soundThunder.URL = path_SoundThunder;

            soundThunder.controls.play();
        }
        public void SoundTheFlash()
        {
            soundTheFlash.URL = path_SoundTheFlash;

            soundTheFlash.controls.play();
        }
        public void GetGift(Form form, Pipe pipe)
        {

            if (pipe.X_pipePairs1 + pipe.recPipe.Width <= 0)
            {
                gift_Count++;
                if (gift_Count == randomNext_Gift)
                {
                    picBoxGift.Visible = true;
                    DrawGift(form);
                    gift_Count = 0;
                    randomNext_Gift = random.Next(5, 8);
                }
            }
        }

        public void DrawGift(Form form)
        {
            X_Gift = form.Width + 50;

            Y_Gift = random.Next(0, form.Height - 50);

            if (Properties.Settings.Default.Bg == "2")
                picBoxGift.Image = Properties.Resources.GiftChristmas;
            else if (Properties.Settings.Default.Bg == "3")
                picBoxGift.Image = Properties.Resources.GiftHalloween;
            else if (Properties.Settings.Default.Bg == "1") 
                picBoxGift.Image = Properties.Resources.GiftOrigin;
           
            // gift appear
            picBoxGift.Location = new Point(X_Gift, Y_Gift);

        }

        public void GiftInGame(Bird bird, int speed)
        {
            // out of form and it stop
            if (X_Gift <= -50)
            {
                X_Gift = -50;
                picBoxGift.Location = new Point(X_Gift, Y_Gift);
            }

            else if (bird.isGetGift)
            {
                X_Gift -= speed * 2;
            }
            else
            {
                X_Gift -= speed;

                picBoxGift.Location = new Point(X_Gift, Y_Gift);

            }
        }

        public void Impact_Gift_Bird(Bird bird, Timer timer1, Timer timer_Bird, Timer timer2)
        {
            if ((bird.X_Bird + bird.recBird.Width >= X_Gift)
                      && (bird.X_Bird <= X_Gift + picBoxGift.Width))
            {
                
                if (bird.Y_Bird + bird.recBird.Height >= Y_Gift
                         && bird.Y_Bird <= Y_Gift + picBoxGift.Height)
                {

                    if (picBoxGift.Visible)
                    {
                        
                        bird.isGetGift = true;

                        picBoxThunder.Visible = true;

                        SoundThunder();

                        SoundTheFlash();

                        timer2.Start();
                    }

                    picBoxGift.Visible = false;

                }

            }
        }

        public void Appear_Thunder(Bird bird)
        {
            if (bird.isGetGift )
            {
                picBoxThunder.Location = new Point(bird.X_Bird, bird.Y_Bird - 50);
            }
            else
            {
                picBoxThunder.Visible = false;
            }
        }
    }
}
