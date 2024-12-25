using UT.Domain;
using UT.Models;

namespace UT.API.Services;

public interface IStudentsService
{
    Task<List<StudentDTO>> GetStudentsAsync();
    Task<StudentDTO?> GetStudentByIdAsync(int id);
    Task<StudentDTO> AddStudentAsync(StudentDTO studentDTO);
    Task<StudentDTO?> UpdateStudentAsync(int studentId, StudentDTO studentDTO);
    Task<bool> DeleteStudentAsync(int studentId);
}