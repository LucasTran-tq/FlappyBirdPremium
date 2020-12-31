using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class LifeSpan
    {
        int iHearts = 1;

        int X_LifeSpan;
        int Y_LifeSpan;

        public Bitmap bmp = new Bitmap(Properties.Resources.lifespan);

        public PictureBox picBoxLifeSpan1 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.lifespan,
            Location = new System.Drawing.Point(10, 420),
            Name = "pictureLifeSpan",
            Size = new System.Drawing.Size(30, 30),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = true,
        };

        public PictureBox picBoxLifeSpan2 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.lifespan,
            Location = new System.Drawing.Point(40, 420),
            Name = "pictureLifeSpan",
            Size = new System.Drawing.Size(30, 30),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
        };

        public PictureBox picBoxLifeSpan3 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.lifespan,
            Location = new System.Drawing.Point(70, 420),
            Name = "pictureLifeSpan",
            Size = new System.Drawing.Size(30, 30),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
        };

        public PictureBox picBoxShieldCharacter = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = global::WindowsFormsApplication1.Properties.Resources.superman,
            Location = new System.Drawing.Point(70, 420),
            Name = "pictureLifeSpan",
            Size = new System.Drawing.Size(60, 60),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom,
            Visible = false,
        };

        public void DrawLifeSpan()
        {
            if (iHearts == 1)
            {
                picBoxLifeSpan1.Visible = true;
                picBoxLifeSpan2.Visible = false;
                picBoxLifeSpan3.Visible = false;
            }
            else if (iHearts == 2)
            {
                picBoxLifeSpan1.Visible = true;
                picBoxLifeSpan2.Visible = true;
                picBoxLifeSpan3.Visible = false;
            }
            else if (iHearts == 3)
            {
                picBoxLifeSpan1.Visible = true;
                picBoxLifeSpan2.Visible = true;
                picBoxLifeSpan3.Visible = true;
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
                heart.sign_getHearts = false;
                //MessageBox.Show("iheart = " + iHearts);
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
        public void SetVisibleOn(int iX, int iY)
        {
            picBoxShieldCharacter.Location = new Point(iX, iY);
            picBoxShieldCharacter.Visible = true;
        }

        public void Impact_Shield_Pipes(Pipe pipe, Bird bird, Heart heart)
        {
            if (Shield_IsExist())
            {
                int X_Shield = bird.X_Bird + 37;
                int Y_Shield = bird.Y_Bird - 30;
                if (X_Shield + picBoxShieldCharacter.Width >= pipe.X_pipePairs1 && X_Shield + picBoxShieldCharacter.Width <= pipe.X_pipePairs1 + 52)
                {

                    if (Y_Shield <= 250 + pipe.Y_pipeAbove1)
                    {
                        if (pipe.picBoxPipeAbove1.Visible)
                        {
                            pipe.picBoxPipeAbove1.Visible = false;
                            heart.sign_decreaseHearts = true;
                        }

                    }
                    else if (Y_Shield + picBoxShieldCharacter.Height >= pipe.Y_pipeBottom1)
                    {
                        if (pipe.picBoxPipeBottom1.Visible)
                        {
                            pipe.picBoxPipeBottom1.Visible = false;
                            heart.sign_decreaseHearts = true;
                        }
                    }

                }
                if (X_Shield + picBoxShieldCharacter.Width >= pipe.X_pipePairs2 && X_Shield + picBoxShieldCharacter.Width <= pipe.X_pipePairs2 + 52)
                {

                    if (Y_Shield <= 250 + pipe.Y_pipeAbove2)
                    {
                        if (pipe.picBoxPipeAbove2.Visible)
                        {
                            pipe.picBoxPipeAbove2.Visible = false;
                            heart.sign_decreaseHearts = true;
                        }
                    }


                    else if (Y_Shield + picBoxShieldCharacter.Height >= pipe.Y_pipeBottom2)
                    {
                        if (pipe.picBoxPipeBottom2.Visible)
                        {
                            pipe.picBoxPipeBottom2.Visible = false;
                            heart.sign_decreaseHearts = true;
                        }

                    }

                }

            }
        }

        public void Impact_Shield_Rocket(Rocket rocket, Bird bird)
        {
            if (Shield_IsExist())
            {
                int X_Shield = bird.X_Bird + 37;
                int Y_Shield = bird.Y_Bird - 30;
                if ((X_Shield + picBoxShieldCharacter.Width >= rocket.X_Rocket) && (X_Shield <= rocket.X_Rocket + rocket.picBoxRocket.Width))
                {

                    if (Y_Shield + picBoxShieldCharacter.Height >= rocket.Y_Rocket && bird.Y_Bird <= rocket.Y_Rocket + rocket.picBoxRocket.Height)
                    {
                        iHearts--;
                        rocket.picBoxRocket.Visible = false;
                    }
                }
            }
        }
    }
    
}
