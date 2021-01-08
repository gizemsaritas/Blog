using BlogAPI.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.Business.Interfaces
{
    public interface IGenericService<TEntity> where TEntity :class,ITable,new()
    {
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> FindById(int id);
        Task AddAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task RemoveAsync(TEntity entity); 
        
       
    }
}
