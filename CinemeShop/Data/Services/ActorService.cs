using CinemeShop.Data.Basa;
using CinemeShop.Models;

namespace CinemeShop.Data.Services
{
    public class ActorService : EntityBaseRepository<Actor>,IActorService
    {
        public ActorService(AppDbContext context) : base(context) { }
        

       
    }
}
