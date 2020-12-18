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

namespace Flappy_Bird
{
    class Pipe 
    {
        public int Y_pipeAbove1, Y_pipeAbove2;

        public int Y_pipeBottom1, Y_pipeBottom2;


        public int distance_Between2Pipes = 125;

        public int X_pipePairs1, X_pipePairs2;
        

        public void DrawPipe(Control pl, PictureBox picBoxPipeAbove1, PictureBox picBoxPipeBottom1,
            PictureBox picBoxPipeAbove2, PictureBox picBoxPipeBottom2)
        {

            X_pipePairs1 = pl.Width + 150;
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

        public void PipeInGame(Control pl, PictureBox picBoxPipeAbove1, PictureBox picBoxPipeBottom1,
           PictureBox picBoxPipeAbove2, PictureBox picBoxPipeBottom2)
        {

            X_pipePairs1 -= 10;
            X_pipePairs2 -= 10;

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
                picBoxPipeBottom2.Location = new Point(X_pipePairs2,Y_pipeBottom2);
            }

        }
    }
}
