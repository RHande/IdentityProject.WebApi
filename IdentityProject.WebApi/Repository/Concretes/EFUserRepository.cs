using IdentityProject.WebApi.Context;
using IdentityProject.WebApi.Repository.Abstracts;
using IdentityProject.WebApi.Services.Abstracts;
using IdentityProject.WebApi.Web_Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.WebApi.Repository.Concretes;

//Sınıfları concretes içinde, interfaceleri de abstracts içinde tutuyoruz.
public class EFUserRepository : IUserRepository
{
    //Method injection
    //Constructor Arg Injection
    //Dependency Injection ve IOC Container ile ilgili konuları bilmemiz mülakat açısından çok iyi olur.
    private MsSqlContext _context;
    
    public EFUserRepository(MsSqlContext context)
    {
        _context = context;
    }
    
    public User Add(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
        return user;
    }
    
    public User Delete(int id)
    {
        User? user = GetById(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
        return user;
    }
    
    public List<User> GetAll()
    {
        List<User> users = _context.Users.Include(x=>x.Role).ToList();
        return users;
    }
    
    public List<User> GetAllByUsernameContains(string text)
    {
        List<User> users = _context.Users.Where(u => u.UserName.Contains(text, StringComparison.OrdinalIgnoreCase)).ToList();
        return users;
    }
    
    
    public User GetByEmail(string email)
    {
        User? user = _context.Users.SingleOrDefault(u => u.Email == email);
        return user;
    }

    
    public User GetById(int id)
    {
        User? user = _context.Users.Find(id);
        return user;
    }
    

    public User Update(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
        return user;
    }
    
}