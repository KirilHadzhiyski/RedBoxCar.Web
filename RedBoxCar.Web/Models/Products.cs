using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RedBoxCar.Web.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
       
        [Required]
        public string Details { get; set; }
        
        [Required]
        public string Image { get; set; }

        public int Rating { get; set; }
        
        [Required]
        public int PreparationTimeInMinutes { get; set; }
        [ForeignKey("Ingredients")]
        
        public int IngredientsListId { get; set; }
        
        public List <Ingredients> IngredientsList { get; set; } 

    }
}
