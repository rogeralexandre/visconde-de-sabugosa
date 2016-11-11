// ROGER
using ContosoUniversity.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ContosoUniversity.DAL
{
    public class SchoolContext : DbContext
    {
        public SchoolContext() : base("SchoolContext")
        {
            // aqui que eu passo o nome da ConnectionString
            // o texto entre aspas do base() é o nome da ConnectionString que está configurada no Web.Config
        }

        // adicionando cada tabela ao EF
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // mera configuração para que as tabelas sejam criadas com os nomes no singular.
            // para as tabelas serem criadas no plural basta que as classes tenham sido criadas com o nome do plural e omitir o comando abaixo
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}