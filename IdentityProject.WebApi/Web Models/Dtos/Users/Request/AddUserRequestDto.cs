namespace IdentityProject.WebApi.Web_Models.Dtos.Users.Request;

public class AddUserRequestDto
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string UserName { get; set; }
    public int RoleId { get; set; }
}