using ENS_Server_Client_.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ENS_Server_Client_;
public class ApplicationContext : DbContext
{
    public DbSet<Event> Events => Set<Event>();
    public DbSet<User> Users => Set<User>();
    public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
    {

    }
}