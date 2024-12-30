using System.ComponentModel.DataAnnotations;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity
{
    public class MedicineModel
    {
        [Key]
        public int medicine_Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string type { get; set; }
        [Required]
        public int stock { get; set; }
        [Required]
        public decimal price { get; set; }
    }
}
