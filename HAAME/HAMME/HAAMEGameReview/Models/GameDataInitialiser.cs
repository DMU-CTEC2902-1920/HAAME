using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace HAAMEGameReview.Models
{
    public class GameDataInitialiser: DropCreateDatabaseAlways<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            Category cat1 = new Category();
            cat1.CategoryId = 1;
            cat1.Name = "EA Sports";
            cat1.Description = "Makes sports games";
            context.Categories.Add(cat1);
            Category cat2 = new Category();
            cat2.CategoryId = 2;
            cat2.Name = "2K Sporks";
            cat2.Description = "American developer";
            context.Categories.Add(cat2);
            Category cat3 = new Category();
            cat3.CategoryId = 2;
            cat3.Name = "2K Sporks";
            cat3.Description = "American developer";
            context.Categories.Add(cat3);
            Game game1 = new Game();
            game1.GameID = 1;
            game1.Genre = 1;
            game1.Name = "FIFA 20";
            game1.Description = "Taking football game to a whole other level!!!";
            game1.Category = cat1;
            game1.PEGIRating = 3;
            context.Games.Add(game1);
            Game game2 = new Game();
            game2.GameID = 2;
            game2.Genre = 2;
            game2.Name = "NBA 2K20";
            game2.Description = "Basketball game";
            game2.Category = cat2;
            game2.PEGIRating = 3;
            context.Games.Add(game2);

            base.Seed(context);
        }

}
}