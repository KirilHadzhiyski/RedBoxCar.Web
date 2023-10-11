using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RedBoxCar.Web.Models
{
    public class Ingredients
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Icon { get; set; }
    }
}
