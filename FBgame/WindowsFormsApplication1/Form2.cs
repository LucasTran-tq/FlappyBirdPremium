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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        CtrlGame ctrg = new CtrlGame();
        Pipe pipe = new Pipe();
        Items items = new Items();
        Bird bird = new Bird();

        Timer timer_Bird = new Timer();
        private void Form2_Load(object sender, EventArgs e)
        {
            // add pipe
            this.Controls.Add(pipe.picBoxPipeAbove1);
            this.Controls.Add(pipe.picBoxPipeAbove2);
            this.Controls.Add(pipe.picBoxPipeBottom1);
            this.Controls.Add(pipe.picBoxPipeBottom2);

            // add bird
            this.Controls.Add(bird.picBoxBird);

            // add items
            this.Controls.Add(items.picBoxCoins);

            pipe.DrawPipe(this);
            //items.DrawCoins();


            timer_Bird.Interval = 70;
            timer_Bird.Tick += Timer_Bird_Tick;
        }

        private void Timer_Bird_Tick(object sender, EventArgs e)
        {
            bird.Impact_Bird_pipe(ctrg, pipe);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
            ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);

            

            pipe.PipeInGame();

            items.GetCoins(this, bird, pipe);
            items.CoinsInGame();
            items.Impact_Coins_Bird(bird);

            
        }

        private void btt_Menu_Click(object sender, EventArgs e)
        {
            ctrg.MainScreenOff(btt_Play, btt_Menu, btt_Exit, pB_IntroBird);
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
        }

        private void btt_Play_Click(object sender, EventArgs e)
        {
            ctrg.MainScreenOff(btt_Play, btt_Menu, btt_Exit, pB_IntroBird);
            timer1.Start();

            timer_Bird.Start();
        }

       

       

        private void btt_exit2_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            //this.Close();
        }

        private void btt_speed_Click(object sender, EventArgs e)
        {
            ctrg.MenuOff(btt_scene, btt_speed, btt_item, btt_Back);
            ctrg.SubMenuOn(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium);
        }

        private void btt_Back_Click(object sender, EventArgs e)
        {
            ctrg.MainScreenOn(btt_Play, btt_Menu, btt_Exit);
            ctrg.SubMenuOff(btt_SpeedEasy, btt_SpeedHard, btt_SpeedMedium, btt_Back);
            ctrg.MenuOff(btt_scene, btt_speed, btt_item, btt_Back);
            pl_BgMenu.Visible = false;
        }

        private void btt_SpeedHard_Click(object sender, EventArgs e)
        {
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
        }

        private void btt_SpeedEasy_Click(object sender, EventArgs e)
        {
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
        }

        private void btt_SpeedMedium_Click(object sender, EventArgs e)
        {
            ctrg.MenuOn(pB_IntroBird, btt_scene, btt_speed, btt_item, pl_BgMenu, btt_Back);
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                bird.Move_Bird_Up();
            }
                //MessageBox.Show("go into");
                //pB_IntroBird.Visible = false;
        }
    }
}
