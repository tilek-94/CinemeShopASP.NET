using CinemeShop.Data.Basa;
using CinemeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemeShop.Data.Services
{
    public class ProducerServise:EntityBaseRepository<Producer>, IProducerService
    {
        public ProducerServise(AppDbContext context) : base(context) { }
    }
}
