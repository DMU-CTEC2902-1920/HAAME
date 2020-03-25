using System;
using System.Collections.Generic;
//I'm usin the data annotations library to set strict rules for my class attributes
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameReview.Models
{
    public class Platforms
    {
        [Key]
        public virtual int PlatformId { get; set; }
        [Required]
        public virtual string PlatformName { get; set; }
        [Required]
        public virtual string Developer { get; set; }
        [Required]
        public virtual int RAM { get; set; }
        [Required]
        public virtual int GPUCore { get; set; }
        [Required]
        public virtual int HDD { get; set; }
        [Required]
        public virtual int Price { get; set; }
    }
}