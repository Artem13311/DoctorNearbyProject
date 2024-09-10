using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using DoctorNearby.Persistence.Models.Stuff.Enums;


namespace DoctorNearby.Persistence.Models.Entities
{
    [Table("Patients")]

    public class PatientEntity : BaseEntity
    {
        [MaxLength(50)]
        public string Surname { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Patronymic { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Address { get; set; } = string.Empty;
        public DateOnly Birthday { get; set; }
        public ESex Sex { get; set; }
        public Guid DistrictId { get; set; }
        public DistrictEntity District { get; set; }

    }
}
