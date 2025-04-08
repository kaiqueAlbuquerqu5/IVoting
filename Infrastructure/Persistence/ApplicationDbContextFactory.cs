using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infrastructure.Persistence
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql("server=localhost;port=3306;database=IVotingDB;user=root;password=admin",
                ServerVersion.AutoDetect("server=localhost;port=3306;database=IVotingDB;user=root;password=admin"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}