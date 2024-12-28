namespace UT.API.Models;

public class CityStateZip : BaseDTO
{
    public int CityStateZipId {get; set;}
    public string City {get; set;} = string.Empty;
    public int StateId {get; set;}
    public string ZipCode {get; set;} = string.Empty;
}
