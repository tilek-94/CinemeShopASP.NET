using CinemeShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemeShop.Data.Services
{
    public class ServiceActor : IServiceActor
    {
        private readonly AppDbContext _context;

        public ServiceActor(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Actor actor)
        {
          await _context.AddAsync(actor);
          await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var ActorById= await _context.Actors.FirstOrDefaultAsync(a => a.Id == id);
            _context.Actors.Remove(ActorById);
            await _context.SaveChangesAsync();
          
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            return await  _context.Actors.ToListAsync();
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            return await _context.Actors.Where(a => a.Id == id).FirstOrDefaultAsync();  
        }

        public async Task<Actor> UpdateAsync(int id, Actor actor)
        {
             _context.Update(actor);
            await _context.SaveChangesAsync();
            return actor;
        }
    }
}
