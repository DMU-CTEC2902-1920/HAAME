using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameReview.Models
{
    public class PlatformsDataInitialiser : DropCreateDatabaseAlways<PlatformsContext>
    {

        protected override void Seed(PlatformsContext context)
        {
            Platforms plat1 = new Platforms();
            plat1.PlatformId = 1;
            plat1.PlatformName = "PlayStation 4";
            plat1.Developer = "Sony";
            plat1.RAM = 8;
            plat1.GPUCore = 1152;
            plat1.HDD = 1;
            plat1.Price = 399;
            context.Platforms.Add(plat1);

            Platforms plat2 = new Platforms();
            plat2.PlatformId = 2;
            plat2.PlatformName = "Xbox One";
            plat2.Developer = "Microsoft";
            plat2.RAM = 8;
            plat2.GPUCore = 768;
            plat2.HDD = 1;
            plat2.Price = 429;
            context.Platforms.Add(plat2);

            Platforms plat3 = new Platforms();
            plat3.PlatformId = 3;
            plat3.PlatformName = "Nintendo Switch";
            plat3.Developer = "Nintendo PTD";
            plat3.RAM = 4;
            plat3.GPUCore = 256;
            plat3.HDD = 32;
            plat3.Price = 279;
            context.Platforms.Add(plat3);

            base.Seed(context);
        }
        
    }
}