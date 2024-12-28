namespace UT.API.Models;

public class Shift  : BaseDTO
{
    public short ShiftId {get; set;}
    public string Name {get; set;} = string.Empty;
    public TimeOnly StartTime {get;set;}
    public TimeOnly EndTime {get; set;}

}
