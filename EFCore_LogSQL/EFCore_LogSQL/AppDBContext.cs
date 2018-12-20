using System;
using System.Collections.Generic;
using System.Text;
using EFCore_LogSQL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCore_LogSQL
{
    public class AppDBContext : DbContext
    {
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Livro> Livros { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //"Data Source = MACORATTI; " +  "Initial Catalog=DemoDB;Integrated Security=True"
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Macoratti;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseLoggerFactory(new LoggerFactory().AddConsole((category, level) => level == LogLevel.Information &&
                                             category == DbLoggerCategory.Database.Command.Name, true));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //------entidade Autor--------------------
            modelBuilder.Entity<Autor>().HasKey(a => a.AutorId);
            modelBuilder.Entity<Autor>()
               .Property(p => p.Nome)
               .HasMaxLength(100)
               .IsRequired();
            modelBuilder.Entity<Autor>()
                .Property(p => p.Email)
                .HasMaxLength(200)
                .IsRequired();
            //------entidade Livro--------------------
            modelBuilder.Entity<Livro>().HasKey(a => a.LivroId);
            modelBuilder.Entity<Livro>()
                .Property(p => p.Titulo)
                .HasMaxLength(200)
                .IsRequired();
            //um-para-muitos :  Livros - Autor
            modelBuilder.Entity<Livro>()
              .HasOne<Autor>(s => s.Autor)
                .WithMany(g => g.Livros)
                   .HasForeignKey(s => s.AutorId);
        }
    }
}
