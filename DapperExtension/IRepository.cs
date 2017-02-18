using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Net.Extension
{
    public interface IRepository<TEntity> where TEntity : class
    {

        object Insert(TEntity entity);

        bool Update(TEntity entity);

        bool Delete(TEntity entity);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression);

        
    }
}
