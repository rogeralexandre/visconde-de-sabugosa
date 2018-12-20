using System.ComponentModel.DataAnnotations;

namespace JSONSCHEMA_VALIDADOR
{
    public class Building
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [EnumDataType(typeof(BuildingZone))]
        public string Zone { get; set; }
    }

    internal enum BuildingZone
    {
        Residential,
        Commercial,
        Industrial
    }

    public class BuildingReport
    {
        [Required]
        public string Date { get; set; }

        [Required]
        [EnumDataType(typeof(BuildingZone))]
        public int Zone { get; set; }
    }
}
