using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSV_operation.Entity;

namespace CSV_operation.Model
{
        public interface IDbOperations<TEntity, in TPk> where TEntity : Staff
        {
            List<TEntity> GetAll();
            TEntity Get(TPk id);
            List<TEntity> Create(TEntity entity);
            List<TEntity>Update(TPk id, TEntity entity);
            List<TEntity> Delete(TPk id);
        public long GrossSalary(TEntity entity);
        public decimal Tax1(TEntity entity);
        public decimal HospitalShare(TEntity entity);

    }   
}
