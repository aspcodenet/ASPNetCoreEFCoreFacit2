using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreEFCoreFacit.Data
{
    public class Lastbil
    {
        public int Id { get; set; }
        
        [MaxLength(50)]
        public string Manufacturer { get; set; }
        public int LoadVolumeKvm { get; set; }

        [MaxLength(6)]
        public string RegNo { get; set; }
    }
}