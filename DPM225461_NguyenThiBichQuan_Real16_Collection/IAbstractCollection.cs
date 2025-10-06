using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Real16_Collection
{
    public interface IAbstractCollection
    {
        Iterator CreateIterator();
    }
}
