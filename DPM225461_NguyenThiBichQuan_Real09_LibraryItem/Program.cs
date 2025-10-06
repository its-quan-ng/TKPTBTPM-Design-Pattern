using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real09_LibraryItem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Zynisoverparty", "1002 Slaps", 10);
            book.Display();

            Video video = new Video("Red Velvet", "Psycho MV", 360, 50);
            video.Display();

            Console.WriteLine("Making video borrowable: ");
            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Quan Nguyen");
            borrowvideo.BorrowItem("Katty Kang");
            borrowvideo.Display();

            Console.ReadKey();
        }
    }
}
