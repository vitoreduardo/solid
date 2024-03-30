using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Srp.Solution
{
    public static class EmployeeService
    {
        public static string PrintReport(Employee employe)
        {
            return $"Performance report to {employe.Name}: Salary: {employe.CalculateSalary()}, Worked Hours: {employe.WorkedHours}";
        }
    }
}
