using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225493_NguyenThienTri_Pattern20_State
{
    internal class Context
    {
        State state;
        
        public Context(State state)
        {
            this.State = state;
        }
     
        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}
