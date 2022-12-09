using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File_HM.Entity;

namespace File_HM.Model
{
   
        /// <summary>
        /// The 'in' means input parameter 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TPk"></typeparam>
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
