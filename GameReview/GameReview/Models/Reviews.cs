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
        [Required]
        public virtual string ReviewTitle { get; set; }
        public virtual int GameId { get; set; }
        [Required]
        public virtual string GameTitle { get; set; }
        [Required]
        public virtual string GameGenre { get; set; }
        [Required]
        [StringLength(500)]
        public virtual string Review { get; set; }
        [Required]
        public virtual string ReviewAuthour { get; set; }
        public virtual int Price { get; set; }
        public virtual int Ratings { get; set; }
    }
}