using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WeatherHistoryApi.Model
{
    [Table("WeatherHistory")]
    public class WeatherHistory
    {
        [Column("dt")]
        public int DT { get; set; }

        [Column("dt_iso")]
        public DateTimeOffset Dt_iso { get; set; }

        [Column("timezone")]
        public int Timezone { get; set; }

        [Column("city_name")]
        public string CityName { get; set; }

        [Column("lat")]
        public double Lat { get; set; }

        [Column("lon")]
        public double Lon { get; set; }

        [Column("temp")]
        public double Temp { get; set; }

        [Column("feels_like")]
        public double FeelsLike { get; set; }

        [Column("temp_min")]
        public double TempMin { get; set; }

        [Column("temp_max")]
        public double TempMax { get; set; }

        [Column("pressure")]
        public double Pressure { get; set; }

        [Column("sea_level")]
        public double? SeaLevel { get; set; }

        [Column("grnd_level")]
        public double? GroundLevel { get; set; }

        [Column("humidity")]
        public double Humidity { get; set; }

        [Column("wind_speed")]
        public double WindSpeed { get; set; }

        [Column("wind_deg")]
        public double WindDeg { get; set; }

        [Column("rain_1h")]
        public double? Rain_1h { get; set; }

        [Column("rain_3h")]
        public double? Rain_3h { get; set; }

        [Column("snow_1h")]
        public double? Snow_1h { get; set; }

        [Column("snow_3h")]
        public double? Snow_3h { get; set; }

        [Column("clouds_all")]
        public double CloudsAll { get; set; }

        [Column("weather_id")]
        public double WeatherID { get; set; }

        [Column("weather_main")]
        public string WeatherMain { get; set; }

        [Column("weather_description")]
        public string Description { get; set; }

        [Column("weather_icon")]
        public string Icon { get; set; }
    }
}
