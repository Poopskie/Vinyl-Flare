using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinyl_Flare
{
    public class SongPlayed
    {
        public int songId; // get id from looping the album with list of songs
        public string songName; // rest of values from song.x
        public DateTime songLength;
        public bool isPlaying = false; 
        public bool isDone = false;
        public System.Windows.RoutedEvent IsSpinning { get; set; }
    }


}
