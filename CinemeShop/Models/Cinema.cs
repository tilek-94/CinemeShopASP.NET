using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemeShop.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Logo")]
        public string Logo { get; set; }
        [Display(Name = "Full Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
