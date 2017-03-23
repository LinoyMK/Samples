using System;
using System.Collections.Generic;

namespace Comparer.EqualityComparer
{
    public class EqualityComparerTest
    {
        public void Test()
        {
            Dictionary<Employee, string> firstDic = new Dictionary<Employee, string>(new EmployeeEqualityComparer());

            try
            {
                firstDic.Add(new Employee() { FirstName = "linoy", LastName = "kunjappan" }, "User1");
                firstDic.Add(new Employee() { FirstName = "LINOY", LastName = "kunjappan" }, "User2");
            }
            catch (ArgumentException ex)
            {
                throw new Exception("Duplicate user added", ex);
            }
        }


    }
}
