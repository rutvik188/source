using LoginDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginDemo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
         
        public DbSet<User> Users { get; set; }  
    }
}
