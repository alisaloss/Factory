using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    internal class InternEmployee : IEmployee
    {
        public void AdjustSalary(double a)
        {
            Console.WriteLine("Intern salary a + 200 = {0}", a + 200);

        }
    }

}