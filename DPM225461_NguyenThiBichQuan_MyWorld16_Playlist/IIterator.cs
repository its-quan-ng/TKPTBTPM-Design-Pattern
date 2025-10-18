using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld16_Playlist
{
    interface IIterator
    {
        bool HasNext();
        Song Next();
        Song Current();
    }
}
