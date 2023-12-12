
using Microsoft.EntityFrameworkCore;


public partial class LinqDbContext : DbContext
{
    public LinqDbContext()
    {
    }
    public LinqDbContext(DbContextOptions<LinqDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Class> Classes { get; set; }

    public virtual DbSet<Enrolled> Enrolleds { get; set; }

    public virtual DbSet<Faculty> Faculties { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=ASJAL_PC\\SQLEXPRESS;Database=Linq_DB;Trusted_Connection=True;Encrypt=false;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

        modelBuilder.Entity<Class>(entity =>
        {
            entity.HasKey(e => e.CId).HasName("FK_Class");

            entity.ToTable("Class");

            entity.Property(e => e.CId).HasColumnName("cID");
            entity.Property(e => e.FId).HasColumnName("fID");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
            entity.Property(e => e.RoomNumber)
                .HasMaxLength(50)
                .HasColumnName("roomNumber");

            entity.HasOne(d => d.FIdNavigation).WithMany(p => p.Classes)
                .HasForeignKey(d => d.FId)
                .HasConstraintName("FK_Class_Faculty");
        });

        modelBuilder.Entity<Enrolled>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("FK_Enrolled");

            entity.ToTable("Enrolled");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CId).HasColumnName("cID");
            entity.Property(e => e.SId).HasColumnName("sID");

            entity.HasOne(d => d.CIdNavigation).WithMany(p => p.Enrolleds)
                .HasForeignKey(d => d.CId)
                .HasConstraintName("FK_Enrolled_Class");

            entity.HasOne(d => d.SIdNavigation).WithMany(p => p.Enrolleds)
                .HasForeignKey(d => d.SId)
                .HasConstraintName("FK_Enrolled_Student");
        });

        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.HasKey(e => e.FId).HasName("FK_Faculty");

            entity.ToTable("Faculty");

            entity.Property(e => e.FId).HasColumnName("fID");
            entity.Property(e => e.DeptId).HasColumnName("deptID");
            entity.Property(e => e.FName)
                .HasMaxLength(50)
                .HasColumnName("fName");
            entity.Property(e => e.Standing)
                .HasMaxLength(50)
                .HasColumnName("standing");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.SId).HasName("FK_Student");

            entity.ToTable("Student");

            entity.Property(e => e.SId).HasColumnName("sID");
            entity.Property(e => e.Major)
                .HasMaxLength(50)
                .HasColumnName("major");
            entity.Property(e => e.SName)
                .HasMaxLength(50)
                .HasColumnName("sName");
            entity.Property(e => e.Standing)
                .HasMaxLength(50)
                .HasColumnName("standing");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
