using DomainDrivenDesign.DomainObjects;

namespace StartTrekWheather.Domain.Planets
{
    public class Clockwise : Value<bool>
    {
        public static Clockwise Create(bool value)
        {
            return new Clockwise(value);
        }
        private Clockwise(bool value) : base(value)
        {
        }
    }
}
