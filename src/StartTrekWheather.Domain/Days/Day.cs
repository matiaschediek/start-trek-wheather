using DomainDrivenDesign.DomainObjects;
using System;
using System.Collections.Generic;

namespace StartTrekWheather.Domain.Days
{
    public class Day : Entity<Day>
    {
        public DateTime Date {get;}
        public Weather Weather {get;}

        public Day(Id<Day> id, Weather weather): base(id)
        {}
        
    }
}