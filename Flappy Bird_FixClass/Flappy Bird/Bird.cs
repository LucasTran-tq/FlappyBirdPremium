using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flappy_Bird
{
    class Bird : Pipe
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

        public float X_Bird = 60;
        public float Y_Bird = 200;

        int count = 0;
        public int choose = 0;
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


        public void Bird_Animator(Timer bird_Timer)
        {

            bird_Timer.Interval = 100;
            //bird_Timer.Tick += new EventHandler(bird_Timer);
            bird_Timer.Start();
        }

       public void Bird_Timer_Tick( Control c)
        {
            if (Y_Bird + birdPicture.Height <= c.Height && Y_Bird >= 0)
            {
                Y_Bird += 10;

                if (X_Bird + birdPicture.Width >= pipe.X_pipePairs1 && X_Bird + birdPicture.Width <= pipe.X_pipePairs1 + 52)
                {

                    if (Y_Bird <= 250 + pipe.Y_pipeAbove1 || Y_Bird + birdPicture.Height >= pipe.Y_pipeBottom1)
                    {

                       
                        return;

                    }
                }
                if (X_Bird + birdPicture.Width >= pipe.X_pipePairs2 && X_Bird + birdPicture.Width <= pipe.X_pipePairs2 + 52)
                {
                    if (Y_Bird <= 250 + pipe.Y_pipeAbove2 || Y_Bird + birdPicture.Height >= pipe.Y_pipeBottom2)
                    {
                        
                        return;

                    }
                }

            }
            else
            {

                Y_Bird += 10;


            }
        }

    }
}
