using Microsoft.EntityFrameworkCore;
using TheLoanProviders.Models;

namespace TheLoanProviders.Data
{
    public class LoanDbContext : DbContext
    {
        public LoanDbContext(DbContextOptions<LoanDbContext> options) : base(options)
        {

        }
        public DbSet<signuppageData> Login
            { get; set; }
    }
}
