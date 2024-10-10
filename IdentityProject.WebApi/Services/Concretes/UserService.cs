using IdentityProject.WebApi.Repository.Abstracts;
using IdentityProject.WebApi.Services.Abstracts;
using IdentityProject.WebApi.Web_Models;
using IdentityProject.WebApi.Web_Models.Dtos.Users.Request;
using IdentityProject.WebApi.Web_Models.Dtos.Users.Response;

namespace IdentityProject.WebApi.Services.Concretes;

public class UserService : IUserService
{
    private IUserRepository _userRepository;
    
    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    
    public List<UserResponseDto> GetAllUsers()
    {
        return _userRepository.GetAll().Select(x => (UserResponseDto)x).ToList();
    }

    public User GetById(int id)
    {
        User user = _userRepository.GetById(id);
        return user;
    }

    public User Add(AddUserRequestDto dto)
    {
        User user = (User)dto;
        User created = _userRepository.Add(user);
        return created;
    }

    public User Update(User user)
    {
        User updated = _userRepository.Update(user);
        return updated;
    }

    public User Delete(int id)
    {
        User deleted = _userRepository.Delete(id);
        return deleted;
    }

    public User GetByEmail(string email)
    {
        User user = _userRepository.GetByEmail(email);
        return user;
    }
}