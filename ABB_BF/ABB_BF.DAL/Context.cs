using ABB_BF.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ABB_BF.DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Probation> Probations { get; set; }
        public DbSet<Grant> Grants { get; set; }
        public DbSet<UniversityForm> UniversityForms { get; set; }
        public DbSet<Practice> Practices { get; set; }
    }
}
