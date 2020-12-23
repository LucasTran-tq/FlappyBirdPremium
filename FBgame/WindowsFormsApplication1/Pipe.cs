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

namespace WindowsFormsApplication1
{
    class Pipe
    {
        public int Y_pipeAbove1, Y_pipeAbove2;

        public int Y_pipeBottom1, Y_pipeBottom2;

        public int distance_Between2Pipes = 125;

        public int X_pipePairs1, X_pipePairs2;

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


        public void DrawPipe(Form frm)
        {

            X_pipePairs1 = frm.Width + 150;
            Y_pipeAbove1 = -150;
            picBoxPipeAbove1.Location = new Point(X_pipePairs1, Y_pipeAbove1);

            Y_pipeBottom1 = (250 + Y_pipeAbove1) + distance_Between2Pipes;
            picBoxPipeBottom1.Location = new Point(X_pipePairs1, Y_pipeBottom1);

            X_pipePairs2 = X_pipePairs1 + picBoxPipeAbove1.Width + 250;
            Y_pipeAbove2 = -150;
            picBoxPipeAbove2.Location = new Point(X_pipePairs2, Y_pipeAbove2);

            Y_pipeBottom2 = (250 + Y_pipeAbove2) + distance_Between2Pipes;
            picBoxPipeBottom2.Location = new Point(X_pipePairs2, Y_pipeBottom2);
        }

        public void PipeInGame()
        {

            X_pipePairs1 -= 5;
            X_pipePairs2 -= 5;

            picBoxPipeAbove1.Location = new Point(X_pipePairs1, Y_pipeAbove1);
            picBoxPipeBottom1.Location = new Point(X_pipePairs1, Y_pipeBottom1);
            picBoxPipeAbove2.Location = new Point(X_pipePairs2, Y_pipeAbove2);
            picBoxPipeBottom2.Location = new Point(X_pipePairs2, Y_pipeBottom2);

            if (X_pipePairs1 + picBoxPipeAbove1.Width <= 0)
            {

                X_pipePairs1 = 400 + picBoxPipeAbove2.Width + 150;

                Random cao = new Random();
                Y_pipeAbove1 = cao.Next(-175, -25);
                Y_pipeBottom1 = (256 + Y_pipeAbove1) + distance_Between2Pipes;
                picBoxPipeAbove1.Location = new Point(X_pipePairs1, Y_pipeAbove1);
                picBoxPipeBottom1.Location = new Point(X_pipePairs1, Y_pipeBottom1);
            }

            if (X_pipePairs2 + picBoxPipeAbove2.Width <= 0)
            {

                X_pipePairs2 = 400 + picBoxPipeAbove1.Width + 150;
                Random cao = new Random();
                Y_pipeAbove2 = cao.Next(-175, -25);
                Y_pipeBottom2 = (256 + Y_pipeAbove2) + distance_Between2Pipes;
                picBoxPipeAbove2.Location = new Point(X_pipePairs2, Y_pipeAbove2);
                picBoxPipeBottom2.Location = new Point(X_pipePairs2, Y_pipeBottom2);
            }

        }

    }
}
