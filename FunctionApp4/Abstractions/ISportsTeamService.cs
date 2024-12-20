using FunctionApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Abstractions
{
    public interface ISportsTeamService
    {
        Task<IEnumerable<SportsTeam>> ReadAsync(string? city = null);
    }
}
