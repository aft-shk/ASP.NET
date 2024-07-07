using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flipkart.Models
{
   [Table("products")]
    public class Product
    {
        [Key]
        public int Id { get; set; } 
        public string? Title { get; set; }
        [Required]
        public string? Description { get; set; }
        public int UnitPrice {  get; set; }
        public string Imageurl {  get; set; }

        public int quantity {  get; set; }
                




    }
}
