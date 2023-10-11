using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RedBoxCar.Web.DatabaseModels
{
    [Table("Orders")]
    public class Orders
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Delivery Time is Required")]

        public int DeliveryTimeInMinutes { get; set; }

        public string Details { get; set; }

      
        public int ProductsListId { get; set; }

        public List<Products> ProductsList { get; set; }
       
        [Required(ErrorMessage ="Creation Time is Required")]
        public  DateTime CreationTime { get; set; }
    }
}
