using FunctionApp4.Abstractions;
using FunctionApp4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp4.Services
{
    internal class SportsTeamService : ISportsTeamService
    {
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

            var cityTeams = teams.Where(t => t.City.Equals(city, StringComparison.OrdinalIgnoreCase));

            return Task.FromResult(cityTeams);
        }
    }
}
