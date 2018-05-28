using Microsoft.EntityFrameworkCore;

namespace TelegramUI.Models
{
    public class UserContext : DbContext
    {
        public DbSet<Users> user { get; set; }
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }
    }
}
