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
        public void MainScreenOff(Control Play, Control Menu, Control Exit, Control BirdIntro)
        {
            Play.Visible = false;
            Menu.Visible = false;
            Exit.Visible = false;
            BirdIntro.Visible = false;

            // sound click
            SoundClick();
        }

        public void MainScreenOn(Control Play, Control Menu, Control Exit)
        {
            Play.Visible = true;
            Menu.Visible = true;
            Exit.Visible = true;

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

        public void SubMenuOff(Control c1, Control c2, Control c3, Control c4)
        {
            c1.Visible = false;
            c2.Visible = false;
            c3.Visible = false;
            c4.Visible = false;

            // sound click
            SoundClick();

        }
        public void GameOver(Control c1, Control c2, Control c3)
        {
            c1.Visible = true;
            c2.Visible = true;
            c3.Visible = true;
        }

       

    }
}
