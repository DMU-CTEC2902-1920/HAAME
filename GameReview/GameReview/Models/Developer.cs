using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameReview.Models
{
    public class Developer
    {
        public int DeveloperID { get; set; }
        public virtual string DeveloperName { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual string Description { get; set; }
        public virtual int GamesProduced { get; set; }
    }
}