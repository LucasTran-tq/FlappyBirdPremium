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

        Random random = new Random();

        public Bitmap gift = new Bitmap(Properties.Resources.gift_gif);

        WindowsMediaPlayer soundThunder = new WMPLib.WindowsMediaPlayer();

        string path_SoundThunder = string.Format("{0}Resources\\thunder.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        public PictureBox picBoxGift = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.gift_gif,
            Location = new System.Drawing.Point(500, 110),
            Name = "pictureGift",
            Size = new System.Drawing.Size(50, 50),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
            //TabIndex = 13,
            //TabStop = false,
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
            //TabIndex = 13,
            //TabStop = false,
        };

        public void SoundThunder()
        {
            soundThunder.URL = path_SoundThunder;

            soundThunder.controls.play();
        }

        public void GetGift(Form form, Pipe pipe)
        {

            if (pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width <= 0)
            {
                gift_Count++;
                if (gift_Count == randomNext_Gift)
                {
                    //SoundEmergency();
                    picBoxGift.Visible = true;
                    DrawGift(form);
                    gift_Count = 0;
                    randomNext_Gift = random.Next(4, 5);
                }
            }
        }

        public void DrawGift(Form form)
        {
            X_Gift = form.Width + 50;

            Y_Gift = random.Next(0, form.Height - 50);

           
            // gift appear
            picBoxGift.Location = new Point(X_Gift, Y_Gift);

        }

        public void GiftInGame()
        {
            X_Gift -= 5;

            picBoxGift.Location = new Point(X_Gift, Y_Gift);
        }

        public void Impact_Gift_Bird(Bird bird, Timer timer1, Timer timer_Bird)
        {
            if ((bird.X_Bird + bird.picBoxBird.Width >= X_Gift)
                      && (bird.X_Bird <= X_Gift + picBoxGift.Width))
            {
                
                if (bird.Y_Bird + bird.picBoxBird.Height >= Y_Gift
                         && bird.Y_Bird <= Y_Gift + picBoxGift.Height)
                {

                    if (picBoxGift.Visible)
                    {
                        

                        bird.isGetGift = true;

                        picBoxThunder.Visible = true;

                        SoundThunder();

                        Appear_Thunder(bird);

                        //soundThunder.
                        
                        //bird.isGetRocket = true;
                        //bird.isAlive = false;

                        //SoundBoomExplosion();
                        //timer.Stop();

                        //timer1.Stop();
                        //timer_Bird.Stop();
                    }

                    picBoxGift.Visible = false;

                }

            }
        }

        public void Appear_Thunder(Bird bird)
        {
            if (bird.isGetGift)
            {
                picBoxThunder.Location = new Point(bird.X_Bird, bird.Y_Bird - 50);

            }
        }
    }
}
