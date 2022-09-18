using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Vinyl_Flare.MVVM.Commands
{
    public class MediaControl : CommandBase
    {

        public MediaPlayer MediaPlayer;
        private readonly string Command;


        public MediaControl(MediaPlayer mediaPlayer, string command)
        {
            MediaPlayer = mediaPlayer;
            Command = command;
        }
        
        
        public override void Execute(object parameter)
        {
            if (Command == "pause")
            {
                MediaPlayer.Pause();
            } else if (Command == "play")
            {
                MediaPlayer.Play();
            } else if (Command == "skip")
            {
                TimeSpan ts = new TimeSpan(0, 0, 0, 0, Convert.ToInt32(MediaPlayer.NaturalDuration.TimeSpan.TotalMilliseconds));
                MediaPlayer.Position = ts;
            }
        }





    }
}
