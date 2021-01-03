using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using WMPLib;
using System.IO;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bird bird = new Bird();
        
        Pipe pipe = new Pipe();
        CtrlGame ctr = new CtrlGame();

        string Pic;

        string filePathOfImage = Environment.CurrentDirectory + "/" + "iHighscore.txt";
        string filePathOfScore = Environment.CurrentDirectory + "/" + "score.txt";
        string filePathOfName = Environment.CurrentDirectory + "/" + "name.txt";
      //  string filePathOfTemp = Environment.CurrentDirectory + "/" + "highscore.txt";
        string defaultLinkOfImage = Environment.CurrentDirectory + "/" + "defaultAva.png";
        OpenFileDialog pictureDialog = new OpenFileDialog();
        HighScoreInfo highScore = new HighScoreInfo();
        Form2 myForm = new Form2();
        Cursor cur;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.ori_bg;

            cur = new Cursor(Properties.Resources.cursorOrigin.Handle);
            this.Cursor = cur;

            string scoreInText = null;
            lb_highscore.Text = highScore.Read(scoreInText, filePathOfScore);


            string nameInText = null;
            label_name.Text = highScore.Read(nameInText, filePathOfName);


            string imageInText = null;

            var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(highScore.Read(imageInText, filePathOfImage))));
            pB_playerHighSorce.Image = img;

            timer1.Start();

           
            myForm.TopLevel = false;
            myForm.AutoScroll = false;
            this.pl_ScreenGame.Controls.Add(myForm);
            myForm.Show();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btt_exit3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string scoreInText = null;

            string highScoreTemp = highScore.Read(scoreInText, filePathOfScore);

            string nameInText = null;
            label_name.Text = highScore.Read(nameInText, filePathOfName);

            if (myForm.buttonOriWasClicked == true)
            {
                myForm.buttonOriWasClicked = false;
              //  myForm.buttonHaloWasClicked = false;
             //   myForm.buttonChristWasClicked = false;

                cur = new Cursor(Properties.Resources.cursorOrigin.Handle);
                ctr.ChooseBgGameForm1(1, this);
                pictureBox1.BackgroundImage = Properties.Resources.ori_logo;
                panel1.BackgroundImage = Properties.Resources.ori_fame;
            }

          //  myForm.buttonHaloWasClicked = true;
           // myForm.buttonChristWasClicked = false;

            else if (myForm.buttonChristWasClicked == true)
            {
                myForm.buttonChristWasClicked = false;
              //  myForm.buttonOriWasClicked = false;
             //   myForm.buttonHaloWasClicked = false;
                cur = new Cursor(Properties.Resources.cursorChristmas.Handle);
                ctr.ChooseBgGameForm1(2, this);
                pictureBox1.BackgroundImage = Properties.Resources.christt_logo;
                panel1.BackgroundImage = Properties.Resources.christ_frame;
            }

            else  if (myForm.buttonHaloWasClicked == true)
            {
                myForm.buttonHaloWasClicked = false;
              //  myForm.buttonOriWasClicked = false;
              //  myForm.buttonChristWasClicked = false;
                cur = new Cursor(Properties.Resources.cursorHallo.Handle);
                ctr.ChooseBgGameForm1(3, this);
                pictureBox1.BackgroundImage = Properties.Resources.halo_logo;
                panel1.BackgroundImage = Properties.Resources.halo_frame;
            }

            if (myForm.timer1.Enabled == false)
            {
                
                if (int.Parse(highScoreTemp) > int.Parse(lb_highscore.Text) && myForm.timer1.Enabled == false)
                {
                    myForm.ga.Visible = false;
                    myForm.label1.Visible = false;
                    myForm.gif.Visible = true;


                    //pipe.picBoxPipeAbove1.Visible = false;
                    //pipe.picBoxPipeAbove2.Visible = false;
                    //pipe.picBoxPipeBottom1.Visible = false;

                    //pipe.picBoxPipeBottom2.Visible = false;

                    pipe.pipe_Above1_Appearance = false;
                    pipe.pipe_Bottom2_Appearance = false;
                    pipe.pipe_Above1_Appearance = false;
                    pipe.pipe_Bottom2_Appearance = false;

                    lb_highscore.Text = highScoreTemp;
                    label_name.Text = tB_playerName.Text;
                    highScore.Write(label_name.Text, filePathOfName);

                    pB_playerHighSorce.Image = pB_Player.Image;

                    byte[] imageArray = System.IO.File.ReadAllBytes(defaultLinkOfImage);
                    string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    Pic = base64ImageRepresentation;
                    highScore.Write(base64ImageRepresentation, filePathOfImage);


                }

            }
        }
       
        private void btt_replay_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //private void Form1_Click(object sender, EventArgs e)
        //{
        //    if (Properties.Settings.Default.Bg == "2")
        //    {
               
        //        ctr.ChooseBgGameForm1(2, this);
        //        pictureBox1.BackgroundImage = Properties.Resources.christt_logo;
        //        panel1.BackgroundImage = Properties.Resources.christ_frame;
        //    }

        //    else if (Properties.Settings.Default.Bg == "3")
        //    {
        //        cur = new Cursor(Properties.Resources.cursorHallo.Handle);
        //        ctr.ChooseBgGameForm1(3, this);
        //        pictureBox1.BackgroundImage = Properties.Resources.halo_logo;
        //        panel1.BackgroundImage = Properties.Resources.halo_frame;
        //    }
        //    else if (Properties.Settings.Default.Bg == "1")
        //    {
                
        //        ctr.ChooseBgGameForm1(1, this);
        //        pictureBox1.BackgroundImage = Properties.Resources.ori_logo;
        //        panel1.BackgroundImage = Properties.Resources.ori_fame;


        //    }
                

        //    this.Cursor = cur;
        //}

        private void pl_ScreenGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pB_Player_Click(object sender, EventArgs e)
        {
            pictureDialog.Filter = "Image Files(.jpg; *.jpeg; *.gif; *.bmp; *.png)|.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {

                Bitmap image = new Bitmap(pictureDialog.FileName);
                pB_Player.Image = image;
                defaultLinkOfImage = pictureDialog.FileName;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lb_highscore_Click(object sender, EventArgs e)
        {

        }

      
        

        
        
        

       

       
    }
}
