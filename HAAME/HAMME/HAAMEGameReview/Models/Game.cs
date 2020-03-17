using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAAMEGameReview.Models
{
    public class Game
    {
        public virtual int GameID { get; set; }
        public virtual int Genre { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int PEGIRating { get; set; }
        public virtual Category Category { get; set; }
    }
}