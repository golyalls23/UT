namespace UT.API.Models;

public class DepartmentDTO : BaseDTO
{
    public int DepartmentId {get; set;}
    public string Name {get; set;} = string.Empty;
    public string GroupName {get; set;} = string.Empty;
}
