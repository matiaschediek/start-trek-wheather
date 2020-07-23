using DomainDrivenDesign.DomainObjects;
using System;

namespace StartTrekWheather.Domain.Shared
{
    public class Perimeter : Value<double>
    {
        public static Perimeter Create(double value)
        {
            return new Perimeter(value);
        }
        
        public static Perimeter CreateByCoordinates(Coordinates a, Coordinates b, Coordinates c)
        {
            var l1 = Math.Sqrt(Math.Pow((a.X-b.X), 2) + Math.Pow((a.Y-b.Y), 2));
            var l2 = Math.Sqrt(Math.Pow((c.X-b.X), 2) + Math.Pow((c.Y-b.Y), 2));
            var l3 = Math.Sqrt(Math.Pow((a.X-c.X), 2) + Math.Pow((a.Y-c.Y), 2));
            return new Perimeter(l1+l2+l3);
        }

        
        private Perimeter(double value) : base(value)
        {
            
        }
    }
}
