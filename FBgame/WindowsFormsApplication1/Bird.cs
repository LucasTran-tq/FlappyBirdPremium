using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using WMPLib;
using System.Media;
using System.IO;

namespace WindowsFormsApplication1
{
    class Bird
    {
        Pipe pipe = new Pipe();
        public Bitmap rebird_1 = new Bitmap(Properties.Resources.redbird_downflap),
           rebird_2 = new Bitmap(Properties.Resources.redbird_midflap),
           rebird_3 = new Bitmap(Properties.Resources.redbird_upflap),
           rebird_die = new Bitmap(Properties.Resources.redbird_die),

           yebird_1 = new Bitmap(Properties.Resources.yellowbird_downflap),
           yebird_2 = new Bitmap(Properties.Resources.yellowbird_midflap),
           yebird_3 = new Bitmap(Properties.Resources.yellowbird_upflap),
           yebird_die = new Bitmap(Properties.Resources.yellowbird_die),

           blbird_1 = new Bitmap(Properties.Resources.bluebird_downflap),
           blbird_2 = new Bitmap(Properties.Resources.bluebird_midflap),
           blbird_3 = new Bitmap(Properties.Resources.bluebird_upflap),
           blbird_die = new Bitmap(Properties.Resources.bluebird_die),

           flash_bird = new Bitmap(Properties.Resources.bird_flash_gif);

          

        Bitmap[] array_Bird;
        public Bitmap birdPicture;

        WindowsMediaPlayer soundWing = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer soundGameOver = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer soundHit = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer soundPoint = new WMPLib.WindowsMediaPlayer();

