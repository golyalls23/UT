using System;
using UT.Domain;
using UT.Models;

namespace UT.API.Services;

public class StudentsService : IStudentsService
{
    public async Task<List<StudentDTO>> GetStudentsAsync()
    {
        var students = MockDataService.Students.Values.ToList();
        if (students is not null)
            return await Task.Run(() => students);
        
        return [];
    }

    public async Task<StudentDTO> AddStudentAsync(StudentDTO studentDTO)
    {
        await Task.Run(() => {
            int? id = MockDataService.Students.Count + 1;
            studentDTO.StudentID = id.GetValueOrDefault();
            MockDataService.Students.Add(studentDTO.StudentID, studentDTO);
        });
        return studentDTO;
    }

    public async Task<StudentDTO?> GetStudentByIdAsync(int id)
    {
        var student = MockDataService.Students[id];
        if (student is not null)
            return await Task.Run(() => student);
        
        return null;

    }

    public async Task<StudentDTO?> UpdateStudentAsync(int studentId, StudentDTO studentDTO)
    {
        if (studentId != studentDTO.StudentID)
            return null;
        
        var student = MockDataService.Students[studentId];
        if (student is not null)
        {
            // MockDataService.Students()
            return await Task.Run(() => student);
        }
        return null;
    }

    public async Task<bool> DeleteStudentAsync(int studentId)
    {
        var student = MockDataService.Students[studentId];
        if (student is not null)
        {
            await Task.Run(() => MockDataService.Students.Remove(studentId));
            return true;
        }
        
        return false;
    }
}
