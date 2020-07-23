using DomainDrivenDesign.DomainObjects;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StartTrekWheather.Domain.Interfaces
{
    public interface IRepository <TDomainModel, TData> where TDomainModel : Entity<TDomainModel>
    {
        Task<TDomainModel> GetById(Id<TDomainModel> id);
        Task<List<TDomainModel>> List(ISpecification<TDomainModel> spec = null);
        Task Update(TDomainModel entity);
    }
    
}