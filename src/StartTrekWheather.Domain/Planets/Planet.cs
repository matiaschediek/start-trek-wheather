using DomainDrivenDesign.DomainObjects;
using System;
using StartTrekWheather.Domain.Shared;


namespace StartTrekWheather.Domain.Planets
{
    public class Planet : Entity<Planet>
    {
        public string Name {get;}
        public Degrees DegreesPerDay {get;}
        public Kilometers SunDistance {get;}
        public Degrees InitialDegrease {get;}
        public DateTime InitialDate {get;}
        public Clockwise Clockwise {get;}

        public Planet(
            Id<Planet> id, 
            string name,
            Degrees degreesPerDay, 
            Kilometers sunDistance, 
            Degrees initialDegrease,
            DateTime initialDate,
            Clockwise clockwise): base(id)
        {
            this.Name = name;
            this.DegreesPerDay = degreesPerDay;
            this.SunDistance = sunDistance;
            this.InitialDegrease = initialDegrease;
            this.InitialDate = initialDate;
            this.Clockwise = clockwise;
        }

        public Coordinates GetPositionByDay(DateTime day){

            var daysFromDate = day.Subtract(InitialDate).TotalDays;
            var angle = (DegreesPerDay.ToRadians() * daysFromDate) + InitialDegrease.ToRadians();

            var x = SunDistance * Math.Cos(angle);
            var y = SunDistance * Math.Sin(angle);

            return Coordinates.Create(x,y);
        }

    }
}
