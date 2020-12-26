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

        Form2 myForm = new Form2();
        private void Form1_Load(object sender, EventArgs e)
        {
           
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
    }
}
