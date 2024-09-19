using Microsoft.EntityFrameworkCore;
using Register_Login_Task.Models;

namespace Register_Login_Task.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }
       public DbSet<User> Users { get; set; }
    }
}
