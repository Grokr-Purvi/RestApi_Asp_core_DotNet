using TodoApi.Models;
using System.Collections.Generic;
namespace TodoApi.EmployeeData{
    public interface IEmployeeData{


        public List<Employee> GetEmployees();

        public Employee GetSingleEmployee(int id);

        public void AddEmployee(Employee employee);
    }
}