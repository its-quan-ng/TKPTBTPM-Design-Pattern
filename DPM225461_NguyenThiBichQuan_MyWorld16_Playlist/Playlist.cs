using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld16_Playlist
{
    internal class Playlist
    {
        private List<Song> songs = new List<Song>();
        private string name;

        public Playlist(string name)
        {
            this.name = name;
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
            Console.WriteLine("Added: {0} to playlist '{1}'", song.Title, name);
        }

        public int Count
        {
            get { return songs.Count; }
        }

        public Song this[int index]
        {
            get { return songs[index]; }
        }

        public IIterator CreateIterator()
        {
            return new PlaylistIterator(this);
        }

    }
}
