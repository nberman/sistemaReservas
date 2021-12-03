using Microsoft.EntityFrameworkCore;

namespace sistemaReservas.Server.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
        
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    
    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Name=DefaultConnection");
            
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");
            entity.Property(e => e.UserId).HasColumnName("user_id").ValueGeneratedNever();
            entity.Property(e => e.EmailAddress).IsRequired().HasColumnName("email_address");
            entity.Property(e => e.FirstName).HasColumnName("first_name").IsRequired();
            entity.Property((e => e.LastName)).HasColumnName("last_name");
            
        });
        
        OnModelCreatingPartial(modelBuilder);

    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    
}