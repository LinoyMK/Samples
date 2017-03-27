using System;
using System.Collections.ObjectModel;

namespace KeyedCollectionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary dic = new MyDictionary();
            dic.Add(new Employee() { Id = 100, Name = "lmk" });
            dic.Add(new Employee() { Id = 101, Name = "test" });

            Employee e = dic[100];

            Console.ReadKey();
        }
    }

    public class MyDictionary : KeyedCollection<int, Employee>
    {
        protected override int GetKeyForItem(Employee item)
        {
            return item.Id;
        }
    }

    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
