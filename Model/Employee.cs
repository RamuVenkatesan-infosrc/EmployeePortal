﻿namespace EmployeePortal.Model
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string?Name { get; set; }
        public string?Email { get; set; }
        public string?PhoneNumber { get; set; }
        public double  Salary { get; set; }
    }

}
