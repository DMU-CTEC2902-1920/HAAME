using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameReview.Models
{
    public class DeveloperDataInitialiser:DropCreateDatabaseAlways<DeveloperContext>
    {
        protected override void Seed(DeveloperContext context)
        {
            Developer developer1 = new Developer();
            developer1.DeveloperID = 1;
            developer1.DeveloperName = "EA Sports";
            developer1.StartDate = Convert.ToDateTime("01/01/1991");
            developer1.Description = "EA Sports is a division of Electronic Arts that develops and publishes sports video games. Formerly a marketing gimmick of Electronic Arts, in which they tried to imitate real-life sports networks by calling themselves the EA Sports Network (EASN) with pictures or endorsements with real commentators such as John Madden, it soon grew up to become a sub-label on its own, releasing game series such as FIFA, NHL, NBA Live and Madden NFL.";
            developer1.GamesProduced = 148;
            context.Developers.Add(developer1);

            Developer developer2 = new Developer();
            developer2.DeveloperID = 2;
            developer2.DeveloperName = "Electronic Arts";
            developer2.StartDate = Convert.ToDateTime("27/05/1982");
            developer2.Description = "Electronic Arts Inc. is an American video game company headquartered in Redwood City, California. It is the second - largest gaming company in the Americas and Europe by revenue and market capitalization after Activision Blizzard and ahead of Take-Two Interactive and Ubisoft as of March 2018.";
            developer2.GamesProduced = 200;
            context.Developers.Add(developer2);

            Developer developer3 = new Developer();
            developer3.DeveloperID = 3;
            developer3.DeveloperName = "Activision";
            developer3.StartDate = Convert.ToDateTime("01/10/1979");
            developer3.Description = "Activision Publishing, Inc. is an American video game publisher based in Santa Monica, California. It currently serves as the publishing business for its parent company, Activision Blizzard, and consists of several subsidiary studios. ";
            developer3.GamesProduced = 200;
            context.Developers.Add(developer3);

            Developer developer4 = new Developer();
            developer4.DeveloperID = 4;
            developer4.DeveloperName = "Ubisoft";
            developer4.StartDate = Convert.ToDateTime("12/03/1986");
            developer4.Description = "Ubisoft Entertainment SA is a French video game company headquartered in Montreuil with several development studios across the world. It publishes games for several video game franchises, including Rayman, Raving Rabbids, Prince of Persia, Assassin's Creed, Far Cry, Just Dance, and Tom Clancy. ";
            developer4.GamesProduced = 198;
            context.Developers.Add(developer4);
            base.Seed(context);
        }
    }
}