﻿using CinemeShop.Data.Basa;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemeShop.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Logo")]
        [Required(ErrorMessage = "Logo Cinema is required")]
        public string Logo { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = " Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Full Name must be between 3 and 50 chars")]

        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema is required")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
