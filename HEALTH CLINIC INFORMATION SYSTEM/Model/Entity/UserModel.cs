 using System.ComponentModel.DataAnnotations;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
