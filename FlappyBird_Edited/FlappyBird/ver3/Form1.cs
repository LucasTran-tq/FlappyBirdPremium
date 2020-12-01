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

namespace ver3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Y_OngTren1, Y_OngTren2;

        int Y_OngDuoi1, Y_OngDuoi2;

        int DoLech = 125;

        int X_CapOng1, X_CapOng2;

        int Diem = 0;

        
        


        Bird bird = new Bird();
        

       

        

       

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (bird.bird_Timer.Enabled == true)
            {
                e.Graphics.DrawImage( bird.Draw2D_Bird(), bird.X_Bird, bird.Y_Bird);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
           

            X_CapOng1 = this.Width + 150;
            Y_OngTren1 = -150;
            
            ongtren1.Location = new Point(X_CapOng1, Y_OngTren1);
            Y_OngDuoi1 = (250 + Y_OngTren1) + DoLech;
        
            ongduoi1.Location = new Point(X_CapOng1, Y_OngDuoi1);

            X_CapOng2 = X_CapOng1 + ongtren1.Width + 250;
            Y_OngTren2 = -150;
          
            ongtren2.Location = new Point(X_CapOng2, Y_OngTren2);
            Y_OngDuoi2 = (250 + Y_OngTren2) + DoLech;
           
            ongduoi2.Location = new Point(X_CapOng2, Y_OngDuoi2);



            timer1.Interval = 35;

            bird.bird_Timer.Tick += Bird_Timer_Tick;

            //timer2.Interval = 70;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            X_CapOng1 -= 10;
            X_CapOng2 -= 10;

            ongtren1.Location = new Point(X_CapOng1, Y_OngTren1);
            ongduoi1.Location = new Point(X_CapOng1, Y_OngDuoi1);
            ongtren2.Location = new Point(X_CapOng2, Y_OngTren2);
            ongduoi2.Location = new Point(X_CapOng2, Y_OngDuoi2);

            if (X_CapOng1 + ongtren1.Width <= 0)
            {
                Diem++;

                X_CapOng1 = 400 + ongtren2.Width + 150;

                Random cao = new Random();
                Y_OngTren1 = cao.Next(-175, -25);
                Y_OngDuoi1 = (256 + Y_OngTren1) + DoLech;
                ongtren1.Location = new Point(X_CapOng1, Y_OngTren1);
                ongduoi1.Location = new Point(X_CapOng1, Y_OngDuoi1);
            }

            if (X_CapOng2 + ongtren2.Width <= 0)
            {
                Diem++;
                X_CapOng2 = 400 + ongtren1.Width + 150;
                Random cao = new Random();
                Y_OngTren2 = cao.Next(-175, -25);
                Y_OngDuoi2 = (256 + Y_OngTren2) + DoLech;
                ongtren2.Location = new Point(X_CapOng2, Y_OngTren2);
                ongduoi2.Location = new Point(X_CapOng2, Y_OngDuoi2);
            }

            lbldiem.Text = Diem.ToString();

        }
        int dem = 0;
        private void nutplay_Click(object sender, EventArgs e)
        {
            nutplay.Visible = false;
            pb_Title.Visible = false;

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
            }

            //if (e.KeyCode == Keys.A)
            //{
            //    Bird_Animator();
            //}
            //if (e.KeyCode == Keys.D)
            //{
            //    bird_Timer.Stop();
            //}

        }

     

        private void Bird_Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();

            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            if (bird.Y_Bird + bird.birdPicture.Height <= this.Height)
            {
                bird.Y_Bird += 10;
                
                if (bird.X_Bird + bird.birdPicture.Width >= X_CapOng1 && bird.X_Bird + bird.birdPicture.Width <= X_CapOng1 + ongtren1.Width)
                {
                    if (bird.Y_Bird <= 250 + Y_OngTren1 || bird.Y_Bird + bird.birdPicture.Height >= Y_OngDuoi1)
                    {
                        timer1.Stop();
                       
                        pb_GameOver.Visible = true;

                        ongduoi1.Visible = false;
                        ongduoi2.Visible = false;
                        ongtren1.Visible = false;
                        ongtren2.Visible = false;

                      

                      
                    }
                }
                if (bird.X_Bird + bird.birdPicture.Width >= X_CapOng2 && bird.X_Bird + bird.birdPicture.Width <= X_CapOng2 + ongtren2.Width)
                {
                    if (bird.Y_Bird <= 250 + Y_OngTren2 || bird.Y_Bird + bird.birdPicture.Height >= Y_OngDuoi2)
                    {
                        timer1.Stop();
                        pb_GameOver.Visible = true;

                        ongduoi1.Visible = false;
                        ongduoi2.Visible = false;
                        ongtren1.Visible = false;
                        ongtren2.Visible = false;

                    

                       
                    }
                }

            }
            else
            {
                timer1.Stop();

                bird.bird_Timer.Stop();
                pb_GameOver.Visible = true;

                ongduoi1.Visible = false;
                ongduoi2.Visible = false;
                ongtren1.Visible = false;
                ongtren2.Visible = false;

                
              
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void lbldiem_Click(object sender, EventArgs e)
        {

        }

        private void ongtren1_Paint(object sender, PaintEventArgs e)
        {
            
        }





    }
}