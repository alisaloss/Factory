using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class ContractEmployee :IEmployee
    {
        public void AdjustSalary(double a)
        {
            Console.WriteLine("Contract a*1.05 = {0}", +a * 1.01);    
        }
    }

}
