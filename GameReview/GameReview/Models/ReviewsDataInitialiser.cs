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
            Rev1.ReviewTitle = "The review title is inserted here";
            Rev1.GameId = 1;
            Rev1.GameTitle = "COD: Modern Warfare";
            Rev1.GameGenre = "Action";
            Rev1.Review = "The review data can be inserted here";
            Rev1.ReviewAuthour = "Tafnino";
            Rev1.Price = 50;
            Rev1.Ratings = Convert.ToInt32(9);
            context.Reviews.Add(Rev1);

            //second review
            Reviews Rev2 = new Reviews();
            Rev2.ReviewsId = 2;
            Rev2.ReviewTitle = "The review title is inserted here";
            Rev2.GameId = 2;
            Rev2.GameTitle = "Fifa 20";
            Rev2.GameGenre = "Sports";
            Rev2.Review = "The review data can be inserted here";
            Rev2.ReviewAuthour = "Tafnino_36";
            Rev2.Price = 50;
            Rev2.Ratings = Convert.ToInt32(9);
            context.Reviews.Add(Rev2);

            base.Seed(context);
        }
    }
}