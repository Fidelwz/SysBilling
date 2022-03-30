


using Microsoft.EntityFrameworkCore;

namespace SysBilling.EL
{
    public class BillingContext : DbContext
    {
        //En el contexto se especificara
        //las clases y la conexion a la base de datos.
        //Crear nuestra base de datos apartir de nuestras clases.
        //CodeFirst

        public DbSet<Category> category { get; set; }
        
        public DbSet<Product> products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-1MG8MA7\SQLEXPRESS;Initial Catalog=DbBillin;Integrated Security=True");
        }
    }
}
