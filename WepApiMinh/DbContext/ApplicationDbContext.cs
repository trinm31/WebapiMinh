using Microsoft.EntityFrameworkCore;
using WepApiMinh.Models;

namespace WepApiMinh.DbContext
{
    public class ApplicationDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
    }
}