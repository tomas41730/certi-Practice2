using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        private List<Student> students;
        

        public StudentsController(ILogger<StudentsController> logger)
        {
        }

        [HttpGet]
        public List<Student> GetStudents()
        {
            return students;
        }
        [HttpPost]
        public Student CreateStudent([FromBody]string studentName)
        {
            return new Student() 
            { 
                Name = studentName 
            };
        }
        [HttpPut]
        public Student UpdateStudent([FromBody]Student student)
        {
            student.Name = "updated";
            return student;
        }
        [HttpDelete]
        public Student DeleteStudent([FromBody]Student student)
        {
            student.Name = "deleted";
            return student;
        }
        public void populateList()
        {
            students = new List<Student>();
            students.Add(new Student() { Name = "Susy" });
            students.Add(new Student() { Name = "Carlos" });
            students.Add(new Student() { Name = "Alejandro" });
            students.Add(new Student() { Name = "Diana" });
            students.Add(new Student() { Name = "Max" });
            students.Add(new Student() { Name = "Camila" });
        }
    }
}
