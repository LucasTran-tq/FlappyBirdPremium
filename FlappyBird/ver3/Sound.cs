using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
namespace ver3
{
    class Sound
    {
        public SoundPlayer soundClick = new SoundPlayer(Properties.Resources.ClickSound);
        public SoundPlayer soundGameOver = new SoundPlayer(Properties.Resources.GameOverSound);
    }
}
