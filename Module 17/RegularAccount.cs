using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class RegularAccount : ICalculator
    {
        public double Balance { get; set; }        
        public double Interest { get; set; }

        public RegularAccount(double balance)
        {
            Balance = balance;
        }

        public void Calculate()
        {
            Interest = Balance * 0.4;
            if (Balance < 1000)
                Interest -= Balance * 0.2;
            if (Balance < 50000)
                Interest -= Balance * 0.4;
        }
    }
}
