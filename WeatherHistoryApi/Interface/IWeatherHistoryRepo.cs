using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherHistoryApi.Model;

namespace WeatherHistoryApi.Interface
{
   public interface IWeatherHistoryRepo
    {
        IQueryable<WeatherHistory> GetWeatherHistory();
    }
}
