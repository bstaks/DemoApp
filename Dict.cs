using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApp
{
  public  class Dict
    {
        public void AddItem()
        {
            Dictionary<Employee, int> empDict = new Dictionary<Employee, int>();
            empDict.Add(new Employee() { EmployeeId = 1 }, 1);
            empDict.Add(new Employee() { EmployeeId = 1 }, 2);
            Console.ReadLine();
        }
    }

    class Employee
    {
        public int EmployeeId { get; set; }
    }
}
