using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RedBoxCar.Web.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
        
        [ForeignKey("Orders")]
        public int PastOrdersListId { get; set; }
        
        public List<Orders> PastOrdersList { get; set; }
    }
}
