using Microsoft.EntityFrameworkCore;

namespace exam.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Jawn> Jawns {get;set;}

        public DbSet<GetTogether> GetTogethers {get;set;}
    }
}