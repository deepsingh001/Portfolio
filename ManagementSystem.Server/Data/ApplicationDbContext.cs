using Microsoft.EntityFrameworkCore;
using ManagementSystem.Server.Models;
using Microsoft.Identity.Client;

namespace ManagementSystem.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
