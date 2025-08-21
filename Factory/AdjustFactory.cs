using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class AdjustFactory
    {
        public IEmployee getEmployeeType(string type)
        {
            IEmployee employee = null;

            if(type.ToLower().Equals("Permanent"))
            {
              employee = new PermanentEmployee();
            }
            else if(type.ToLower().Equals("Contract"))
            {
                employee = new ContractEmployee();
            }
            else if(type.ToLower().Equals("Intern"))
            {
                employee = new InternEmployee();
            }
            else
            {
                Console.WriteLine("Invalid employee type specified.");
            }
            return employee;
        }
}
