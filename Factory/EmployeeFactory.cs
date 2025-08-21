using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class EmployeeFactory
    {
        public IEmployee GetEmployee(string type)
        {
            IEmployee employee = null;
            Console.WriteLine("Creating employee of type: " + type);

            if (type.ToLower().Equals("permanent"))
            {
                employee = new PermanentEmployee();
            }
            else if (type.ToLower().Equals("contract"))
            {
                employee = new ContractEmployee();
            }
            else if (type.ToLower().Equals("intern"))
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
}
