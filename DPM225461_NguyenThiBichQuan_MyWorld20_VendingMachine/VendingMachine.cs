using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225461_NguyenThiBichQuan_MyWorld20_VendingMachine
{
    internal class VendingMachine
    {
        public IState NoCoinState { get; set; }
        public IState HasCoinState { get; set; }
        public IState SoldState { get; set; }

        private IState currentState;
        private int productCount;

        public VendingMachine(int productCount)
        {
            this.productCount = productCount;

            NoCoinState = new NoCoinState(this);
            HasCoinState = new HasCoinState(this);
            SoldState = new SoldState(this);

            currentState = NoCoinState;
        }

        public void SetState(IState state)
        {
            currentState = state;
        }

        public void InsertCoin()
        {
            currentState.InsertCoin();
        }

        public void SelectProduct()
        {
            currentState.SelectProduct();
        }

        public void Dispense()
        {
            currentState.Dispense();
        }

        public void ReleaseProduct()
        {
            if (productCount > 0)
            {
                Console.WriteLine("Product dispensed!");
                productCount--;
            }
        }

        public int ProductCount
        {
            get { return productCount; }
        }

    }
}
