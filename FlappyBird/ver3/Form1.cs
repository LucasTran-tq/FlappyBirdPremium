using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

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

        int X_ConChim, Y_ConChim;

        int DoLech = 125;

        int X_CapOng1, X_CapOng2;

        int Diem = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Left = 0;
            this.Top = 0;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            X_CapOng1 = this.Width + 150;
            Y_OngTren1 = -150;
            ongtren1.Size = new Size(44, 256);
            ongtren1.Location = new Point(X_CapOng1, Y_OngTren1);
            Y_OngDuoi1 = (256 + Y_OngTren1) + DoLech;
            ongduoi1.Size = new Size(44, 256);
            ongduoi1.Location = new Point(X_CapOng1, Y_OngDuoi1);

            X_CapOng2 = X_CapOng1 + ongtren1.Width + 250;
            Y_OngTren2 = -150;
            ongtren2.Size = new Size(44, 256);
            ongtren2.Location = new Point(X_CapOng2, Y_OngTren2);
            Y_OngDuoi2 = (256 + Y_OngTren2) + DoLech;
            ongduoi2.Size = new Size(44, 256);
            ongduoi2.Location = new Point(X_CapOng2, Y_OngDuoi2);

            conchim.Size = new Size(50, 43);
            X_ConChim = conchim.Location.X;
            Y_ConChim = conchim.Location.Y;

            nutplay.Size = new System.Drawing.Size(35, 35);

            lbldiem.Location = new Point(0, this.Height - 25);

            timer1.Interval = 35;
            timer2.Interval = 70;
               
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

            lbldiem.Text = "Score: " + Diem.ToString();

        }
        int dem = 0;
        private void nutplay_Click(object sender, EventArgs e)
        {
            dem++;
            if (dem % 2 != 0)
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Y_ConChim -= 50;
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            if (Y_ConChim + conchim.Height <= this.Height)
            {
                Y_ConChim += 10;
                conchim.Location = new Point(X_ConChim, Y_ConChim);

                if (X_ConChim + conchim.Width >= X_CapOng1 && X_ConChim + conchim.Width <= X_CapOng1 + ongtren1.Width)
                {
                    if (Y_ConChim <= 256 + Y_OngTren1 || Y_ConChim + conchim.Height >= Y_OngDuoi1)
                    {
                        timer1.Stop();
                    }
                }
                if (X_ConChim + conchim.Width >= X_CapOng2 && X_ConChim + conchim.Width <= X_CapOng2 + ongtren2.Width)
                {
                    if (Y_ConChim <= 256 + Y_OngTren2 || Y_ConChim + conchim.Height >= Y_OngDuoi2)
                    {
                        timer1.Stop();
                    }
                }

            }
            else
            {
                timer1.Stop();
                timer2.Stop();
            }

        }

       

       
        

       
    }
}
