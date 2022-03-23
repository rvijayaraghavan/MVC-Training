using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCTraining.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Position { get; set; }
        public int Salary { get; set; }
    }
}