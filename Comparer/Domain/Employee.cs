using System;

namespace Comparer.EqualityComparer
{

    public class Employee : IComparable<Employee>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Salary { get; set; }

        public int Age { get; set; }

        public int CompareTo(Employee other)
        {
            if (other == null || this.Salary > other.Salary)
            {
                return 1; // Grater than Zero
            }
            else if (Salary == other.Salary) // Both equal
            {
                return 0;
            }
            else
            {
                return -1; // Less than zero
            }
        }
    }
}