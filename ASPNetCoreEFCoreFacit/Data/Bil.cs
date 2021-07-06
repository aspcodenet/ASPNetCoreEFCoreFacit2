namespace ASPNetCoreEFCoreFacit.Data
{
    public class Bil
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }

        public bool HasRadio { get; set; }
    }
}