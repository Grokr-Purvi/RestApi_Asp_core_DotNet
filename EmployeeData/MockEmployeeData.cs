using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;
using System;

namespace TodoApi.EmployeeData{
    public class MockEmployeeData : IEmployeeData{
        
        public List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                id = Guid.NewGuid(),
                name="abc"
            },
             new Employee()
            {
                id = Guid.NewGuid(),
                name="bcd"
            },
             new Employee()
            {
                id = Guid.NewGuid(),
                name="cde"
            },
        };

        public List<Employee> GetEmployees(){
            return employees;
        }

        public Employee GetSingleEmployee(Guid id){
            return employees.SingleOrDefault(x => x.id == id);
        }

        public void AddEmployee(Employee employee){
            employee.id = Guid.NewGuid();
            employees.Add(employee);
        }

        public void DeleteEmployee(Guid id){
            var employee = employees.SingleOrDefault(x => x.id == id);
            employees.Remove(employee);
        }
    }
}