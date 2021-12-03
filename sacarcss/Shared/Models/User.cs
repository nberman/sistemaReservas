namespace sistemaReservas.Shared.Models;

public partial class User
{
   
    public long UserId { get; set; }
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}