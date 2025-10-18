using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App03_SMS
{
    abstract class NotifierCreator
    {
        public abstract Notifier FactoryMethod();
    }
}
