using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using WMPLib;
namespace WindowsFormsApplication1
{
    class CtrlGame
    {
        WindowsMediaPlayer soundClick = new WMPLib.WindowsMediaPlayer();
        WindowsMediaPlayer soundStartGame = new WMPLib.WindowsMediaPlayer();

        //string runningPath = AppDomain.CurrentDomain.BaseDirectory;
        string path_SoundClick = string.Format("{0}Resources\\clickSound.wav",
                  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));

        string path_SoundStartGame = string.Format("{0}Resources\\startGame.wav",
                  Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")));


        public void SoundClick()
        {
            soundClick.URL = path_SoundClick;

            soundClick.controls.play();
        }

        public void SoundStartGame()
        {
            soundStartGame.URL = path_SoundStartGame;

            soundStartGame.controls.play();
        }
        public void MainScreenOff(Control Play, Control Menu, Control BirdIntro)
        {
            Play.Visible = false;
            Menu.Visible = false;
          
            BirdIntro.Visible = false;

            // sound click
            SoundClick();
        }

        public void MainScreenOn(Control Play, Control Menu)
        {
            Play.Visible = true;
            Menu.Visible = true;
       

            // sound click
            SoundClick();

        }

        public void MenuOn(Control BirdIntro, Control Scene, Control Speed, Control Item, Control BgMenu, Control Back)
        {
            Scene.Visible = true;
            Speed.Visible = true;
            Item.Visible = true;
            BgMenu.Visible = true;
            BirdIntro.Visible = true;
            Back.Visible = true;

            // sound click
            SoundClick();
        }

        public void MenuOff(Control Scene, Control Speed, Control Item, Control Back)
        {
            Scene.Visible = false;
            Speed.Visible = false;
            Item.Visible = false;
            Back.Visible = false;

            // sound click
            SoundClick();
        }

        public void SubMenuOn(Control c1, Control c2, Control c3)
        {
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;

            // sound click
            SoundClick();
        }

        public void SubMenuOff(Control c1, Control c2, Control c3)
        {
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;

            // sound click
            SoundClick();

        }
      
        public int Check(Control c1, Control c2)
        {
            if (c1.Visible == true) return 1;
            else return 2;
        }

        //public void GameOver( Control c2, Control c3, Control c4, Control c5, Control c6)
        //{

        //    c2.Visible = true;

        //    c3.Visible = false;
        //    c4.Visible = false;
        //    c5.Visible = false;
        //    c6.Visible = false;
        //}

        public void GameOver(Control ga, Pipe pipe)
        {
            
            ga.Visible = true;

            pipe.pipe_Above1_Appearance = false;
            pipe.pipe_Bottom1_Appearance = false;
            pipe.pipe_Above2_Appearance = false;
            pipe.pipe_Bottom2_Appearance = false;
        }

        public void ChooseBgGame(int choose, Form frm)
        {
            if (choose == 1)
            {
                frm.BackgroundImage = Properties.Resources.Bg_Origin__5_;
            }
            else if (choose == 2)
            {
                frm.BackgroundImage = Properties.Resources.BgGame_Christmas;
            }
            else if (choose == 3)
            {
                frm.BackgroundImage = Properties.Resources.BgGame_Halloween;
            }
        }

        public void ChooseBgGameForm1(int choose, Form frm)
        {
            if (choose == 1)
            {
                frm.BackgroundImage = Properties.Resources.ori_bg;
            }
            if (choose == 2)
            {
                frm.BackgroundImage = Properties.Resources.christ_bg;
            }
            if (choose == 3)
            {
                frm.BackgroundImage = Properties.Resources.halo_bg;
            }
        }

    }
}
