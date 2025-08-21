using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PermanentEmployee :IEmployee
    {
        public void AdjustSalary(double a)
        {
            Console.WriteLine("Permanent salary a*1.1+1000 = {0}", +a * 1.1 + 1000);
        }
    }

}
