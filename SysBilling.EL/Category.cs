using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SysBilling.EL
{



    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();   
        }
        [Key]
        public int IdCategory { get; set; }
        [Required(ErrorMessage ="debe establecer un nombre")]
        [StringLength(50)]
        public string Name { get; set; }
        public string ImageURL { get; set; }


        public ICollection<Product> Products { get; set; }      
    }
}
