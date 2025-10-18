using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_App03_SMS
{
    internal class EmailNotifierCreator : NotifierCreator
    {
        public override Notifier FactoryMethod()
        {
            return new EmailNotifier();
        }
    }
}
