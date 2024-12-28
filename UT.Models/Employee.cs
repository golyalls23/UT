namespace UT.API.Models;

public class EmployeeDTO : BaseDTO
{
    public int PersonId {get;set;}
    public string NationalIdNumber { get; set; }= string.Empty;
    public string LoginId  { get; set; }= string.Empty;
    public string JobTitle {get; set;} = string.Empty;
    public string BirthDate { get; set; }= string.Empty;
    public string MaritalStatus { get; set; }= string.Empty;
    public string Gender { get; set; }= string.Empty;
    public string HireDate { get; set; }= string.Empty;
    public bool SalariedFlag {get; set;}
    public int VacationHours { get; set; } 
    public int SickLeaveHours { get; set; }
    public bool CurrentFlag {get;set;}

}
