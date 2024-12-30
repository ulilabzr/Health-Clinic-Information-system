using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEALTH_CLINIC_INFORMATION_SYSTEM.Model.Entity
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int? ScheduleId { get; set; }

        // Navigation properties
        //public virtual PracticeSchedule Schedule { get; set; }
        //public virtual ICollection<MedicalRecord> MedicalRecords { get; set; }
    }
}
