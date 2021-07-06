using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ASPNetCoreEFCoreFacit.Data
{
    public class DataInitializer
    {
        public static void SeedData(ApplicationDbContext dbContext)
        {
            dbContext.Database.Migrate();

            SeedBilar(dbContext);
            SeedLastbilar(dbContext);
        }

        private static void SeedLastbilar(ApplicationDbContext dbContext)
        {
            if (!dbContext.Lastbilar.Any(r => r.RegNo == "BBB111"))
            {
                dbContext.Lastbilar.Add(new Lastbil()
                {
                    Manufacturer = "Volvo",
                    RegNo = "BBB111",
                    LoadVolumeKvm = 12
                });
            }
            if (!dbContext.Lastbilar.Any(r => r.RegNo == "RBB111"))
            {
                dbContext.Lastbilar.Add(new Lastbil()
                {
                    Manufacturer = "Volvo",
                    RegNo = "RBB111",
                    LoadVolumeKvm = 11
                });
            }
            if (!dbContext.Lastbilar.Any(r => r.RegNo == "CBB111"))
            {
                dbContext.Lastbilar.Add(new Lastbil()
                {
                    Manufacturer = "Scania",
                    RegNo = "CBB111",
                    LoadVolumeKvm = 121
                });
            }

        }

        private static void SeedBilar(ApplicationDbContext dbContext)
        {
            if(!dbContext.Bilar.Any(r=>r.RegNo == "DAA111"))
            {
                dbContext.Bilar.Add(new Bil
                {
                    HasRadio = true, Manufacturer = "Volvo", Model = "XC60",
                    Price = 12000, RegNo = "DAA111", Year = 2015
                });
            }

            if (!dbContext.Bilar.Any(r => r.RegNo == "AAA112"))
            {
                dbContext.Bilar.Add(new Bil
                {
                    HasRadio = true,
                    Manufacturer = "Volvo",
                    Model = "XC70",
                    Price = 1000,
                    RegNo = "AAA112",
                    Year = 2014
                });
            }

            if (!dbContext.Bilar.Any(r => r.RegNo == "AAA113"))
            {
                dbContext.Bilar.Add(new Bil
                {
                    HasRadio = true,
                    Manufacturer = "Saab",
                    Model = "V4",
                    Price = 1000,
                    RegNo = "AAA113",
                    Year = 1973
                });
            }


            if (!dbContext.Bilar.Any(r => r.RegNo == "AAA114"))
            {
                dbContext.Bilar.Add(new Bil
                {
                    HasRadio = true,
                    Manufacturer = "Saab",
                    Model = "V4",
                    Price = 1200,
                    RegNo = "AAA114",
                    Year = 1974
                });
            }

            if (!dbContext.Bilar.Any(r => r.RegNo == "AAA115"))
            {
                dbContext.Bilar.Add(new Bil
                {
                    HasRadio = true,
                    Manufacturer = "Saab",
                    Model = "V4",
                    Price = 12200,
                    RegNo = "AAA115",
                    Year = 1975
                });
            }

            dbContext.SaveChanges();



        }
    }
}