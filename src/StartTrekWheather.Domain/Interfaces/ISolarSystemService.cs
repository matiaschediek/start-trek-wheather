using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using StartTrekWheather.Domain.Days;

namespace StartTrekWheather.Domain.Interfaces
{
    public interface ISolarSystemService
    {
        Task<Day> PredictDayWeather(DateTime day);
        Task<List<Day>> PredictDayWeatherByRange(DateTime dayFrom, DateTime dayTo);

    }
    
}
