using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameReview.Models
{
    public class Reviews
    {
        [Key]
        public virtual int ReviewsId { get; set; }
        public virtual string ReviewTitle { get; set; }
        public virtual int GameId { get; set; }
        public virtual string GameTitle { get; set; }
        public virtual string GameGenre { get; set; }
        public virtual string Review { get; set; }
        public virtual string ReviewAuthour { get; set; }
        public virtual int Price { get; set; }
        public virtual int Ratings { get; set; }
    }
}