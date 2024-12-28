namespace UT.API.Models;

public class PersonDTO  : BaseDTO
{
    public string Title { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string MiddleName {get; set;}= string.Empty;
    public string LastName { get; set; }= string.Empty;
    public string AdditionalContactInfo { get; set; }= string.Empty;
}
