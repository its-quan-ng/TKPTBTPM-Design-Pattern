using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld16_Playlist
{
    internal class PlaylistIterator : IIterator
    {
        private Playlist playlist;
        private int currentPosition = 0;

        public PlaylistIterator(Playlist playlist)
        {
            this.playlist = playlist;
        }

        public bool HasNext()
        {
            return currentPosition < playlist.Count;
        }

        public Song Next()
        {
            if (HasNext())
            {
                Song song = playlist[currentPosition];
                currentPosition++;
                return song;
            }
            return null;
        }

        public Song Current()
        {
            if (currentPosition > 0 && currentPosition <= playlist.Count)
            {
                return playlist[currentPosition - 1];
            }
            return null;
        }
    }
}
