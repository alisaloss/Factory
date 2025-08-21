using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using Factory;

namespace Factory
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Enter salary"); 
            string input = Console.ReadLine();
            double salary;
            bool result = double.TryParse(input, out salary);
            if (!result)
            {
                Console.WriteLine("Invalid salary input. Please enter a valid number.");
                return;
            }
            //PermanentEmployee obj = new PermanentEmployee();
            //obj.AdjustSalary(salary);


            Console.WriteLine("Enter employee type (Permanent, Contract, Intern):");
            EmployeeFactory factory = new EmployeeFactory();
            IEmployee obj = factory.GetEmployee(Console.ReadLine());
            obj.AdjustSalary(salary);

            Main();
        }
    }
}
