using MonCatalogueProduitCategorie.Service;

//Console.WriteLine("Hello, World!");
//string sql = @"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CatalogueProduit;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
using (var db = new CatalogueDBContext())
{
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
    db.Categories.Add(new Categorie { CategorieName = "Ordinateur" });
    db.Categories.Add(new Categorie { CategorieName = "Smartphone" });
    db.Categories.Add(new Categorie { CategorieName = "Imprimente" });

    db.Produits.Add(new Produit 
    { 
      Designation = "HP 65 90",
     Prix=7800,
     Quantite=6,
     CategorieID=1
    
     });
    db.Produits.Add(new Produit
    {
        Designation = "Samsung Galaxy S22",
        Prix = 7600,
        Quantite = 11,
        CategorieID = 2
    });
    db.Produits.Add(new Produit{
        Designation="Imprimante Epson 54690",
        Prix=1200,
        Quantite=6,
        CategorieID=3,
    }) ;
    db.SaveChanges();
}
