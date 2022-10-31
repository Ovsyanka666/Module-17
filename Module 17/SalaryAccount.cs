using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class SalaryAccount : ICalculator
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public SalaryAccount(double balance)
        {
            Balance = balance;
        }

        public void Calculate()
        {
            Interest = Balance * 0.5;
        }
    }
}
