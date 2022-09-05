using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MonCatalogueProduitCategorie.Service
{
   [Table("PRODUITS")]
    public class Produit
    {
        [Key]
        public int ProduitID { get; set; }

        [Required]
        [StringLength(70)]
        public string Designation { get; set; }

        [Required]
        public double Prix { get; set; } 
        public int Quantite { get; set; }

        //foreign key
        [ForeignKey("CategorieID")]
        public int CategorieID { get; set; }

     /*--------------------------------- Navigation property -------------------------------------*/
       
        //mode Lazy loading propriété d'association
        public virtual Categorie? Categorie { get; set; }

    }
}
