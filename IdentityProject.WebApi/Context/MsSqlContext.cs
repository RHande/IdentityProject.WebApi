
using IdentityProject.WebApi.Web_Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


namespace IdentityProject.WebApi.Context;

public class MsSqlContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //Docker kurulu olanlar
        optionsBuilder.UseSqlServer("Server=localhost,1433; Database=IdentityDb; User=sa; Password=yourStrong(!)Password; TrustServerCertificate=True");
        //Localdb
        //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=IdentityDb; Trusted_Connection=True;");
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    
}