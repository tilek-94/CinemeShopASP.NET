using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemeShop.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Fill Name")]
        public string FullName { get; set; }
        [Display(Name = "Bigraphy")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
