using Microsoft.EntityFrameworkCore;

namespace DataModels
{
    public class FitnessDbContext : DbContext
    {
        public FitnessDbContext(DbContextOptions<FitnessDbContext> options) : base(options) { }
    }
}
