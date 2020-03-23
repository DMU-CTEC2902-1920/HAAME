using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReview.Models
{
    public class Game
    {
        public virtual int GameID { get; set; }
        public virtual string GameTitle { get; set; }
        public virtual string Console { get; set; }
        public virtual string GameGenre { get; set; }
        public virtual string Developer { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int Ratings { get; set; }
        public virtual DateTime ReleaseDate { get; set; }
        public virtual string Description { get; set; }
    }
}