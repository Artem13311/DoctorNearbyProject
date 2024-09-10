using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DoctorNearby.Persistence.Models.Entities
{

    [Table("Specializations")]
    public class SpecializationEntity : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        public List<DoctorEntity>? Doctors { get; set; }
    }
}
