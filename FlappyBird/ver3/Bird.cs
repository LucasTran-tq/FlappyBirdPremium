using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace ver3
{
    class Bird
    {
        public Bitmap bird_1 = new Bitmap(Properties.Resources.redbird_downflap),
            bird_2 = new Bitmap(Properties.Resources.redbird_midflap),
            bird_3 = new Bitmap(Properties.Resources.redbird_upflap);

        Bitmap[] array_Bird;
        public Bitmap birdPicture;

        public float X_Bird = 60;
        public float Y_Bird = 200;

        int count = 0;
        public Bitmap Draw2D_Bird()
        {
            array_Bird = new Bitmap[] { bird_1, bird_2, bird_3 };

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
    }
}
