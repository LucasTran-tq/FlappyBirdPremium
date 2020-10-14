using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Version1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x_ongtren1, y_ongtren1;
        int x_ongduoi1, y_ongduoi1;

        int x_ongtren2, y_ongtren2;
        int x_ongduoi2, y_ongduoi2;

        
        int x_cap1, x_cap2;

        

        int x_bird, y_bird;


        int doChenhLech = 300;
        private void Form1_Load(object sender, EventArgs e)
        {
            
            this.FormBorderStyle = FormBorderStyle.None;
            this.Left = 0;
            this.Top = 0;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            

            // create ongtren1
            x_cap1 = this.Width + 300;
            //x_ongtren1 = this.Width + 300;

            y_ongtren1 = -300; // ongtren1.height + y_ongtren1 = do cao hien thi
            ongtren1.Size = new Size(89, 512);
            ongtren1.Location = new Point(x_cap1, y_ongtren1);

            // do cao ongduoi1 = y_ongtren1 + ongtren1.height + Dochenhlech

            // create ongduoi1
            //x_ongduoi1 = this.Width + 300;

            y_ongduoi1 = y_ongtren1 + 512 + doChenhLech;
            ongduoi1.Size = new Size(89, 512);
            ongduoi1.Location = new Point(x_cap1, y_ongduoi1);


            // create ongtren2
            x_cap2 = x_cap1 + ongtren1.Width + 500;
            //x_ongtren2 = x_ongtren1 + ongtren1.Width + 300;
            y_ongtren2 = -300;
            ongtren2.Size = new Size(89, 512);
            ongtren2.Location = new Point(x_cap2, y_ongtren2);


            // create ongduoi2
            //x_ongduoi2 = x_ongduoi1 + ongduoi1.Width + 300;
            y_ongduoi2 = y_ongtren2 + 512 + doChenhLech;
            ongduoi2.Size = new Size(89, 512);
            ongduoi2.Location = new Point(x_cap2, y_ongduoi2);


            // create bird 
            bird.Size = new Size(100, 87);

            x_bird = bird.Location.X;
            y_bird = bird.Location.Y;

            timer1.Interval = 30;
            timer1.Start();

            //MessageBox.Show(this.Width + " " + this.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x_cap1 -= 10;
            x_cap2 -= 10;
            //x_ongtren1 = this.Width + 300;

            //y_ongtren1 = -300; // ongtren1.height + y_ongtren1 = do cao hien thi
            //ongtren1.Size = new Size(89, 512);
            ongtren1.Location = new Point(x_cap1, y_ongtren1);

            // do cao ongduoi1 = y_ongtren1 + ongtren1.height + Dochenhlech

            // create ongduoi1
            //x_ongduoi1 = this.Width + 300;

            //y_ongduoi1 = y_ongtren1 + 512 + doChenhLech;
            //ongduoi1.Size = new Size(89, 512);
            ongduoi1.Location = new Point(x_cap1, y_ongduoi1);


            // create ongtren2

            //x_cap2 = x_cap1 + ongtren1.Width + 300;

            //x_ongtren2 = x_ongtren1 + ongtren1.Width + 300;
            //y_ongtren2 = -300;
            //ongtren2.Size = new Size(89, 512);
            ongtren2.Location = new Point(x_cap2, y_ongtren2);


            // create ongduoi2
            //x_ongduoi2 = x_ongduoi1 + ongduoi1.Width + 300;
            //y_ongduoi2 = y_ongtren2 + 512 + doChenhLech;
            //ongduoi2.Size = new Size(89, 512);
            ongduoi2.Location = new Point(x_cap2, y_ongduoi2);


            // site location again when chimney is behind the screen
            if(x_cap1 + ongtren1.Width <= 0)
            {
                x_cap1 = 800 + ongtren2.Width + 300; // 300 is between 2 chimneys

                Random random = new Random();
                y_ongtren1 = random.Next(-350, -50);
                y_ongduoi1 = y_ongtren1 + 512 + doChenhLech;

                ongtren1.Location = new Point(x_cap1, y_ongtren1);
                ongduoi1.Location = new Point(x_cap1, y_ongduoi1);

            }

            if (x_cap2 + ongtren2.Width <= 0)
            {
                x_cap2 = 800 + ongtren1.Width + 300; // 300 is between 2 chimneys

                Random random = new Random();
                y_ongtren2 = random.Next(-350, -50);
                y_ongduoi2 = y_ongtren2 + 512 + doChenhLech;

                ongtren2.Location = new Point(x_cap2, y_ongtren2);
                ongduoi2.Location = new Point(x_cap2, y_ongduoi2);

            }

            y_bird += 5;
            bird.Location = new Point(x_bird, y_bird);

            if(x_bird + bird.Width >= x_cap1 && x_bird + bird.Width <= x_cap1 + ongtren1.Width)
            {
                if(y_bird <= y_ongtren1 + 512 || y_bird + bird.Height >= y_ongduoi1)
                {
                    timer1.Stop();
                }
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                y_bird -= 50;

                bird.Location = new Point(x_bird, y_bird);


            }

        }
    }
}
