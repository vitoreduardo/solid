using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srp.Solution
{
    public static class EmployeeDAO
    {
        public static void SaveData(Employee employee)
        {
            Console.WriteLine($"Employee '{employee.Name}' data saved successfully.");
        }
    }
}
