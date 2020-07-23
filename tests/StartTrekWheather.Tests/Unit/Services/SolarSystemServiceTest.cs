using System;
using StartTrekWheather.Domain.Interfaces;
using StartTrekWheather.Domain.Services;
using Xunit;

namespace StartTrekWheather.Tests.Unit.Services
{
    public class SolarSystemServiceTest
    {
        private ISolarSystemService _solarSystemService;

        public SolarSystemServiceTest()
        {
            
            
        }


        [Trait("Category","Unit")]
        [Fact]
        public void Test1()
        {
            var day = _solarSystemService.PredictDayWeather(DateTime.Now);

            

        }
    }
}
