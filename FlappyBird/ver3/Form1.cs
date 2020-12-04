﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Media;

namespace ver3
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        Bird bird = new Bird();
        Pipe pipe = new Pipe();
        Score score = new Score();

        
        Timer bird_Timer = new Timer();

        SoundPlayer soundClick = new SoundPlayer(Properties.Resources.clickSound);
        SoundPlayer soundGameOver = new SoundPlayer(Properties.Resources.SoundGameOver);
        private void Bird_Animator()
        {

            bird_Timer.Interval = 100;
            bird_Timer.Tick += Bird_Timer_Tick;
            bird_Timer.Start();
        }

        private void Playing()
        {
            nutplay.Visible = false;
            pb_Title.Visible = false;
            pictureBox_introBird.Visible = false;
            menu.Visible = false;
            exit.Visible = false;
            lbldiem.Visible = true;
        }

        private void Reset()
        {
            nutplay.Visible = true;
            pb_Title.Visible = true;
            pictureBox_introBird.Visible = true;
            menu.Visible = true;
            exit.Visible = true;

            
            //lbldiem.Visible = false;
            //pb_GameOver.Visible = false;
            //retry.Visible = false;
        }

        private void GameOver()
        {
            timer1.Stop();

            picBoxPipeBottom1.Visible = false;
            picBoxPipeBottom2.Visible = false;
            picBoxPipeAbove1.Visible = false;
            picBoxPipeAbove2.Visible = false;

            pb_GameOver.Visible = true;
            exit.Visible = true;
            retry.Visible = true;

            //bird.soundDie.Play();
            bird.soundHit.Play();

            soundGameOver.Play();
        }

        private void Menu_Show()
        {
            bgMenu.Visible = true;
            lb_sence.Visible = true;
            lb_speed.Visible = true;
            lb_item.Visible = true;
            arrow.Visible = true;

            menu.Visible = false;
            exit.Visible = false;
            nutplay.Visible = false;
        }

        private void Menu_Reset()
        {
            nutplay.Visible = true;
            menu.Visible = true;
            exit.Visible = true;

            bgMenu.Visible = false;
            lb_sence.Visible = false;
            lb_speed.Visible = false;
            lb_item.Visible = false;
            arrow.Visible = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (bird_Timer.Enabled == true)
            {
                e.Graphics.DrawImage(bird.Draw2D_Bird(), bird.X_Bird, bird.Y_Bird);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
           

            pipe.X_pipePairs1 = this.Width + 150;
            pipe.Y_pipeAbove1 = -150;
            picBoxPipeAbove1.Location = new Point(pipe.X_pipePairs1, pipe.Y_pipeAbove1);

            pipe.Y_pipeBottom1 = (250 + pipe.Y_pipeAbove1) + pipe.distance_Between2Pipes;
            picBoxPipeBottom1.Location = new Point(pipe.X_pipePairs1, pipe.Y_pipeBottom1);

            pipe.X_pipePairs2 = pipe.X_pipePairs1 + picBoxPipeAbove1.Width + 250;
            pipe.Y_pipeAbove2 = -150;
            picBoxPipeAbove2.Location = new Point(pipe.X_pipePairs2, pipe.Y_pipeAbove2);

            pipe.Y_pipeBottom2 = (250 + pipe.Y_pipeAbove2) + pipe.distance_Between2Pipes;
            picBoxPipeBottom2.Location = new Point(pipe.X_pipePairs2, pipe.Y_pipeBottom2);



            timer1.Interval = 35;
            //timer2.Interval = 70;
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            pipe.X_pipePairs1 -= 10;
            pipe.X_pipePairs2 -= 10;

            picBoxPipeAbove1.Location = new Point(pipe.X_pipePairs1, pipe.Y_pipeAbove1);
            picBoxPipeBottom1.Location = new Point(pipe.X_pipePairs1, pipe.Y_pipeBottom1);
            picBoxPipeAbove2.Location = new Point(pipe.X_pipePairs2, pipe.Y_pipeAbove2);
            picBoxPipeBottom2.Location = new Point(pipe.X_pipePairs2, pipe.Y_pipeBottom2);

            if (pipe.X_pipePairs1 + picBoxPipeAbove1.Width <= 0)
            {
                score.scoreOfGame++;
                score.soundPoint.Play();
                pipe.X_pipePairs1 = 400 + picBoxPipeAbove2.Width + 150;

                Random cao = new Random();
                pipe.Y_pipeAbove1 = cao.Next(-175, -25);
                pipe.Y_pipeBottom1 = (256 + pipe.Y_pipeAbove1) + pipe.distance_Between2Pipes;
                picBoxPipeAbove1.Location = new Point(pipe.X_pipePairs1, pipe.Y_pipeAbove1);
                picBoxPipeBottom1.Location = new Point(pipe.X_pipePairs1, pipe.Y_pipeBottom1);
            }

            if (pipe.X_pipePairs2 + picBoxPipeAbove2.Width <= 0)
            {
                score.scoreOfGame++;
                score.soundPoint.Play();
                pipe.X_pipePairs2 = 400 + picBoxPipeAbove1.Width + 150;
                Random cao = new Random();
                pipe.Y_pipeAbove2 = cao.Next(-175, -25);
                pipe.Y_pipeBottom2 = (256 + pipe.Y_pipeAbove2) + pipe.distance_Between2Pipes;
                picBoxPipeAbove2.Location = new Point(pipe.X_pipePairs2, pipe.Y_pipeAbove2);
                picBoxPipeBottom2.Location = new Point(pipe.X_pipePairs2, pipe.Y_pipeBottom2);
            }

            lbldiem.Text = score.scoreOfGame.ToString();

        }
        int dem = 0;
        private void nutplay_Click(object sender, EventArgs e)
        {
            soundClick.Play();
            Playing();

            dem++;
            if (dem % 2 != 0)
            {
                timer1.Start();
                //timer2.Start();
                Bird_Animator();
            }
            else
            {
                timer1.Stop();
         
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                bird.Y_Bird -= 50;
                bird.soundWing.Play();
            }
        }

     

        private void Bird_Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            if (bird.Y_Bird + bird.birdPicture.Height <= this.Height && bird.Y_Bird >= 0)
            {
                bird.Y_Bird += 10;
                
                if (bird.X_Bird + bird.birdPicture.Width >= pipe.X_pipePairs1 && bird.X_Bird + bird.birdPicture.Width <= pipe.X_pipePairs1 + picBoxPipeAbove1.Width)
                {
                    if (bird.Y_Bird <= 250 + pipe.Y_pipeAbove1 || bird.Y_Bird + bird.birdPicture.Height >= pipe.Y_pipeBottom1)
                    {
                        GameOver();

                    }
                }
                if (bird.X_Bird + bird.birdPicture.Width >= pipe.X_pipePairs2 && bird.X_Bird + bird.birdPicture.Width <= pipe.X_pipePairs2 + picBoxPipeAbove2.Width)
                {
                    if (bird.Y_Bird <= 250 + pipe.Y_pipeAbove2 || bird.Y_Bird + bird.birdPicture.Height >= pipe.Y_pipeBottom2)
                    {
                        GameOver();

                    }
                }

            }
            else
            {
                GameOver();
                bird.Y_Bird += 10;
                

            }

            if(bird.Y_Bird > this.Height)
            {
                bird.soundHit.Stop();
            }
        }

    


       
        private void exit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            soundClick.Play();
            menu.Visible = false;
            
        }

        private void bgMenu_Paint(object sender, PaintEventArgs e)
        {
            soundClick.Play();
        }

        private void menu_Click_1(object sender, EventArgs e)
        {
            soundClick.Play();
            Menu_Show();
        }

        private void arrow_Click(object sender, EventArgs e)
        {
            soundClick.Play();
            Menu_Reset();
        }

        private void retry_Click(object sender, EventArgs e)
        {
            soundClick.Play();

        }





    }
}
