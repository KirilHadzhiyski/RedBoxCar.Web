using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RedBoxCar.Web.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DeliveryTimeInMinutes { get; set; }

        public string Details { get; set; }

        [ForeignKey("Products")]
        public int ProductsListId { get; set; }

        public List<Products> ProductsList { get; set; }
       
        [Required]
        public  DateTime CreationTime { get; set; }
    }
}
