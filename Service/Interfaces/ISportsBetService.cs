using DataAccess;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service
{
    public interface ISportsBetService
    {
        IEnumerable<DataAccess.SportsBet> GetSportsBets();
        DataAccess.SportsBet GetSportsBet(int id);
        Task<DataAccess.SportsBet> AddSportsBet(SportsBet sportsBet);
        Task<DataAccess.SportsBet> UpdateSportsBet(SportsBet sportsbet);
        Task<SportsBet> DeleteSportsBet(int id);
    }

}
