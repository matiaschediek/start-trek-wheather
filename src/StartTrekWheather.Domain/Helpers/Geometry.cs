using StartTrekWheather.Domain.Shared;
using System;

namespace StartTrekWheather.Domain.Helpers
{
    public class Geometry
    {
        static public double CalcTriangleArea(Coordinates a, Coordinates b, Coordinates c){

            var area = Math.Abs(a.X*(b.Y - c.Y) + b.X*(c.Y - a.Y) + c.X*(a.Y - b.Y));

            return area/2;
        }

        static public bool CheckThePointOnStraight(Coordinates straightA, Coordinates straightB, Coordinates Point)
        {
            	var e1 = (Point.Y - straightA.Y) / (Point.X - straightA.X);

                var e2 = (straightB.Y - straightA.Y) / (straightB.X - straightA.X);

                return e1 == e2;
        }
        
    }
    
}