using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_Pattern04_Prototype
{
    abstract class Prototype
    {
        string id;

        protected Prototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }
        public abstract Prototype Clone();
    }
}
