using System.Collections.Generic;
using System.Threading.Tasks;

namespace SOS.Infrastructure.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(long id);
        Task Add(TEntity entity);
        Task Update(TEntity entity);
        Task TrueDelete(TEntity entity);
        Task Delete(long id);
    }
}