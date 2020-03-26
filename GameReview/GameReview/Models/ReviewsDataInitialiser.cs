using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GameReview.Models
{
    public class ReviewsDataInitialiser: DropCreateDatabaseAlways<ReviewsContext>
    {
        protected override void Seed(ReviewsContext context)
        {
            //first review
            Reviews Rev1 = new Reviews();
            Rev1.ReviewsId = 1;
            Rev1.ReviewTitle = "COD MW RULES!";
            Rev1.GameId = 1;
            Rev1.GameTitle = "COD: Modern Warfare";
            Rev1.GameGenre = "Action";
            Rev1.Review = "Picking up smoothly from where MW3 left off, the game is bold as it utilises a brand-new graphics engine and this creates a heightened sense of realism. A new set of storyline characters captivate users and immerse us into the game. Top notch!";
            Rev1.ReviewAuthour = "Blueboy_100";
            Rev1.Price = Convert.ToInt32(50);
            Rev1.Ratings = Convert.ToInt32(9);
            context.Reviews.Add(Rev1);

            //second review
            Reviews Rev2 = new Reviews();
            Rev2.ReviewsId = 2;
            Rev2.ReviewTitle = "Disappointing but we still play :(";
            Rev2.GameId = 2;
            Rev2.GameTitle = "Fifa 20";
            Rev2.GameGenre = "Sports";
            Rev2.Review = "Where to start?!?! The engine has got worse, nothing meaningfully has been added to the career mode and the gameplay is questionable at best. I paid to be disappointed.";
            Rev2.ReviewAuthour = "ADT-193";
            Rev2.Price = Convert.ToInt32(50);
            Rev2.Ratings = Convert.ToInt32(4);
            context.Reviews.Add(Rev2);

            //third review
            Reviews Rev3 = new Reviews();
            Rev3.ReviewsId = 3;
            Rev3.ReviewTitle = "Best Battle Royale game!";
            Rev3.GameId = 3;
            Rev3.GameTitle = "Fornite";
            Rev3.GameGenre = "Action, Battle Royale, Survival";
            Rev3.Review = "What sets Fortnite apart from its competitors in the Battle Royale industry is that there is constant change and new content. This encourages players to take part in easter eggs, rank rewards and more whilst offering an enjoyable and smooth gaming experience.";
            Rev3.ReviewAuthour = "Anzilla365";
            Rev3.Price = Convert.ToInt32(0);
            Rev3.Ratings = Convert.ToInt32(10);
            context.Reviews.Add(Rev3);

            //fourth review
            Reviews Rev4 = new Reviews();
            Rev4.ReviewsId = 4;
            Rev4.ReviewTitle = "Cars and football...";
            Rev4.GameId = 4;
            Rev4.GameTitle = "Rocket League";
            Rev4.GameGenre = "Sports";
            Rev4.Review = "The idea of playing football in cars is very unique but I must say the approach taken in Rocket League is rather impressive. The mechanincs of the game and the fact that it is something very diferent from what we're used to make it a top class game, unfortunely the match making can occasionaly let you down.";
            Rev4.ReviewAuthour = "A_Pro";
            Rev4.Price = Convert.ToInt32(15);
            Rev4.Ratings = Convert.ToInt32(7);
            context.Reviews.Add(Rev4);

            //fifth review
            Reviews Rev5 = new Reviews();
            Rev5.ReviewsId = 5;
            Rev5.ReviewTitle = "Rockstar never disappoints";
            Rev5.GameId = 5;
            Rev5.GameTitle = "Grand Theft Auto 5";
            Rev5.GameGenre = "Action, Adventure";
            Rev5.Review = "The latest installation in the Grand Theft Auto series sees three new characters on a heist journey, filled with action, adventure and amusing gameplay along the way. The game features online/multiplayer modes that include a range of activites for players to partake in. It never lacks fun as it often features new additions to the game. Definitely one of Rockstars best games.";
            Rev5.ReviewAuthour = "Tafnino_ST";
            Rev5.Price = Convert.ToInt32(49);
            Rev5.Ratings = Convert.ToInt32(10);
            context.Reviews.Add(Rev5);

            base.Seed(context);
        }
    }
}