using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HAAMEGameReview.Models
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

    }
}