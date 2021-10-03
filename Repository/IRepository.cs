using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Get(int id);
        IEnumerable<T> GetAll();
        Task<SportsBet> AddSportsBet(SportsBet sportsBet);
        Task<SportsBet> UpdateSportsBet(SportsBet sportsBet);
        Task<SportsBet> DeleteSportsBet(int BetId);

    }
}
