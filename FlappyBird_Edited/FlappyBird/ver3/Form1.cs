using System;
using System.Drawing;
using System.Windows.Forms;

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
           

            pipe.X_pipePair1 = this.Width + 150;
            pipe.Y_pipeAbove1 = -150;
            
            ongtren1.Location = new Point(pipe.X_pipePair1, pipe.Y_pipeAbove1);
            pipe.Y_pipeBottom1 = (250 + pipe.Y_pipeAbove1) + pipe.Distance_Between2Pipes;
        
            ongduoi1.Location = new Point(pipe.X_pipePair1, pipe.Y_pipeBottom1);

            pipe.X_pipePair2 = pipe.X_pipePair1 + ongtren1.Width + 250;
            pipe.Y_pipeAbove2 = -150;
          
            ongtren2.Location = new Point(pipe.X_pipePair2, pipe.Y_pipeAbove2);
            pipe.Y_pipeBottome2 = (250 + pipe.Y_pipeAbove2) + pipe.Distance_Between2Pipes;
           
            ongduoi2.Location = new Point(pipe.X_pipePair2, pipe.Y_pipeBottome2);



            timer1.Interval = 35;

            

            //timer2.Interval = 70;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            pipe.X_pipePair1 -= 10;
            pipe.X_pipePair2 -= 10;

            ongtren1.Location = new Point(pipe.X_pipePair1, pipe.Y_pipeAbove1);
            ongduoi1.Location = new Point(pipe.X_pipePair1, pipe.Y_pipeBottom1);
            ongtren2.Location = new Point(pipe.X_pipePair2, pipe.Y_pipeAbove2);
            ongduoi2.Location = new Point(pipe.X_pipePair2, pipe.Y_pipeBottome2);

            if (pipe.X_pipePair1 + ongtren1.Width <= 0)
            {
                score.scoreOfGame++;

                pipe.X_pipePair1 = 400 + ongtren2.Width + 150;

                Random cao = new Random();
                pipe.Y_pipeAbove1 = cao.Next(-175, -25);
                pipe.Y_pipeBottom1 = (256 + pipe.Y_pipeAbove1) + pipe.Distance_Between2Pipes;
                ongtren1.Location = new Point(pipe.X_pipePair1, pipe.Y_pipeAbove1);
                ongduoi1.Location = new Point(pipe.X_pipePair1, pipe.Y_pipeBottom1);
            }

            if (pipe.X_pipePair2 + ongtren2.Width <= 0)
            {
                score.scoreOfGame++;
                pipe.X_pipePair2 = 400 + ongtren1.Width + 150;
                Random cao = new Random();
                pipe.Y_pipeAbove2 = cao.Next(-175, -25);
                pipe.Y_pipeBottome2 = (256 + pipe.Y_pipeAbove2) + pipe.Distance_Between2Pipes;
                ongtren2.Location = new Point(pipe.X_pipePair2, pipe.Y_pipeAbove2);
                ongduoi2.Location = new Point(pipe.X_pipePair2, pipe.Y_pipeBottome2);
            }

            lbldiem.Text = score.scoreOfGame.ToString();

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
                
                if (bird.X_Bird + bird.birdPicture.Width >= pipe.X_pipePair1 && bird.X_Bird + bird.birdPicture.Width <= pipe.X_pipePair1 + ongtren1.Width)
                {
                    if (bird.Y_Bird <= 250 + pipe.Y_pipeAbove1 || bird.Y_Bird + bird.birdPicture.Height >= pipe.Y_pipeBottom1)
                    {
                        timer1.Stop();
                       
                        pb_GameOver.Visible = true;

                        ongduoi1.Visible = false;
                        ongduoi2.Visible = false;
                        ongtren1.Visible = false;
                        ongtren2.Visible = false;

                      

                      
                    }
                }
                if (bird.X_Bird + bird.birdPicture.Width >= pipe.X_pipePair2 && bird.X_Bird + bird.birdPicture.Width <= pipe.X_pipePair2 + ongtren2.Width)
                {
                    if (bird.Y_Bird <= 250 + pipe.Y_pipeAbove2 || bird.Y_Bird + bird.birdPicture.Height >= pipe.Y_pipeBottome2)
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
