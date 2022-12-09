using API_.Models;

namespace API_.Services
{
        public interface IDbAccessService<TEntity, in TPk> where TEntity : class
        {
            Task<IEnumerable<TEntity>> GetAsync();
            Task<TEntity> GetAsync(TPk id);
            
            
    }
}

