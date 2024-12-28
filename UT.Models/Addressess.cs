namespace UT.API.Models;

public class Addressess : BaseDTO
{
    public int AddressId {get; set;}
    public string Address1 {get; set;} = string.Empty;
    public string Address2 {get; set;} = string.Empty;
    public int CityStateZipId {get; set;}
}
