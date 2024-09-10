using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace DoctorNearby.Persistence.Models.Entities
{
    [Table("Doctors")]

    public class DoctorEntity : BaseEntity
    {
        [MaxLength(70)]
        public string FullName { get; set; } = string.Empty;
        public Guid CabinetId { get; set; }
        public CabinetEntity Cabinet { get; set; }
        public Guid SpecializationId { get; set; }
        public SpecializationEntity Specialization { get; set; }
        public Guid? DistrictId { get; set; }
        public DistrictEntity? District { get; set; }
    }
}
