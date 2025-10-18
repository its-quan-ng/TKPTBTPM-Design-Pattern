using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld16_Playlist
{
    public class Program
    {
        static void Main(string[] args)
        {
            Playlist myPlaylist = new Playlist("My Favorites");
            myPlaylist.AddSong(new Song("Time To Love", "Red Velvet", 233));
            myPlaylist.AddSong(new Song("Like A Flower", "Irene - Red Velvet", 200));
            myPlaylist.AddSong(new Song("28 reasons", "Seulgi - Red Velvet", 285));

            IIterator iterator = myPlaylist.CreateIterator();

            while (iterator.HasNext())
            {
                Song song = iterator.Next();
                song.Play();
            }

            Console.ReadKey();
        }
    }
}
