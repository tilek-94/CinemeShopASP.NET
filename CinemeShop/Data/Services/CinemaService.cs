using CinemeShop.Data.Basa;
using CinemeShop.Models;

namespace CinemeShop.Data.Services
{
    public class CinemaService : EntityBaseRepository<Cinema>, ICinemaService
    {
        public CinemaService(AppDbContext context) : base(context) { }

    }
}
