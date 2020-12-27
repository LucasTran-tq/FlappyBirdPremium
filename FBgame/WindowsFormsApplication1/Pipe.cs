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

        //string runningPath = AppDomain.CurrentDomain.BaseDirectory;
        string path_SoundPoint = string.Format("{0}Resources\\point.wav",
                  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));


        public PictureBox picBoxPipeAbove1 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            BackgroundImage = new Bitmap(Properties.Resources.chimney1),
            BackgroundImageLayout = ImageLayout.Stretch,

            Location = new System.Drawing.Point(149, -163),

            Name = "picBoxPipeAbove2",
            Size = new System.Drawing.Size(52, 250),
            BorderStyle = BorderStyle.None

        };

        public PictureBox picBoxPipeBottom1 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            BackgroundImage = new Bitmap(Properties.Resources.chimney2),
            BackgroundImageLayout = ImageLayout.Stretch,

            Location = new System.Drawing.Point(149, 300),

            Name = "picBoxPipeAbove2",
            Size = new System.Drawing.Size(52, 250),
            BorderStyle = BorderStyle.None

        };

        public PictureBox picBoxPipeAbove2 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            BackgroundImage = new Bitmap(Properties.Resources.chimney1),
            BackgroundImageLayout = ImageLayout.Stretch,

            Location = new System.Drawing.Point(300, -173),

            Name = "picBoxPipeAbove2",
            Size = new System.Drawing.Size(52, 250),
            BorderStyle = BorderStyle.None

        };

        public PictureBox picBoxPipeBottom2 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            BackgroundImage = new Bitmap(Properties.Resources.chimney2),
            BackgroundImageLayout = ImageLayout.Stretch,

            Location = new System.Drawing.Point(149, 300),

            Name = "picBoxPipeAbove2",
            Size = new System.Drawing.Size(52, 250),
            BorderStyle = BorderStyle.None

        };

        public void SoundPoint()
        {
            sound.URL = path_SoundPoint;

            sound.controls.play();
        }

        public void DrawPipe(Form frm, Pipe pipe)
        {

            X_pipePairs1 = frm.Width + 150;
            Y_pipeAbove1 = -150;
            picBoxPipeAbove1.Location = new Point(X_pipePairs1, Y_pipeAbove1);

            Y_pipeBottom1 = (pipe.picBoxPipeBottom1.Height + Y_pipeAbove1) + distance_Between2Pipes;
            picBoxPipeBottom1.Location = new Point(X_pipePairs1, Y_pipeBottom1);

            X_pipePairs2 = X_pipePairs1 + 300;
            Y_pipeAbove2 = -100;
            picBoxPipeAbove2.Location = new Point(X_pipePairs2, Y_pipeAbove2);

            Y_pipeBottom2 = (pipe.picBoxPipeBottom1.Height + Y_pipeAbove2) + distance_Between2Pipes;
            picBoxPipeBottom2.Location = new Point(X_pipePairs2, Y_pipeBottom2);
        }

       
        public void PipeInGame(Form form, Pipe pipe, Bird bird)
        {
            if (bird.isGetGift)
            {
                X_pipePairs1 -= 20;
                X_pipePairs2 -= 20;
            }
            else
            {
                X_pipePairs1 -= 5;
                X_pipePairs2 -= 5;
            }
            

            picBoxPipeAbove1.Location = new Point(X_pipePairs1, Y_pipeAbove1);
            picBoxPipeBottom1.Location = new Point(X_pipePairs1, Y_pipeBottom1);
            picBoxPipeAbove2.Location = new Point(X_pipePairs2, Y_pipeAbove2);
            picBoxPipeBottom2.Location = new Point(X_pipePairs2, Y_pipeBottom2);

            if (X_pipePairs1 + picBoxPipeAbove1.Width <= -10)
            {
                
                X_pipePairs1 = form.Width + 150;

                Y_pipeAbove1 = random_height_Y_pipe.Next(-150, -10);

                Y_pipeBottom1 = (pipe.picBoxPipeBottom1.Height + Y_pipeAbove1) + distance_Between2Pipes;

                picBoxPipeAbove1.Location = new Point(X_pipePairs1, Y_pipeAbove1);
                picBoxPipeBottom1.Location = new Point(X_pipePairs1, Y_pipeBottom1);
            }

            if (X_pipePairs2 + picBoxPipeAbove2.Width <= -10)
            {
               
                X_pipePairs2 = form.Width + 150;
                
                Y_pipeAbove2 = random_height_Y_pipe.Next(-150, -10);

                Y_pipeBottom2 = (pipe.picBoxPipeBottom1.Height + Y_pipeAbove2) + distance_Between2Pipes;

                picBoxPipeAbove2.Location = new Point(X_pipePairs2, Y_pipeAbove2);
                picBoxPipeBottom2.Location = new Point(X_pipePairs2, Y_pipeBottom2);
            }

        }

    }
}
