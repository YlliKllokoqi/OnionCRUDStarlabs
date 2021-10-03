using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{

    public class SportsBetService : ISportsBetService
    {
        private IRepository<SportsBet> sportsbetRepository;

        public SportsBetService(IRepository<SportsBet> sportsbetRepository)
        {
            this.sportsbetRepository = sportsbetRepository;
        }

        public IEnumerable<SportsBet> GetSportsBets()
        {
            return sportsbetRepository.GetAll();
        }

        public SportsBet GetSportsBet(int id)
        {
            return sportsbetRepository.Get(id);
        }

        public async Task<SportsBet> AddSportsBet(SportsBet sportsBet)
        {
             var result = await sportsbetRepository.AddSportsBet(sportsBet);
             return result;
        }

        public async Task<SportsBet> DeleteSportsBet(int id)
        {
            var result =  await sportsbetRepository.DeleteSportsBet(id);
            return result;
        }

        public async Task<SportsBet> UpdateSportsBet(SportsBet sportsBet)
        {
            var result = await sportsbetRepository.UpdateSportsBet(sportsBet);
            return result;
        }
    }
}
