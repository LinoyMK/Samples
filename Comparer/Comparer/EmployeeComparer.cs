using Comparer.EqualityComparer;
using System.Collections.Generic;

namespace Comparer.Comparer
{

    public class EmployeeAgeComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    public class EmployeeSalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Salary.CompareTo(y.Salary);
        }
    }

}
