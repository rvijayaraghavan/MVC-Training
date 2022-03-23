using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCTraining.Models;

namespace MVCTraining.ViewModels
{
    public class EmployeeLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            Employee employee = new Employee()
            {
                EmployeeId = 101,
                Name = "Vijayaraghavan",
                Gender = "Male",
                PhoneNumber = "9035803116",
                EmailAddress = "vijay@gmail.com",
                Position = "Software Developer",
                Salary = 60000
            };
            return employee;
        }
    }
}