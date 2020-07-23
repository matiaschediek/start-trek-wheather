using System;
using System.Linq.Expressions;
using DomainDrivenDesign.DomainObjects;

namespace StartTrekWheather.Domain.Interfaces
{
    public interface ISpecification <TDomainModel> where TDomainModel : Entity<TDomainModel>
    {
        Expression<Func<TDomainModel, bool>> Criteria { get; }
    }
    
}