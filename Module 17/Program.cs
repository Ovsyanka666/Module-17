using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_17
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegularAccount regular = new RegularAccount(1000000);
            SalaryAccount salary = new SalaryAccount(1000000);

            Calculator.Calculate(regular);
            Calculator.Calculate(salary);

            Console.WriteLine($"Ставка обычного счёта - {regular.Interest}");
            Console.WriteLine($"Ставка зарплатного счёта - {salary.Interest}");

            Console.ReadLine();
        }
    }
}
