namespace UT.API.Models;

public class CreditCard :BaseDTO
{
    public int CreditCardId {get; set;}
    public string CardType {get; set;} = string.Empty;
    public string CardNumber {get; set;} = string.Empty;
    public int ExpMonth {get; set;}
    public int ExpYear {get; set;}
}
