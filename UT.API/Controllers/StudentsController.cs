using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UT.API.Services;
using UT.Models;

namespace UT.API.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
        }

        [HttpGet]
        public async Task<ActionResult<List<StudentDTO>>> GetStudents()
        {
            var students = await _studentsService.GetStudentsAsync();
            return Ok(students);
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<StudentDTO>> GetStudentById(int id)
        {
            var student = await _studentsService.GetStudentByIdAsync(id);
            if (student is null)
                return NotFound();

            return Ok(student);
        }

        [HttpPost]
        public async Task<ActionResult<StudentDTO>> CreateStudent(StudentDTO student)
        {
            var newstudent = await _studentsService.AddStudentAsync(student);
            if (newstudent is null)
                return BadRequest();

            return Ok(newstudent);
        }

        [HttpPut]
        [Route("{studentId:int}")]
        public async Task<ActionResult<StudentDTO>> UpdateStudent(int studentId, StudentDTO studentDTO)
        {
            var updatedStudentDTO = await _studentsService.UpdateStudentAsync(studentId, studentDTO);
            if (updatedStudentDTO is null)
                return BadRequest();
            
            return Ok(updatedStudentDTO);
        }

        [HttpDelete]
        [Route("{studentId:int}")]
        public async Task<ActionResult> DeleteStudent(int studentId)
        {
            var retValue = await _studentsService.DeleteStudentAsync(studentId);
            return retValue ? NoContent() : BadRequest();
        }
    }
}
