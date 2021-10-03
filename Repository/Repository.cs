using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> _entities;

        public Repository(ApplicationContext context)
        {
            this._context = context;
            _entities = context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.AsEnumerable();
        }

        public T Get(int id)
        {
            return _entities.SingleOrDefault(s => s.BetId == id);
        }

        public async Task<SportsBet> AddSportsBet(SportsBet sportsBet)
        {
            var result = await _context.SportsBets.AddAsync(sportsBet);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<SportsBet> DeleteSportsBet(int BetId)
        {
            var result = await _context.SportsBets.FirstOrDefaultAsync(s => s.BetId == BetId);

            if(result != null)
            {
                _context.SportsBets.Remove(result);
                await _context.SaveChangesAsync();
                return result;
            }

            return null;
        }

        public async Task<SportsBet> UpdateSportsBet(SportsBet sportsBet)
        {
            var result = await _context.SportsBets.FirstOrDefaultAsync(s => s.BetId == sportsBet.BetId);

            if(result != null)
            {
                result.BetName = sportsBet.BetName;
                result.Result = sportsBet.Result;
                result.Odds = sportsBet.Odds;
                result.Competition = sportsBet.Competition;
                result.Date = DateTime.Now;

                await _context.SaveChangesAsync();

                return result;
            }

            return null;
        }
    }
}
