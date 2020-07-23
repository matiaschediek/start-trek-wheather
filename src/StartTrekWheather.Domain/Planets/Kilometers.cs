using DomainDrivenDesign.DomainObjects;

namespace StartTrekWheather.Domain.Planets
{
    public class Kilometers : Value<double>
    {
        public static Kilometers Create(double value)
        {
            return new Kilometers(value);
        }
        private Kilometers(double value) : base(value)
        {
        }
        
        public static Kilometers operator *(Kilometers Kilometers, double multiplier)
        {
            return Kilometers * multiplier;
        }
        public static Kilometers operator /(Kilometers Kilometers, double multiplier)
        {
            return Kilometers * multiplier;
        }
        
        public static implicit operator double(Kilometers Kilometers)
        {
            return Kilometers;
        }
    }
}
