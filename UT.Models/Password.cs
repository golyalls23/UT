namespace UT.API.Models;

public class Password : BaseDTO
{
    public int PersonId { get; set; }
    public string PasswordHash {get; set;} = string.Empty;
    public string PasswordSalt {get; set;} = string.Empty;
}
