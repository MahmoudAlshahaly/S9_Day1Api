using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using S9_Day1Api.Models;

namespace S9_Day1Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeparmentsController : ControllerBase
    {
        CompanyContext _context = new CompanyContext();

        [HttpGet]
        public ActionResult GetAll()
        {
            var depts = _context.Departments.ToList();
            return Ok(depts);
        }
        //[HttpGet("{Id}")]
        [HttpGet]
        [Route("{Id}")]
        public ActionResult GetById(int Id)
        {
            var dept = _context.Departments.Find(Id);
            if (dept == null)
            {
                return NotFound();
            }
            return Ok(dept);
        }
        [HttpPost]
        public ActionResult Add(Department department)
        {
            _context.Departments.Add(department);
            //_context.Add(department);
            _context.SaveChanges();

            //https://localhost:7109/api/Deparments/3
            return CreatedAtAction(nameof(GetById), new { Id = department.Id }, new { Message = "Created Successfully" });
        }
        [HttpPut]
        [Route("{Id}")]
        public ActionResult Edit( int Id,Department department)
        {
            if(Id != department.Id)
            {
                return BadRequest();
            }

            var DeptFromDatabase = _context.Departments.Find(Id);

            if (DeptFromDatabase == null)
            {
                return NotFound();
            }

            DeptFromDatabase.Name = department.Name;
            DeptFromDatabase.Location = department.Location;
            //_context.Update(department);
            //_context.Departments.Update(department);
            _context.SaveChanges();

            return NoContent();
        }
        [HttpDelete]
        [Route("{Id}")]
        public ActionResult Remove(int Id)
        {
            var dept = _context.Departments.Find(Id);

            _context.Remove(dept);
            //_context.Departments.Remove(dept);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
