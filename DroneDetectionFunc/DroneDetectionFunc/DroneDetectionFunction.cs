using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DroneDetectionFunc
{
    public class DroneDetectionFunction
    {
        private readonly ILogger<DroneDetectionFunction> _logger;

        public DroneDetectionFunction(ILogger<DroneDetectionFunction> logger)
        {
            _logger = logger;
        }

        [Function("DroneDetectionFunction")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
