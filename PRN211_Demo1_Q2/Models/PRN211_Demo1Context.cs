using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace PRN211_Demo1_Q2.Models
{
    public partial class PRN211_Demo1Context : DbContext
    {
        public PRN211_Demo1Context()
        {
        }

        public PRN211_Demo1Context(DbContextOptions<PRN211_Demo1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<Book> Books { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Server=localhost;uid=sa;pwd=123;database=PRN211_Demo1;TrustServerCertificate=true");
                var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
                optionsBuilder.UseSqlServer(builder.GetConnectionString("Otaku"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("DOB");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasMany(d => d.Books)
                    .WithMany(p => p.Authors)
                    .UsingEntity<Dictionary<string, object>>(
                        "AuthorBook",
                        l => l.HasOne<Book>().WithMany().HasForeignKey("BookId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Author_Book_Books"),
                        r => r.HasOne<Author>().WithMany().HasForeignKey("AuthorId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_Author_Book_Authors"),
                        j =>
                        {
                            j.HasKey("AuthorId", "BookId");

                            j.ToTable("Author_Book");

                            j.IndexerProperty<int>("AuthorId").HasColumnName("AuthorID");

                            j.IndexerProperty<int>("BookId").HasColumnName("BookID");
                        });
            });

            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnType("ntext");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
