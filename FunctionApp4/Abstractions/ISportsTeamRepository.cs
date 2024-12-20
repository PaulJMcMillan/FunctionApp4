using FunctionApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Abstractions
{
    public interface ISportsTeamRepository
    {
        Task<bool> CreateAsync(SportsTeam sportsTeam);
        Task<IEnumerable<SportsTeam>> ReadAsync(string? city = null);
        Task<bool> UpdateAsync(SportsTeam sportsTeam);
        Task<bool> DeleteAsync(int id);
    }
}
