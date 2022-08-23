using ERIL.Models;
using Microsoft.EntityFrameworkCore;

namespace ERIL.Data
{
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Papers> Papers { get; set; }
    }
}
