﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coditas.Ecom.Repositories
{
    public interface IDbRepository<TEntity,in TPk> where TEntity :class
    {
        Task<IEnumerable<TEntity>> GetAsync();
        Task<TEntity> GetAsync(TPk id);
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TPk id);
        Task<TEntity> UpdateAsync(TPk id, TEntity entity);
        
    }
}