        //string runningPath = AppDomain.CurrentDomain.BaseDirectory;
        string path_SoundWing = string.Format("{0}Resources\\wing.wav", 
                  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        string path_SoundGameOver = string.Format("{0}Resources\\SoundGameOver.wav",
                  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        string path_SoundHit = string.Format("{0}Resources\\hit.wav",
                  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        string path_SoundPoint = string.Format("{0}Resources\\point.wav",
                  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        public int X_Bird = 100;
        public int Y_Bird = 100;

        int count = 0;
        public int index_bird = 0;

        public bool isAlive = true;
        public bool isGetRocket = false;
        public bool isGetGift = false;

        public PictureBox picBoxBird = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = new Bitmap(Properties.Resources.redbird_downflap),
            BackgroundImageLayout = ImageLayout.Stretch,
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Location = new System.Drawing.Point(20, 100),

            Name = "picBoxBird",
            Size = new System.Drawing.Size(34, 24),
            BorderStyle = BorderStyle.None,
            Visible = false,

        };

        public Bitmap Draw2D_Bird()
        {
            if (index_bird == 1) array_Bird = new Bitmap[] { yebird_1, yebird_2, yebird_3 };
            else if (index_bird == 2) array_Bird = new Bitmap[] { blbird_1, blbird_2, blbird_3 };
            else if (index_bird == 3) array_Bird = new Bitmap[] { rebird_1, rebird_2, rebird_3 };
            else array_Bird = new Bitmap[] { yebird_1, yebird_2, yebird_3 };

            if (count < array_Bird.Length)
            {
                birdPicture = array_Bird[count++];
            }
            else
            {
                count = 0;
            }

            return birdPicture;
        }

        public void SoundGameOver()
        {
            soundGameOver.URL = path_SoundGameOver;

            soundGameOver.controls.play();
        }

        public void SoundWing()
        {
            soundWing.URL = path_SoundWing;

            soundWing.controls.play();
        }

        public void SoundHit()
        {
            soundHit.URL = path_SoundHit;

            soundHit.controls.play();
        }
        public void SoundPoint()
        {
            soundPoint.URL = path_SoundPoint;

            soundPoint.controls.play();
        }

        // that isnt useful
        #region
        //public void Bird_Animator(Timer bird_Timer)
        //{

        //    bird_Timer.Interval = 70;
        //    //bird_Timer.Tick += new EventHandler(bird_Timer);
        //    bird_Timer.Start();
        //}

        //public void Bird_Timer_Tick(Control c)
        //{
        //    if (Y_Bird + birdPicture.Height <= c.Height && Y_Bird >= 0)
        //    {
        //        Y_Bird += 10;

        //        if (X_Bird + birdPicture.Width >= pipe.X_pipePairs1 && X_Bird + birdPicture.Width <= pipe.X_pipePairs1 + 52)
        //        {

        //            if (Y_Bird <= 250 + pipe.Y_pipeAbove1 || Y_Bird + birdPicture.Height >= pipe.Y_pipeBottom1)
        //            {


        //                return;

        //            }
        //        }
        //        if (X_Bird + birdPicture.Width >= pipe.X_pipePairs2 && X_Bird + birdPicture.Width <= pipe.X_pipePairs2 + 52)
        //        {
        //            if (Y_Bird <= 250 + pipe.Y_pipeAbove2 || Y_Bird + birdPicture.Height >= pipe.Y_pipeBottom2)
        //            {

        //                return;

        //            }
        //        }

        //    }
        //    else
        //    {

        //        Y_Bird += 10;


        //    }
        //}

        #endregion



        public void Impact_Bird_pipe(Form form,Pipe pipe, Rocket rocket, Gift gift, Timer timer, Timer timer2)
        {
            
            // inside form 
            if (Y_Bird >= 0 && Y_Bird + picBoxBird.Height <= form.Height)
            {
                Y_Bird += 7;
                picBoxBird.Location = new Point(X_Bird, Y_Bird);

                rocket.Move_Fire(this);
                gift.Appear_Thunder(this);

                if (gift.count_Flash >= 95 )
                {
                    isGetGift = false;

                    gift.count_Flash = 0;

                    gift.soundThunder.controls.stop();

                    timer2.Stop();
                }

                if (X_Bird + picBoxBird.Width >= pipe.X_pipePairs1 && X_Bird + picBoxBird.Width <= pipe.X_pipePairs1 + 52)
                {

                    if (Y_Bird <= 250 + pipe.Y_pipeAbove1 || Y_Bird + picBoxBird.Height >= pipe.Y_pipeBottom1)
                    {
                        if (isAlive && isGetGift)
                        {
                            
                        }

                        // is alive and DIE
                        else
                        {

                            //ctrlGame.GameOver(c1, c2, c3);
                            timer.Stop();
                            //MessageBox.Show("GAME OVER");
                            //return;

                            SoundHit();
                            SoundGameOver();

                            isAlive = false;
                        }
                    }
                }
                if (X_Bird + picBoxBird.Width >= pipe.X_pipePairs2 && X_Bird + picBoxBird.Width <= pipe.X_pipePairs2 + 52)
                {
                    if (Y_Bird <= 250 + pipe.Y_pipeAbove2 || Y_Bird + picBoxBird.Height >= pipe.Y_pipeBottom2)
                    {
                        if (isAlive && isGetGift)
                        {
                           
                        }

                        // is alive and DIE
                        else
                        {

                            //ctrlGame.GameOver(c1, c2, c3);
                            timer.Stop();
                            //MessageBox.Show("GAME OVER");
                            //return;

                            SoundHit();
                            SoundGameOver();

                            isAlive = false;
                        }
                    }
                }

            }

            // outside form and bird die
            else
            {
                Y_Bird += 7;
                
                picBoxBird.Location = new Point(X_Bird, Y_Bird);

                rocket.Move_Fire(this);

                gift.picBoxGift.Visible = false;

                if (isAlive)
                {

                    //ctrlGame.GameOver(c1, c2, c3);
                    timer.Stop();
                    //MessageBox.Show("GAME OVER");
                    //return;

                    SoundHit();
                    SoundGameOver();

                    isAlive = false;
                }
            }

            // set image for bird
            if(isAlive)
            {
                picBoxBird.Image = Draw2D_Bird();
            }

            if (!isAlive)
            {
                picBoxBird.Size = new Size(24, 34);
                if (index_bird == 1)
                {
                    picBoxBird.Image = yebird_die;
                }
                else if (index_bird == 2)
                {
                    picBoxBird.Image = blbird_die;
                }
                else
                {
                    picBoxBird.Image = rebird_die;
                }                    
            }
            if (isGetGift && isAlive)
            {
                picBoxBird.Size = new Size(50, 25);
                picBoxBird.Image = flash_bird;
            }

            
            
        }

        public void Move_Bird_Up()
        {
            SoundWing();

            Y_Bird -= 30;
            picBoxBird.Location = new Point(X_Bird, Y_Bird);

        }


        public int scoreOfGame = 0;
        public void GetScore(Pipe pipe, Control c1)
        {
            if((X_Bird >= pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width && X_Bird - 3 <= pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width)
                   || (X_Bird >= pipe.X_pipePairs2 + pipe.picBoxPipeAbove1.Width && X_Bird - 3 <= pipe.X_pipePairs2 + pipe.picBoxPipeAbove1.Width))
            {
                scoreOfGame++;
                SoundPoint();
            }

            if (isGetGift)
            {
                if ((X_Bird >= pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width && X_Bird - 20 <= pipe.X_pipePairs1 + pipe.picBoxPipeAbove1.Width)
                   || (X_Bird >= pipe.X_pipePairs2 + pipe.picBoxPipeAbove1.Width && X_Bird - 20 <= pipe.X_pipePairs2 + pipe.picBoxPipeAbove1.Width))
                {
                    scoreOfGame++;
                    SoundPoint();
                }
            }
            

        }
    }
}
