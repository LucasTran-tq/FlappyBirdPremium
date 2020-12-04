using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Media;
namespace ver3
{
    class Bird
    {
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
            if (choose == 1) array_Bird = new Bitmap[] { yebird_1, yebird_2, yebird_3 };
            else if (choose == 2) array_Bird = new Bitmap[] { blbird_1, blbird_2, blbird_3 };
            else if (choose == 3) array_Bird = new Bitmap[] { rebird_1, rebird_2, rebird_3 };
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

        // audio
        public SoundPlayer soundWing = new SoundPlayer(Properties.Resources.wing);
        public SoundPlayer soundHit = new SoundPlayer(Properties.Resources.hit);
        public SoundPlayer soundDie = new SoundPlayer(Properties.Resources.die);
    }
}
