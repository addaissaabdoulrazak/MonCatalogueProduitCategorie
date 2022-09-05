using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonCatalogueProduitCategorie.Service;

namespace MonCatalogueProduitCategorie.Controllers
{
    public class ProduitController : Controller
    {
        //property
        public CatalogueDBContext dbContext { get; set; }
        public ProduitController(CatalogueDBContext db)
        {
            dbContext= db; 
        }
       
        //GET: /Produit/Index
        public IActionResult Index(int numeroPage=0, int size=3, string motCle="")
        {
            int position = numeroPage * size;

            IEnumerable<Produit> allProducts = dbContext.Produits.Skip(position).Take(size).Include(p=>p.Categorie).ToList();
            ViewBag.currentPage = numeroPage;
            /*if pair this below instruction is valid and else how to make ?? */
            //-- int totalPages = dbContext.Produits.ToList().Count / size; --
            /* si totalPages est impaire(est un nombre a virgule) Comment Faire ?? */
            int  totalPages;
            int nombreProduits= dbContext.Produits.ToList().Count;
            if (nombreProduits % size == 0)
               ViewBag.totalPages = nombreProduits / size;
            else
                ViewBag.totalPages = 1+(nombreProduits / size);
            return View("Produits", allProducts);
        }

        public IActionResult Create()
        {
            //loading of category or foreign key management
            IEnumerable<Categorie>allCategories = dbContext.Categories.ToList();
            Produit p = new();
            
            ViewBag.categories = allCategories;

            return View("Create",p);
        }

        [HttpPost]
        public IActionResult Save( Produit p)
        {
            if (ModelState.IsValid)
            {
                dbContext.Produits.Add(p);
                dbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return View("Produits",p);

        }
    }
}
 