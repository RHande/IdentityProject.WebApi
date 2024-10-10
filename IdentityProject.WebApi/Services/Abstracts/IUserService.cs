using IdentityProject.WebApi.Web_Models;
using IdentityProject.WebApi.Web_Models.Dtos.Users.Request;
using IdentityProject.WebApi.Web_Models.Dtos.Users.Response;

namespace IdentityProject.WebApi.Services.Abstracts;

public interface IUserService
{
    List<UserResponseDto> GetAllUsers();
    User GetById(int id);
    User Add(AddUserRequestDto dto);
    User Update(User user);
    User Delete(int id);
    User GetByEmail(string email);
   
}