using Microsoft.EntityFrameworkCore;

namespace TelegramBE.Models
{
    public class MessegeContext : DbContext
    {
        public DbSet<Messege> Messen { get; set; }
        public MessegeContext(DbContextOptions<MessegeContext> options)
            : base(options)
        {
        }
    }
}