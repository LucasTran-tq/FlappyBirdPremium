

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
    class LifeSpan
    {
        int iHearts = 1;

        int X_LifeSpan;
        int Y_LifeSpan;

        int X_Shield;
        int Y_Shield;

        public Bitmap lifespan = new Bitmap(Properties.Resources.lifespan);
        public Bitmap shield_Bitmap = new Bitmap(Properties.Resources.shield);

        public WindowsMediaPlayer soundShield = new WMPLib.WindowsMediaPlayer();
        public WindowsMediaPlayer sound_Disapear_Pipe = new WMPLib.WindowsMediaPlayer();

        string path_SoundShield = string.Format("{0}Resources\\shield_sound.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        string path_Sound_Disappear_Pipe = string.Format("{0}Resources\\disapear_pipe_sound.wav",
                 Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        public Rectangle recLifeSpan;
        public Rectangle recShield;

        public bool life_Span1_Appearance = false;
        public bool life_Span2_Appearance = false;
        public bool life_Span3_Appearance = false;

        public bool shield_Apearance = false;

        public LifeSpan()
        {
            recLifeSpan = new Rectangle(-10, 0, 30, 30);
            recShield = new Rectangle(-10, 0, 60, 60);
        }

        public void SoundShield()
        {
            soundShield.URL = path_SoundShield;
            soundShield.controls.play();
        }
        public void SoundDisappearPipe()
        {
            sound_Disapear_Pipe.URL = path_Sound_Disappear_Pipe;
            sound_Disapear_Pipe.controls.play();
        }

        public void DrawLifeSpan()
        {
            if (iHearts == 1)
            {

                life_Span1_Appearance = true;
                life_Span2_Appearance = false;
                life_Span3_Appearance = false;
            }
            else if (iHearts == 2)
            {


                life_Span1_Appearance = true;
                life_Span2_Appearance = true;
                life_Span3_Appearance = false;
            }
            else if (iHearts == 3)
            {

                life_Span1_Appearance = true;
                life_Span2_Appearance = true;
                life_Span3_Appearance = true;
            }

        }
        public bool CheckIncrease()
        {
            if (iHearts < 3 && iHearts > 0) return true;
            else return false;
        }
        public void Increase(Heart heart)
        {
            if (CheckIncrease())
            {

                if (iHearts == 2)
                {
                    iHearts = 3;
                }
                else if (iHearts == 1)
                {
                    iHearts = 2;
                }

                SoundShield();

                heart.sign_getHearts = false;

            }
        }
        public int GetCount()
        {
            return iHearts;
        }

        public void Decrease(Heart heart)
        {

            if (iHearts == 3)
            {
                iHearts = 2;
            }
            else if (iHearts == 2)
            {
                iHearts = 1;
            }
            heart.sign_decreaseHearts = false;
        }

        public bool Shield_IsExist()
        {
            if (iHearts > 1) return true;
            else return false;
        }


        public void SetVisibleOn(Bird bird)
        {
            X_Shield = bird.X_Bird + bird.recBird.Width + 5;
            Y_Shield = bird.Y_Bird;

            shield_Apearance = true;


        }

        public void Impact_Shield_Pipes(Pipe pipe, Bird bird, Heart heart)
        {
            if (Shield_IsExist())
            {


                if (X_Shield + recShield.Width >= pipe.X_pipePairs1 && X_Shield + recShield.Width <= pipe.X_pipePairs1 + 52)
                {

                    if (Y_Shield <= 250 + pipe.Y_pipeAbove1)
                    {

                        if (pipe.pipe_Above1_Appearance)
                        {
                            SoundDisappearPipe();
                            pipe.pipe_Above1_Appearance = false;

                            if (!bird.isGetGift)
                            {
                                heart.sign_decreaseHearts = true;
                            }

                        }

                    }
                    else if (Y_Shield + recShield.Height >= pipe.Y_pipeBottom1)
                    {

                        if (pipe.pipe_Bottom1_Appearance)
                        {
                            SoundDisappearPipe();

                            pipe.pipe_Bottom1_Appearance = false;

                            if (!bird.isGetGift)
                            {
                                heart.sign_decreaseHearts = true;
                            }
                        }
                    }

                }
                if (X_Shield + recShield.Width >= pipe.X_pipePairs2 && X_Shield + recShield.Width <= pipe.X_pipePairs2 + 52)
                {

                    if (Y_Shield <= 250 + pipe.Y_pipeAbove2)
                    {
                        if (pipe.pipe_Above2_Appearance)
                        {
                            SoundDisappearPipe();

                            pipe.pipe_Above2_Appearance = false;

                            if (!bird.isGetGift)
                            {
                                heart.sign_decreaseHearts = true;
                            }
                        }
                    }



                    else if (Y_Shield + recShield.Height >= pipe.Y_pipeBottom2)
                    {

                        if (pipe.pipe_Bottom2_Appearance)
                        {
                            SoundDisappearPipe();

                            pipe.pipe_Bottom2_Appearance = false;

                            if (!bird.isGetGift)
                            {
                                heart.sign_decreaseHearts = true;
                            }
                        }

                    }

                }

            }
        }

        public void Impact_Shield_Rocket(Rocket rocket, Bird bird)
        {
            if (Shield_IsExist())
            {
                if ((X_Shield + recShield.Width >= rocket.X_Rocket) && (X_Shield <= rocket.X_Rocket + rocket.recRocket.Width))
                {

                    if (Y_Shield + recShield.Height >= rocket.Y_Rocket && bird.Y_Bird <= rocket.Y_Rocket + rocket.recRocket.Height)
                    {

                        if (rocket.rocket_Apearance)
                        {
                            iHearts--;

                            rocket.picBoxFire.Visible = true;

                            rocket.rocket_Fire = true;
                        }

                    }
                }
            }
        }

        public void Draw_Heart_1(Graphics g)
        {
            g.DrawImage(lifespan, new RectangleF(10, 420, recLifeSpan.Width, recLifeSpan.Height));
        }
        public void Draw_Heart_2(Graphics g)
        {
            g.DrawImage(lifespan, new RectangleF(40, 420, recLifeSpan.Width, recLifeSpan.Height));
        }
        public void Draw_Heart_3(Graphics g)
        {
            g.DrawImage(lifespan, new RectangleF(70, 420, recLifeSpan.Width, recLifeSpan.Height));
        }

        public void Draw_Shield(Graphics g)
        {
            g.DrawImage(shield_Bitmap, new RectangleF(X_Shield, Y_Shield, recLifeSpan.Width, recLifeSpan.Height));
        }

    }

}
