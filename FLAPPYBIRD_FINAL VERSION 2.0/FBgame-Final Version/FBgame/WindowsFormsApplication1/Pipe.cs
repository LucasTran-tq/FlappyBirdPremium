using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.IO;
namespace WindowsFormsApplication1
{
    class Pipe
    {
        public int Y_pipeAbove1, Y_pipeAbove2;

        public int Y_pipeBottom1, Y_pipeBottom2;

        public int distance_Between2Pipes = 125;

        public int X_pipePairs1, X_pipePairs2;

        Random random_height_Y_pipe = new Random();

        WindowsMediaPlayer sound = new WMPLib.WindowsMediaPlayer();

  
        string path_SoundPoint = string.Format("{0}Resources\\point.wav",
                  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        public Bitmap picPipeAbove = new Bitmap(Properties.Resources.chimney1);
        public Bitmap picPipeBottom = new Bitmap(Properties.Resources.chimney2);

        public Rectangle recPipe;

        public bool pipe_Above1_Appearance = true;
        public bool pipe_Bottom1_Appearance = true;
        public bool pipe_Above2_Appearance = true;
        public bool pipe_Bottom2_Appearance = true;



        public Pipe()
        {

            recPipe = new Rectangle(X_pipePairs1, Y_pipeAbove1, 52, 250);
        }

        public void SoundPoint()
        {
            sound.URL = path_SoundPoint;

            sound.controls.play();
        }

        public void DrawPipe(Form form, Pipe pipe)
        {


            X_pipePairs1 = form.Width + 150;
            Y_pipeAbove1 = -150;
            Y_pipeBottom1 = (pipe.recPipe.Height + Y_pipeAbove1) + distance_Between2Pipes;
            X_pipePairs2 = X_pipePairs1 + 300;
            Y_pipeAbove2 = -100;
            Y_pipeBottom2 = (pipe.recPipe.Height + Y_pipeAbove2) + distance_Between2Pipes;

        }


        public void PipeInGame(Form form, Pipe pipe, Bird bird, int speed)
        {
            if (bird.isGetGift)
            {
                X_pipePairs1 -= speed * 2;
                X_pipePairs2 -= speed * 2;
            }
            else
            {
                X_pipePairs1 -= speed;
                X_pipePairs2 -= speed;
            }



            if (X_pipePairs1 + this.recPipe.Width <= -10)
            {

                X_pipePairs1 = form.Width + 150;

                Y_pipeAbove1 = random_height_Y_pipe.Next(-150, -10);

                Y_pipeBottom1 = (pipe.recPipe.Height + Y_pipeAbove1) + distance_Between2Pipes;


                pipe_Above1_Appearance = true;


                pipe_Bottom1_Appearance = true;

            }

            if (X_pipePairs2 + this.recPipe.Width <= -10)
            {

                X_pipePairs2 = form.Width + 150;

                Y_pipeAbove2 = random_height_Y_pipe.Next(-150, -10);

                Y_pipeBottom2 = (pipe.recPipe.Height + Y_pipeAbove2) + distance_Between2Pipes;



                pipe_Above2_Appearance = true;
                pipe_Bottom2_Appearance = true;

            }

        }

        public void Draw_Pipe_Above_1(Graphics gfx)
        {
            gfx.DrawImage(picPipeAbove, new RectangleF(X_pipePairs1, Y_pipeAbove1, this.recPipe.Width, this.recPipe.Height));

        }
        public void Draw_Pipe_Bottom_1(Graphics gfx)
        {
            gfx.DrawImage(picPipeBottom, new RectangleF(X_pipePairs1, Y_pipeBottom1, this.recPipe.Width, this.recPipe.Height));

        }
        public void Draw_Pipe_Above_2(Graphics gfx)
        {
            gfx.DrawImage(picPipeAbove, new RectangleF(X_pipePairs2, Y_pipeAbove2, this.recPipe.Width, this.recPipe.Height));

        }
        public void Draw_Pipe_Bottom_2(Graphics gfx)
        {
            gfx.DrawImage(picPipeBottom, new RectangleF(X_pipePairs2, Y_pipeBottom2, this.recPipe.Width, this.recPipe.Height));

        }
    }
}
