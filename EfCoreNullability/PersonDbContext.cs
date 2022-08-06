using Microsoft.EntityFrameworkCore;

namespace EfCoreNullability;
public class PersonDbContext : DbContext
{
    public PersonDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Person> Persons => Set<Person>();
}
