
using Microsoft.EntityFrameworkCore;
namespace MonCatalogueProduitCategorie.Service
{
    public class CatalogueDBContext : DbContext 
    {
        /**
          *                   <!--Another constructor-->
          * 
          *   public CatalogueDBContext(DbContextOptions<CatalogueDBContext>options) : base(options)
          *   {
          *
          *   }
          * 
         **/

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CatalogueProduit;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
        public DbSet<Produit> Produits { get; set; }
        public DbSet<Categorie> Categories { get; set; }


      
    }
}
