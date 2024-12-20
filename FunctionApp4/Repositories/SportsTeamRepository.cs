using FunctionApp4.Abstractions;
using FunctionApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Repositories
{
    public class SportsTeamRepository : ISportsTeamRepository
    {
        public Task<bool> CreateAsync(SportsTeam sportsTeam)
        {
            //Mock
            return Task.FromResult(true);
        }

        public Task<bool> DeleteAsync(int id)
        {
            //Mock
            return Task.FromResult(true);
        }

        public Task<IEnumerable<SportsTeam>> ReadAsync(string? city = null)
        {
            var teams = new List<SportsTeam>()
            {
                new SportsTeam
                {
                    Id = 1,
                    Name="Clippers",
                    City="LA"
                },
                new SportsTeam
                {
                    Id = 2,
                    Name="Lakers",
                    City="LA"
                },
                new SportsTeam
                {
                    Id = 3,
                    Name="Bulls",
                    City="Chicago"
                },
            };

            if (string.IsNullOrEmpty(city))
            {
                return Task.FromResult((IEnumerable<SportsTeam>)teams);
            }

            var cityTeams = teams.Where(x=> x.City == city);

            return Task.FromResult(cityTeams);
        }

        public Task<bool> UpdateAsync(SportsTeam sportsTeam)
        {
            return Task.FromResult(true);
        }
    }
}
