
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

        public Rectangle recRocket;
        public Rectangle recEmergency;
        public Rectangle recFire;


        public bool rocket_Apearance = false;

        // shield impact rocket. and rocket get fire
        public bool rocket_Fire = false;


        public Bitmap rocket = new Bitmap(Properties.Resources.Rocket);
        public Bitmap emergency = new Bitmap(Properties.Resources.emergency_gif)
            ;
        public Bitmap fire = new Bitmap(Properties.Resources.fire_gif);

        WindowsMediaPlayer soundEmergency = new WMPLib.WindowsMediaPlayer();
        public WindowsMediaPlayer soundBoomExplosion = new WMPLib.WindowsMediaPlayer();

        string path_SoundEmergency = string.Format("{0}Resources\\emergency.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        string path_SoundBoomExplosion = string.Format("{0}Resources\\boomExplosion.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

      

        public PictureBox picBoxEmergency = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.emergency_gif,
            Location = new System.Drawing.Point(300, 110),
            Name = "pictureEmergency",
            Size = new System.Drawing.Size(40, 40),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,

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

        };

        public Rocket()
        {
            recRocket = new Rectangle(X_Rocket, Y_Rocket, 100, 45);

        }


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
            if (pipe.X_pipePairs1 + pipe.recPipe.Width <= 0)
            {
                rocket_Count++;
                if (rocket_Count == randomNext_Rocket)
                {
                    SoundEmergency();

                    picBoxEmergency.Visible = true;

                    picBoxFire.Visible = false;

                    rocket_Apearance = true;

                    rocket_Fire = false;

                    DrawRocket(form, pipe);
                    rocket_Count = 0;
                    randomNext_Rocket = random.Next(5, 6);
                }
            }
        }

        public void DrawRocket(Form form, Pipe pipe)
        {
            X_Rocket = form.Width + 1500;

            Y_Rocket = random.Next(0, form.Height - 50);

            //Emergency appear
             picBoxEmergency.Location = new Point(350, Y_Rocket);

        }

        public void RocketInGame(Bird bird)
        {
            if (rocket_Fire)
            {
                X_Rocket -= 7;
                Y_Rocket += 7;
            }

            else if (bird.isGetGift)
            {
                X_Rocket -= 13;
            }
            else
            {
                X_Rocket -= 7;
            }
        }



        public void InvisibleEmergency(Form form)
        {
            if (X_Rocket >= form.Width + 50 && X_Rocket <= form.Width + 70)
            {
                picBoxEmergency.Visible = false;
            }
        }

        public void Move_Fire(Bird bird)
        {

            if (bird.isGetRocket && !bird.isAlive)
            {
                X_Fire = bird.X_Bird - 15;
                Y_Fire = bird.Y_Bird - 55;
                picBoxFire.Location = new Point(X_Fire, Y_Fire);

            }

            else if (rocket_Fire)
            {
                X_Fire = X_Rocket;
                Y_Fire = Y_Rocket - 50;
                picBoxFire.Location = new Point(X_Fire, Y_Fire);

            }
        }

        public void Impact_Rocket_Bird(Bird bird, Gift gift, LifeSpan lifeSpan, Timer timer_Bird, Timer timer)
        {

            if ((bird.X_Bird + bird.recBird.Width >= X_Rocket)
                      && (bird.X_Bird <= X_Rocket + recRocket.Width))
            {
                // increase score
                if (bird.Y_Bird + bird.recBird.Height >= Y_Rocket
                         && bird.Y_Bird <= Y_Rocket + recRocket.Height)
                {

                    if (rocket_Apearance)
                    {
                        bird.isGetRocket = true;

                        bird.isAlive = false;

                         picBoxFire.Visible = true;

                        SoundBoomExplosion();

                        gift.picBoxThunder.Visible = false;

                        gift.soundTheFlash.controls.stop();

                        bird.SoundGameOver();

                        timer.Stop();

                        rocket_Apearance = false;
                    }



                }

            }
        }

        public void Draw_Rocket(Graphics g)
        {

            g.DrawImage(rocket, new RectangleF(X_Rocket, Y_Rocket, recRocket.Width, recRocket.Height));
        }
        public void Draw_Emergency(Graphics g)
        {

            g.DrawImage(emergency, new RectangleF(350, Y_Rocket, recEmergency.Width, recEmergency.Height));
        }

        public void Draw_Fire(Graphics g)
        {
            g.DrawImage(fire, new RectangleF(X_Fire, Y_Fire, recFire.Width, recFire.Height));
        }
    }
}
