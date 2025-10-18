using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld16_Playlist
{
    internal class Song
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }

        public Song(string title, string artist, int duration)
        {
            this.Title = title;
            this.Artist = artist;
            this.Duration = duration;
        }

        public void Play()
        {
            Console.WriteLine("🎵 Playing: {0} - {1} ({2}s)", Title, Artist, Duration);
        }
    }
}
