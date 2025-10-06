using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern16_Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        List<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
