namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using GameReview.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<GameReview.Models.GameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GameReview.Models.GameContext";
        }

        protected override void Seed(GameReview.Models.GameContext context)
        {
            Game game = new Game
            {
                GameID = 3,
                GameTitle = "NBA 2K20",
                Console = "Playstation, XBOX, PC",
                Developer = "2K Sports",
                Price = Convert.ToDecimal(50.00),
                Ratings = Convert.ToInt32(9),
                ReleaseDate = Convert.ToDateTime("01 / 10 / 2019"),
                Description = "Taking NBA to a whole other level!!!"
            };
            context.Games.AddOrUpdate(g => g.GameID, game);
            context.SaveChanges();
        }
    }
}
