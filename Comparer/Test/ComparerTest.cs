using Comparer.Comparer;
using Comparer.EqualityComparer;
using System.Collections.Generic;
using System.Linq;

namespace Comparer.Test
{
    public class ComparerTest
    {
        public void Test()
        {
            #region Raw data
            IList<Employee> lstEmp = new List<Employee>();
            lstEmp.Add(new Employee() { FirstName = "Linoy", LastName = "Kunjappan", Age = 26, Salary = 200 });
            lstEmp.Add(new Employee() { FirstName = "Binoy", Age = 25, Salary = 400 });
            lstEmp.Add(new Employee() { FirstName = "Manoj", Age = 20, Salary = 1000 });
            lstEmp.Add(new Employee() { FirstName = "LINOY", LastName = "KUNJAPPAN", Age = 30, Salary = 300 });

            #endregion

            #region OrderBy

            IList<Employee> orderedByAge = lstEmp.OrderBy(m => m, new EmployeeAgeComparer()).ToList();
            IList<Employee> orderedBySalary = lstEmp.OrderBy(m => m, new EmployeeSalaryComparer()).ToList();

            #endregion

            #region Distinct

            IList<Employee> distinctEmp = lstEmp.Distinct(new EmployeeEqualityComparer()).ToList();

            #endregion

            #region CompareTo


            Employee e1 = new Employee() { FirstName = "Linoy", Age = 26, Salary = 200 };
            Employee e2 = new Employee() { FirstName = "Manoj", Age = 26, Salary = 100 };

            int result = e1.CompareTo(e2);
            if (result > 0)
            {
                System.Console.WriteLine("Employee e1 has greater salary than e2");
            }

            #endregion
        }


    }
}
