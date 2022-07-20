using Microsoft.EntityFrameworkCore;

namespace API_CRUD.Models
{
    public class BasedeDados:DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source = PTFERNANDES\SQLEXPRESS; Initial Catalog = Produtos; Integrated Security = True");
        }
    }
}
