using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameReview.Models
{
    public class GameDataInitialiser: DropCreateDatabaseAlways<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            Game game1 = new Game();
            game1.GameID = 1;
            game1.GameTitle = "COD: Modern Warfare";
            game1.Console = "Playstation, XBOX, PC";
            game1.GameGenre = "Action";
            game1.Developer = "Activision";
            game1.Price = Convert.ToDecimal(50.00);
            game1.Ratings = Convert.ToInt32(9);
            game1.ReleaseDate = Convert.ToDateTime("01 / 10 / 2019");
            game1.Description = "Call of Duty: Modern Warfare (2019) sees the franchise move back in a promising direction, flaunting stunning graphics, fast-paced action and more multiplayer modes than you can shake a stick at. But the biggest change is in tone, with the campaign shifting to darker, more mature content that has split opinion and tests player's morals. It's uncomfortable at times, but it's the most thought-provoking instalation the series has seen yet - for better or worse.";
            context.Games.Add(game1);

            Game game2 = new Game();
            game2.GameID = 2;
            game2.GameTitle = "Fifa 20";
            game2.Console = "Playstation, XBOX, PC";
            game2.GameGenre = "Sports";
            game2.Developer = "EA Sports";
            game2.Price = Convert.ToDecimal(50.00);
            game2.Ratings = Convert.ToInt32(9);
            game2.ReleaseDate = Convert.ToDateTime("01 / 10 / 2019");
            game2.Description = "FIFA 20 is a football simulation video game published by Electronic Arts as part of the FIFA series. It is the 27th installment in the FIFA series, and was released on 27 September 2019 for Microsoft Windows, PlayStation 4, Xbox One, and Nintendo Switch. Real Madrid winger Eden Hazard was named the new cover star of the Regular Edition, with Liverpool defender Virgil van Dijk on the cover of the Champions Edition. Former Juventus and Real Madrid midfielder Zinedine Zidane was later named as the cover star for the Ultimate Edition.";
            context.Games.Add(game2);

            Game game3 = new Game();
            game3.GameID = 3;
            game3.GameTitle = "Fortnite";
            game3.Console = "Playstation, XBOX, PC";
            game3.GameGenre = "Action";
            game3.Developer = "Epic Games";
            game3.Price = Convert.ToDecimal(0.00);
            game3.Ratings = Convert.ToInt32(9);
            game3.ReleaseDate = Convert.ToDateTime("21 / 07 / 2017");
            game3.Description = "Fortnite is an online video game developed by Epic Games and released in 2017. It is available in three distinct game mode versions that otherwise share the same general gameplay and game engine: Fortnite: Save the World, a cooperative shooter-survival game for up to four players to fight off zombie-like creatures and defend objects with fortifications they can build; Fortnite Battle Royale, a free-to-play battle royale game where up to 100 players fight to be the last person standing; and Fortnite Creative, where players are given complete freedom to create worlds and battle arenas. The first two-game modes were released in 2017 as early access titles and Creative was released on December 6, 2018. Save the World is available only for Windows, macOS, PlayStation 4, and Xbox One, while Battle Royale and Creative released for those platforms, in addition for Nintendo Switch, iOS and Android devices.";
            context.Games.Add(game3);

            Game game4 = new Game();
            game4.GameID = 3;
            game4.GameTitle = "Rocket League";
            game4.Console = "Playstation, XBOX, PC";
            game4.GameGenre = "Sports";
            game4.Developer = "Epic Games";
            game4.Price = Convert.ToDecimal(15.00);
            game4.Ratings = Convert.ToInt32(9);
            game4.ReleaseDate = Convert.ToDateTime(" 07/ 07 / 2015");
            game4.Description = "Rocket League is a vehicular soccer video game developed and published by Psyonix. The game was first released for Microsoft Windows and PlayStation 4 in July 2015, with ports for Xbox One and Nintendo Switch being released later on. In June 2016, 505 Games began distributing a physical retail version for PlayStation 4 and Xbox One, with Warner Bros. Interactive Entertainment taking over those duties by the end of 2017. Versions for macOS and Linux were also released in 2016, but support for their online services were dropped in 2020.";
            context.Games.Add(game4);
            base.Seed(context);
        }
    }
}