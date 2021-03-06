﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CocktailMagician.Web.Areas.Member.Models
{
    public class CocktailRatingViewModel
    {
        [Required]
        [Range(1, 5, ErrorMessage = "Please enter a value between 1 and 5")]
        public double Value { get; set; }

        public int CocktailId { get; set; }

        public int UserId { get; set; }

        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;

        public DateTime? ModifiedOn { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
