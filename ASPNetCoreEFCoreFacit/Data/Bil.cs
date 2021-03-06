using System.ComponentModel.DataAnnotations;

namespace ASPNetCoreEFCoreFacit.Data
{
    public class Bil
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Manufacturer { get; set; }
        
        [MaxLength(20)]
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public bool HasRadio { get; set; }

        [MaxLength(6)]
        public string RegNo { get; set; }
    }
}