using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TinderForCoders
{
    public partial class MainDataBase : DbContext
    {
        public MainDataBase()
        {
        }

        public MainDataBase(DbContextOptions<MainDataBase> options)
            : base(options)
        {
        }

        public virtual DbSet<UserDevelop> UserDevelops { get; set; }
        public virtual DbSet<UserLike> UserLikes { get; set; }
        public virtual DbSet<UserTable> UserTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Ztrach\\Source\\Repos\\TinderForCoders\\TinderForCoders\\TinderForCoders\\DataBases\\Tinder_DB.mdf;Integrated Security=True; Trusted_Connection=True;");
                //optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=~\\..\\DataBases\\Tinder_DB.mdf;Integrated Security=True; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<UserDevelop>(entity =>
            {
                entity.HasKey(e => e.ProjectId)
                    .HasName("PK__tmp_ms_x__761ABED04C3E53F2");

                entity.ToTable("UserDevelop");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.Aims).HasMaxLength(500);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.DeveloperId).HasColumnName("DeveloperID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.TagC).HasColumnName("Tag_C#");

                entity.Property(e => e.TagC1).HasColumnName("Tag_C++");

                entity.Property(e => e.TagGo).HasColumnName("Tag_GO");

                entity.Property(e => e.TagHtmlCss).HasColumnName("Tag_HTML/CSS");

                entity.Property(e => e.TagJava).HasColumnName("Tag_Java");

                entity.Property(e => e.TagJavaScrypt).HasColumnName("Tag_JavaScrypt");

                entity.Property(e => e.TagPhp).HasColumnName("Tag_PHP");

                entity.Property(e => e.TagPython).HasColumnName("Tag_Python");

                entity.HasOne(d => d.Developer)
                    .WithMany(p => p.UserDevelops)
                    .HasForeignKey(d => d.DeveloperId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DeveloperId");
            });

            modelBuilder.Entity<UserLike>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UserLike");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany()
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_UserLike_ProjectID");

                entity.HasOne(d => d.User)
                    .WithMany()
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserLike_UserID");
            });

            modelBuilder.Entity<UserTable>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__UserTabl__1788CC4CE0BE96B4");

                entity.ToTable("UserTable");

                entity.HasIndex(e => e.UserEmail, "DF_UserTable_Email")
                    .IsUnique();

                entity.HasIndex(e => e.UserLogin, "DF_UserTable_Login")
                    .IsUnique();

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGit).HasMaxLength(60);

                entity.Property(e => e.UserLogin)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.UserSurname)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.UserTagC)
                    .HasColumnName("UserTagC#")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTagCC)
                    .HasColumnName("UserTagC++/C")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTagGo)
                    .HasColumnName("UserTagGO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTagHtmlCss)
                    .HasColumnName("UserTagHTML/CSS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTagJava).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTagJavaScrypt).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTagPhp)
                    .HasColumnName("UserTagPHP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserTagPython).HasDefaultValueSql("((0))");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
