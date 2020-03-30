using System;
using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeatherHistoryApi.Interface;
using WeatherHistoryApi.Model;

namespace WeatherHistoryApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherHistoryController : ControllerBase
    {
        private readonly ILogger<WeatherHistoryController> _logger;
        private readonly IWeatherHistoryService _weatherHistoryService;

        public WeatherHistoryController(ILogger<WeatherHistoryController> logger, IWeatherHistoryService weatherHistoryService)
        {
            _weatherHistoryService = weatherHistoryService;
            _logger = logger;
        }

        [HttpGet]
        [EnableQuery]
        public IQueryable<WeatherHistory> Get()
        {
            try
            {
                return _weatherHistoryService.WeatherHistoryOdata();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
