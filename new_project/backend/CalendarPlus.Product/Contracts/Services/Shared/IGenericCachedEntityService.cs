using CalendarPlus.Product.Contracts.Shared;

namespace CalendarPlus.Product.Contracts.Services.Shared
{
    public interface IGenericCachedEntityService<TEntity> : IGenericEntityService<TEntity> where TEntity : IEntity
    {
    }
}
