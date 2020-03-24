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

            base.Seed(context);
        }
    }
}