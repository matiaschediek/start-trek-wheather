using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using StartTrekWheather.Domain.Days;
using StartTrekWheather.Domain.Interfaces;
using StartTrekWheather.Domain.Helpers;
using StartTrekWheather.Domain.Shared;
using DomainDrivenDesign.DomainObjects;

namespace StartTrekWheather.Domain.Services
{
    public class SolarSystemService : ISolarSystemService
    {
        private IProvidePlanets _providePlanets;

        SolarSystemService(IProvidePlanets providePlanets)
        {
            _providePlanets = providePlanets;
        }
        public async Task<Day> PredictDayWeather(DateTime day)
        {
            var planets = await _providePlanets.GetPlanets();

            var dayId = Id<Day>.Create(new Guid());
            
            List<Coordinates> coordinates = new List<Coordinates>();

            planets.ForEach(p => coordinates.Add(p.GetPositionByDay(day)));
            
            var sunCoordinates = Coordinates.Create(0,0);

            var area = Geometry.CalcTriangleArea(coordinates[0],coordinates[1],coordinates[2]);

            if(area==0){
                if(Geometry.CheckThePointOnStraight(coordinates[0],coordinates[1],sunCoordinates)){

                    return new Day(dayId, Weather.Drought); 

                }else{

                    return new Day(dayId, Weather.Optimum); 

                }
            }else{

                var areaAux =  Geometry.CalcTriangleArea(coordinates[0],coordinates[1],sunCoordinates);
                
		            if ((areaAux/area) > 1 || (areaAux/area) < 0 ){

                        return new Day(dayId, Weather.Normal); 

                    }else{

                        areaAux =  Geometry.CalcTriangleArea(coordinates[0],sunCoordinates,coordinates[2]);

                        if ((areaAux/area) > 1 || (areaAux/area) < 0 ){

                            return new Day(dayId, Weather.Normal); 

                        }else{

                             areaAux =  Geometry.CalcTriangleArea(sunCoordinates,coordinates[1],coordinates[2]);

                            if ((areaAux/area) > 1 || (areaAux/area) < 0 ){
                                return new Day(dayId, Weather.Normal); 
                            }
                            else{

                                return new Day(dayId, Weather.Rainy); 

                            }
                        }
                    }
            }
        }

        public async Task<List<Day>> PredictDayWeatherByRange(DateTime dayFrom, DateTime dayTo)
        {
            var days = new List<Day>();
            for (DateTime i = dayFrom; i <= dayTo; i.AddDays(1))
            {
                days.Add(await PredictDayWeather(i));
            }
            return days;
        }
        
        

    }

}