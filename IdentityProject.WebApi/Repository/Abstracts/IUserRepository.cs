using IdentityProject.WebApi.Web_Models;

namespace IdentityProject.WebApi.Repository.Abstracts;

public interface IUserRepository : IEntityRepository<User>
{
    User GetById(int id);
    List<User> GetAll();
    User Add(User user);
    User Update(User user);
    User Delete(int id);
    User GetByEmail(string email);
    List<User> GetAllByUsernameContains(string text);
}