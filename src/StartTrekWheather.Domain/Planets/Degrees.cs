using DomainDrivenDesign.DomainObjects;
using System;

namespace StartTrekWheather.Domain.Planets
{
    public class Degrees : Value<double>
    {
        public static Degrees Create(double value)
        {
            return new Degrees(value);
        }
        private Degrees(double value) : base(value)
        {
        }
        
        public static Degrees operator *(Degrees degrees, double multiplier)
        {
            return degrees * multiplier;
        }
        public static Degrees operator /(Degrees degrees, double multiplier)
        {
            return degrees * multiplier;
        }
        
        public static implicit operator double(Degrees degrees)
        {
            return degrees;
        }
        
        
        public double ToRadians()
        {
            return (Math.PI / 180)* this;
        }
    }
}
