using System.Collections.Generic;
using TodoApi.Models;
using System.Linq;

namespace TodoApi.EmployeeData{
    public class MockEmployeeData : IEmployeeData{
        
        public List<Employee> employees = new List<Employee>()
        {
            new Employee()
            {
                id = 1,
                name="abc"
            },
             new Employee()
            {
                id = 2,
                name="bcd"
            },
             new Employee()
            {
                id = 3,
                name="cde"
            },
        };

        public List<Employee> GetEmployees(){
            return employees;
        }

        public Employee GetSingleEmployee(int id){
            return employees.SingleOrDefault(x => x.id == id);
        }

        public void AddEmployee(Employee employee){
            
        }
    }
}