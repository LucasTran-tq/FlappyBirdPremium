using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Guna.UI.WinForms;

namespace Flappy_Bird
{
    class ColGame 
    {
        public void MainScreenOff(Control Play, Control Menu, Control Exit, Control BirdIntro)
        {
            Play.Visible = false;
            Menu.Visible = false;
            Exit.Visible = false;
            BirdIntro.Visible = false;
        }

        public void MenuOn(Control BirdIntro, Control Scene, Control Speed, Control Item, Control BgMenu)
        {   
            Scene.Visible = true;
            Speed.Visible = true;
            Item.Visible = true;
            BgMenu.Visible = true;
            BirdIntro.Visible = true;
        }

        public void MenuOff(Control Scene, Control Speed, Control Item)
        {
            Scene.Visible = false;
            Speed.Visible = false;
            Item.Visible = false;
           
        }

        public void SubMenuOn(Control c1, Control c2, Control c3, Control c4)
        {
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
            c4.Visible = true;
        }

        public void GameOver(Control c, Control c1, Control c2)
        {
            c.Visible = true;
            c1.Visible = true;
            c2.Visible = true;
        }

        public PictureBox picBoxPipeAbove1 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = new Bitmap(Properties.Resources.chimney1),
            Location = new System.Drawing.Point(149, -163),
            Margin = new System.Windows.Forms.Padding(2),
            Name = "picBoxPipeAbove2",
            Size = new System.Drawing.Size(52, 250),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        };

        public PictureBox picBoxPipeBottom1 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = new Bitmap(Properties.Resources.chimney1),
            Location = new System.Drawing.Point(149, 300),
            Margin = new System.Windows.Forms.Padding(2),
            Name = "picBoxPipeAbove2",
            Size = new System.Drawing.Size(52, 250),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        };

        public PictureBox picBoxPipeAbove2 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = new Bitmap(Properties.Resources.chimney2),
            Location = new System.Drawing.Point(300, -173),
            Margin = new System.Windows.Forms.Padding(2),
            Name = "picBoxPipeAbove2",
            Size = new System.Drawing.Size(52, 250),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        };

        public PictureBox picBoxPipeBottom2 = new PictureBox()
        {
            BackColor = System.Drawing.Color.Transparent,
            Image = new Bitmap(Properties.Resources.chimney2),
            Location = new System.Drawing.Point(149, 300),
            Margin = new System.Windows.Forms.Padding(2),
            Name = "picBoxPipeAbove2",
            Size = new System.Drawing.Size(52, 250),
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        };

   
     
    }
}
