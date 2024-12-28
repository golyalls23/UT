namespace UT.API.Models;

public class EmployeeDepartment : BaseDTO
{
    public int PersonId {get; set;}
    public int DepartmentId {get; set;}
    public int ShiftId {get; set;}
    public TimeOnly StartDate {get; set;}
    public TimeOnly EndDate {get; set;}
}