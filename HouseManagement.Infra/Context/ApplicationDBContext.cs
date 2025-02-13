using HouseManagement.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace HouseManagement.Infra.Context
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }
        
        public DbSet<Person> People { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .Property(x => x.Name).HasColumnType("varchar(70)").IsRequired();
            modelBuilder.Entity<Person>()
                .Property(x => x.Idade).HasColumnType("int").IsRequired();

            modelBuilder.Entity<Transaction>()
                .Property(x => x.Description).HasColumnType("varchar(150)").IsRequired();
            modelBuilder.Entity<Transaction>()
                .Property(x => x.Value).HasColumnType("decimal (7,2)").IsRequired();
            modelBuilder.Entity<Transaction>()
                .Property(x => x.IsRevenue).HasColumnType("bit").IsRequired();
            modelBuilder.Entity<Transaction>()
                .Property(x => x.IdPerson).HasColumnType("int").IsRequired();

            modelBuilder.Entity<Person>()
                .HasMany(x => x.Transactions)
                .WithOne(x => x.Person)
                .HasForeignKey(x=> x.IdPerson)
                .OnDelete(DeleteBehavior.ClientCascade);

        }
    }
}
