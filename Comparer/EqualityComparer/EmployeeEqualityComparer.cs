using System;
using System.Collections.Generic;

namespace Comparer.EqualityComparer
{

    public class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return x.FirstName.Equals(y.FirstName, StringComparison.OrdinalIgnoreCase) &&
                x.LastName.Equals(y.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public int GetHashCode(Employee obj)
        {
            return base.GetHashCode();
        }
    }
}