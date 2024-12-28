namespace UT.API.Models;

public class PersonPhone  :BaseDTO
{
    public string PhoneNumber {get; set; }= string.Empty;
    public int PhoneNumberTypeId {get; set;}
}
