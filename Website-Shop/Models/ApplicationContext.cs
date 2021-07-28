using Microsoft.EntityFrameworkCore;

namespace Website_Shop.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) 
            : base(options) 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
    }
}
