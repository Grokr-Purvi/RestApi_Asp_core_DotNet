using TodoApi.Models;
using System.Collections.Generic;
using System;

namespace TodoApi.EmployeeData{
    public interface IEmployeeData{


        public List<Employee> GetEmployees();

        public Employee GetSingleEmployee(Guid id);

        public void AddEmployee(Employee employee);

        public void DeleteEmployee(Guid id);
    }
}