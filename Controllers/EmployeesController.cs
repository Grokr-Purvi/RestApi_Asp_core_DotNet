using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TodoApi.EmployeeData;
using System.Collections.Generic;
using TodoApi.Models;
using System;

namespace TodoApi.Controllers{
    
    [ApiController]
    public class EmployeeController : ControllerBase{
        private IEmployeeData _employeeData;

        public EmployeeController(IEmployeeData employeeData){
            _employeeData = employeeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IEnumerable<Employee> GetEmployees(){
            
            return _employeeData.GetEmployees();
            // return Ok(_employeeData.GetEmployees());

        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetSingleEmployee(Guid id){

            var employee = _employeeData.GetSingleEmployee(id);
            if(employee != null){
                return Ok(employee);
            }
            return NotFound($"Employee with Id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddEmployee(Employee employee){
            _employeeData.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" + employee.id,employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteEmployee(Guid id){
            _employeeData.DeleteEmployee(id);
            var employee = _employeeData.GetSingleEmployee(id);
            if(employee == null){
                return Ok($"Employee deleted successfully!");
            }
            return NotFound($"Employee with Id: {id} was not found");
        }
    }
}
