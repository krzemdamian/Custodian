using System.Xml;

namespace Custodian.Domain.Interfaces
{
    public interface IReadWriteRepository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity>
        where TEntity : class
    {
    }
}