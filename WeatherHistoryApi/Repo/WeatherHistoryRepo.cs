using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherHistoryApi.Interface;
using WeatherHistoryApi.Model;

namespace WeatherHistoryApi.Repo
{
    public class WeatherHistoryRepo : IWeatherHistoryRepo
    {
        private readonly WeatherHistoryDBContext _weatherHistoryDB;

        public WeatherHistoryRepo(WeatherHistoryDBContext weatherHistoryDB)
        {
            _weatherHistoryDB = weatherHistoryDB;
        }
        public IQueryable<WeatherHistory> GetWeatherHistory()
        {
           return _weatherHistoryDB.WeatherHistorys.AsQueryable();
        }
    }
}
