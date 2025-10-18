using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld20_VendingMachine
{
    interface IState
    {
        void InsertCoin();
        void SelectProduct();
        void Dispense();
    }
}
