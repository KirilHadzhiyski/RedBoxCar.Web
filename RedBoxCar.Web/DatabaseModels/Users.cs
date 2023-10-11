using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RedBoxCar.Web.DatabaseModels
{
    [Table("Users")]
    public class Users : IdentityUser
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Password is Required")]
        public string Password { get; set; }
        
       
        public int PastOrdersListId { get; set; }
        
        public List<Orders> PastOrdersList { get; set; }
    }
}
