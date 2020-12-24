using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class CtrlGame
    {
        public void MainScreenOff(Control Play, Control Menu, Control Exit, Control BirdIntro)
        {
            Play.Visible = false;
            Menu.Visible = false;
            Exit.Visible = false;
            BirdIntro.Visible = false;
        }

        public void MainScreenOn(Control Play, Control Menu, Control Exit)
        {
            Play.Visible = true;
            Menu.Visible = true;
            Exit.Visible = true;
            
        }

        public void MenuOn(Control BirdIntro, Control Scene, Control Speed, Control Item, Control BgMenu, Control Back)
        {
            Scene.Visible = true;
            Speed.Visible = true;
            Item.Visible = true;
            BgMenu.Visible = true;
            BirdIntro.Visible = true;
            Back.Visible = true;
        }

        public void MenuOff(Control Scene, Control Speed, Control Item, Control Back)
        {
            Scene.Visible = false;
            Speed.Visible = false;
            Item.Visible = false;
            Back.Visible = false;
        }

        public void SubMenuOn(Control c1, Control c2, Control c3)
        {
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
           
        }

        public void SubMenuOff(Control c1, Control c2, Control c3, Control c4)
        {
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;
                
        }
        public void GameOver(Control c1, Control c2, Control c3)
        {
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
        }

       

    }
}
