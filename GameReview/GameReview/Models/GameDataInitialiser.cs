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
            game2.GameID = 1;
            game2.GameTitle = "Fifa 20";
            game2.Console = "Playstation, XBOX, PC";
            game2.GameGenre = "Sports";
            game2.Developer = "EA Sports";
            game2.Price = Convert.ToDecimal(50.00);
            game2.Ratings = Convert.ToInt32(9);
            game2.ReleaseDate = Convert.ToDateTime("01 / 10 / 2019");
            game2.Description = "Its animations still feel a little janky and its players still skate across the pitch when they should be grounded upon it. Overall, though, FIFA 20 plays a fun game of football. Fast players are fast, crafting goals is more realistic than it was in FIFA 19, and the shooting is more reliable.";
            context.Games.Add(game2);
            base.Seed(context);
        }
    }
}