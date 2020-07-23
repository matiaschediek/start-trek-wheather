using DomainDrivenDesign.DomainObjects;
using System.Collections.Generic;
using System.Threading.Tasks;
using StartTrekWheather.Domain.Planets;

namespace StartTrekWheather.Domain.Interfaces
{
    public interface IProvidePlanets 
    {
        Task<List<Planet>> GetPlanets();
    }
    
}