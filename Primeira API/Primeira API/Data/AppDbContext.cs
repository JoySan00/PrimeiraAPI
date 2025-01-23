using Microsoft.EntityFrameworkCore;

namespace Primeira_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base (options)
        {

        }
    }
}
