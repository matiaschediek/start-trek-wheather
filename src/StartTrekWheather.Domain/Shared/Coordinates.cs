using DomainDrivenDesign.DomainObjects;

namespace StartTrekWheather.Domain.Shared
{
    public class Coordinates : Value<double,double>
    {
        public double X {get;}
        public double Y {get;}


        public static Coordinates Create(double x, double y)
        {
            return new Coordinates(x,y);
        }
        private Coordinates(double x, double y) : base(x,y)
        {
            this.X = x;
            this.Y = y;
            
        }
    }
}
