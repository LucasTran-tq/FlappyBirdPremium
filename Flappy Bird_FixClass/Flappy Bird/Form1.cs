using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class BackgroundGame : Form 
    {
      
        ColGame clg = new ColGame();
        Pipe pipe = new Pipe();
        Bird bird = new Bird();
       
        public BackgroundGame()
        {
            InitializeComponent();
        }

        private void BackgroundGame_Load(object sender, EventArgs e)
        {
            pl_ScreenGame.Controls.Add(clg.picBoxPipeAbove1);
            pl_ScreenGame.Controls.Add(clg.picBoxPipeAbove2);
            pl_ScreenGame.Controls.Add(clg.picBoxPipeBottom1);
            pl_ScreenGame.Controls.Add(clg.picBoxPipeBottom2);

            pipe.DrawPipe(pl_ScreenGame, clg.picBoxPipeAbove1, clg.picBoxPipeAbove2, clg.picBoxPipeBottom1, clg.picBoxPipeBottom2);
        }

        private void BackgroundGame_Click(object sender, EventArgs e)
        {
            clg.GameOver(pB_GameOver, btt_exit2, btt_replay);  
        }

        private void btt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btt_Menu_Click(object sender, EventArgs e)
        {
            clg.MainScreenOff(btt_Play, btt_Menu, btt_Exit, pB_IntroBird);
            clg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            pipe.PipeInGame(pl_ScreenGame, clg.picBoxPipeAbove1, clg.picBoxPipeAbove2, clg.picBoxPipeBottom1, clg.picBoxPipeBottom2);
        }

        private void btt_Play_Click(object sender, EventArgs e)
        {
            clg.MainScreenOff(btt_Play, btt_Menu, btt_Exit, pB_IntroBird);

            timer1.Start();  
        }

        private void btt_replay_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btt_speed_Click(object sender, EventArgs e)
        {
            clg.MenuOff(btt_scene, btt_speed, btt_item);
            clg.SubMenuOn(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium, btt_Back);

        }

        private void btt_Back_Click(object sender, EventArgs e)
        {
            clg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu);
        }

      
    

      
       

        
    }
}
