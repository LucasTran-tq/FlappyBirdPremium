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
        //Form2 myForm = new Form2();
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

        private void Form1_Load(object sender, EventArgs e)
        {
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
            if (e.KeyCode == Keys.Enter)
                pB_Player.Visible = false; 
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

            if (myForm.timer1.Enabled == false)
            {
                
                if (int.Parse(highScoreTemp) > int.Parse(lb_highscore.Text) && myForm.timer1.Enabled == false)
                {
                    myForm.pictureBox1.Visible = true;
                    myForm.button1.Visible = true;
                    pipe.picBoxPipeAbove1.Visible = false;
                    pipe.picBoxPipeAbove2.Visible = false;
                    pipe.picBoxPipeBottom1.Visible = false;
                    
                    pipe.picBoxPipeBottom2.Visible = false;
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
        private void bT_change_Click(object sender, EventArgs e)
        {
            pictureDialog.Filter = "Image Files(.jpg; *.jpeg; *.gif; *.bmp; *.png)|.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (pictureDialog.ShowDialog() == DialogResult.OK)
            {

                Bitmap image = new Bitmap(pictureDialog.FileName);
                pB_Player.Image = image;
                defaultLinkOfImage = pictureDialog.FileName;

            }
        }

        //private void Close_Click(object sender, EventArgs e)
        //{
        //    pictureBox1.Visible = false;
        //    Close.Visible = false;
        //}

        
        

       

       
    }
}
