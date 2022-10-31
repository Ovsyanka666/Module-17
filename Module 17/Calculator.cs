using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    class Calculator
    {
        public static void Calculate(ICalculator acc)
        {
            acc.Calculate();
        }
    }
}
