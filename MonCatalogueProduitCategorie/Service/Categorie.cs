using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonCatalogueProduitCategorie.Service
{
    [Table("CATEGORIES")]
    public class Categorie
    {
       // [key] gestion des depandences
       [Key]
        public int CategorieID { get; set; }
        public string? CategorieName { get; set; }

     /*--------------------------------- Navigation property -------------------------------------*/
       
        //mode lazy_loading, propriété d'association 
        public virtual ICollection<Produit>? Produits { get; set; }
    }
}
 