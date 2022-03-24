
using System.ComponentModel.DataAnnotations;

namespace SysBilling.EL
{
    public class Product
    {
        [Key]
        public int IdProduct { get; set; }
        [Required]
        [StringLength(50)]
        public string ProductName { get; set; }
        
        [StringLength(100)]
        public string Description  { get; set; }
       
        [Required]
        [Range(0, 9999999999999999.99)]
        public decimal  Price { get; set; }   
        public int Quantity { get; set; }  
        public string ImageURL { get; set; }
        public Category Category { get; set; }
    }
}
