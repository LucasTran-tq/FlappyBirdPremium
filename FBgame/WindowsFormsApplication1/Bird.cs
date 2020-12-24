using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Bird
    {
        Pipe pipe = new Pipe();
        public Bitmap rebird_1 = new Bitmap(Properties.Resources.redbird_downflap),
           rebird_2 = new Bitmap(Properties.Resources.redbird_midflap),
           rebird_3 = new Bitmap(Properties.Resources.redbird_upflap),
           yebird_1 = new Bitmap(Properties.Resources.yellowbird_downflap),
           yebird_2 = new Bitmap(Properties.Resources.yellowbird_midflap),
           yebird_3 = new Bitmap(Properties.Resources.yellowbird_upflap),
           blbird_1 = new Bitmap(Properties.Resources.bluebird_downflap),
           blbird_2 = new Bitmap(Properties.Resources.bluebird_midflap),
           blbird_3 = new Bitmap(Properties.Resources.bluebird_upflap);

        Bitmap[] array_Bird;
        public Bitmap birdPicture;

        public int X_Bird = 100;
        public int Y_Bird = 100;

        int count = 0;
        public int choose = 0;

        public PictureBox picBoxBird = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = new Bitmap(Properties.Resources.redbird_downflap),
            BackgroundImageLayout = ImageLayout.Stretch,

            Location = new System.Drawing.Point(20, 100),

            Name = "picBoxBird",
            Size = new System.Drawing.Size(34, 24),
            BorderStyle = BorderStyle.None

        };

        public Bitmap Draw2D_Bird()
        {
            array_Bird = new Bitmap[] { yebird_1, yebird_2, yebird_3 };

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

        public void Impact_Bird_pipe(Form form,Pipe pipe, Timer timer)
        {
            //if (Y_Bird + birdPicture.Height <= c.Height && Y_Bird >= 0)

            if(Y_Bird >= 0 && Y_Bird + picBoxBird.Height <= form.Height)
            {
                Y_Bird += 7;
                picBoxBird.Location = new Point(X_Bird, Y_Bird);

                if (X_Bird + picBoxBird.Width >= pipe.X_pipePairs1 && X_Bird + picBoxBird.Width <= pipe.X_pipePairs1 + 52)
                {

                    if (Y_Bird <= 250 + pipe.Y_pipeAbove1 || Y_Bird + picBoxBird.Height >= pipe.Y_pipeBottom1)
                    {
                        //ctrlGame.GameOver(c1, c2, c3);
                        timer.Stop();
                        //MessageBox.Show("GAME OVER");
                        //return;


                    }
                }
                if (X_Bird + picBoxBird.Width >= pipe.X_pipePairs2 && X_Bird + picBoxBird.Width <= pipe.X_pipePairs2 + 52)
                {
                    if (Y_Bird <= 250 + pipe.Y_pipeAbove2 || Y_Bird + picBoxBird.Height >= pipe.Y_pipeBottom2)
                    {
                        //ctrlGame.GameOver(c1, c2, c3);
                        timer.Stop();
                        //MessageBox.Show("GAME OVER");
                        //return;
                        
                    }
                }

            }
            else
            {
                Y_Bird += 7;
                picBoxBird.Location = new Point(X_Bird, Y_Bird);

                timer.Stop();

                //MessageBox.Show("GAME OVER");

            }


            picBoxBird.Image = Draw2D_Bird();
        }

        public void Move_Bird_Up()
        {
            Y_Bird -= 30;
            picBoxBird.Location = new Point(X_Bird, Y_Bird);
        }
    }
}
