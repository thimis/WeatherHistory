using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherHistoryApi.Interface;
using WeatherHistoryApi.Model;

namespace WeatherHistoryApi.Service
{
    public class WeatherHistoryService : IWeatherHistoryService
    {
        private readonly IWeatherHistoryRepo _weatherHistoryRepo;
        public WeatherHistoryService(IWeatherHistoryRepo weatherHistoryRepo)
        {
            _weatherHistoryRepo = weatherHistoryRepo;
        }
        public IQueryable<WeatherHistory> WeatherHistoryOdata()
        {
            return _weatherHistoryRepo.GetWeatherHistory();
        }
    }
}
