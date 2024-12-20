using FunctionApp4.Abstractions;
using FunctionApp4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionApp4
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;
        private readonly ISportsTeamService _teamService;
        public Function1(ILogger<Function1> logger, ISportsTeamService sportsTeamService)
        {
            _logger = logger;
            _teamService = sportsTeamService;
        }

        [Function("Function1")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequest req)
        {
            string? city = req.Query["city"];
            var teams = await _teamService.ReadAsync(city);

            return new OkObjectResult(new
            {
                City = city,
                Teams = teams
            });
        }
    }
}
