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
    class Rocket
    {
        public int X_Rocket;
        public int Y_Rocket;
        int rocket_Count = 0;
        int randomNext_Rocket = 4;
        int distance_2pipe = 150;

        int X_Fire;
        int Y_Fire;

        Random random = new Random();

        public Bitmap rocket = new Bitmap(Properties.Resources.ezgif_com_gif_maker);
        public Bitmap emergency = new Bitmap(Properties.Resources.emergency_gif);
        public Bitmap fire = new Bitmap(Properties.Resources.fire_gif);

        WindowsMediaPlayer soundEmergency = new WMPLib.WindowsMediaPlayer();
        public WindowsMediaPlayer soundBoomExplosion = new WMPLib.WindowsMediaPlayer();

        string path_SoundEmergency = string.Format("{0}Resources\\emergency.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        string path_SoundBoomExplosion = string.Format("{0}Resources\\boomExplosion.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));


        public PictureBox picBoxRocket = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.ezgif_com_gif_maker,
            Location = new System.Drawing.Point(500, 110),
            Name = "pictureRocket",
            Size = new System.Drawing.Size(100, 100),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
            //TabIndex = 13,
            //TabStop = false,
        };

        public PictureBox picBoxEmergency = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.emergency_gif,
            Location = new System.Drawing.Point(300, 110),
            Name = "pictureEmergency",
            Size = new System.Drawing.Size(40, 40),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
            //TabIndex = 13,
            //TabStop = false,
        };

        public PictureBox picBoxFire = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.fire_gif,
            Location = new System.Drawing.Point(100, 100),
            Name = "pictureEmergency",
            Size = new System.Drawing.Size(80, 100),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
            //TabIndex = 13,
            //TabStop = false,
        };
        public void SoundEmergency()
        {
            soundEmergency.URL = path_SoundEmergency;
            soundEmergency.controls.play();
        }
        public void SoundBoomExplosion()
        {
            soundBoomExplosion.URL = path_SoundBoomExplosion;
            soundBoomExplosion.controls.play();
        }

        public void GetRocket(Form form, Bird bird, Pipe pipe)
        {

            // pass through pipe
            if (pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width <= 0)
            {
                rocket_Count++;
                if (rocket_Count == randomNext_Rocket)
                {
                    SoundEmergency();
                    picBoxEmergency.Visible = true;

                    picBoxRocket.Visible = true;
                    DrawRocket(form, pipe);
                    rocket_Count = 0;
                    randomNext_Rocket = random.Next(4, 5);
                }
            }
        }

        public void DrawRocket(Form form, Pipe pipe)
        {
            X_Rocket = form.Width + 1500;

            Y_Rocket = random.Next(0, form.Height - 100);
           
            // Emergency appear
            picBoxEmergency.Location = new Point(350, Y_Rocket);

            // rocket appear
            picBoxRocket.Location = new Point(X_Rocket, Y_Rocket);

        }

        public void RocketInGame()
        {
            X_Rocket -= 10;

            picBoxRocket.Location = new Point(X_Rocket, Y_Rocket);
        }

        

        public void InvisibleEmergency(Form form)
        {
            if(X_Rocket >= form.Width + 50 && X_Rocket <= form.Width + 60)
            {
                picBoxEmergency.Visible = false;
            }
        }

        public void Move_Fire(Bird bird)
        {
            //MessageBox.Show("gointo");
            
            if (bird.isGetRocket && !bird.isAlive)
            {
                X_Fire = bird.X_Bird - 30;
                Y_Fire = bird.Y_Bird - 50;

                picBoxFire.Location = new Point(X_Fire, Y_Fire);

            }
        }

        public void Impact_Rocket_Bird(Bird bird, Gift gift, LifeSpan lifeSpan, Timer timer_Bird, Timer timer)
        {

            if ((bird.X_Bird + bird.picBoxBird.Width >= X_Rocket)
                      && (bird.X_Bird <= X_Rocket + picBoxRocket.Width))
            {
                // increase score
                if (bird.Y_Bird + bird.picBoxBird.Height >= Y_Rocket
                         && bird.Y_Bird <= Y_Rocket + picBoxRocket.Height)
                {

                    if (picBoxRocket.Visible)
                    {
                        bird.isGetRocket = true;

                        bird.isAlive = false;

                        bird.picBoxBird.BackColor = Color.Orange;

                        picBoxFire.Visible = true;

                        SoundBoomExplosion();

                        gift.picBoxThunder.Visible = false;

                        gift.soundTheFlash.controls.stop();

                        bird.SoundGameOver();

                        timer.Stop();
                    }

                    picBoxRocket.Visible = false;

                }

            }
        }

    }
}
