using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Srp.Solution
{
    public class Employee
    {
        public Employee(
            string name,
            decimal baseSalary,
            int workedHours)
        {
            Name = name;
            BaseSalary = baseSalary;
            WorkedHours = workedHours;
        }

        public string Name { get; }

        public decimal BaseSalary { get; }

        public int WorkedHours { get; }

        public decimal CalculateSalary()
        {
            return BaseSalary + (WorkedHours * 10);
        }

        
    }
}
