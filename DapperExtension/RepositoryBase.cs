using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Net.Extension
{
    public class RepositoryBase<TDbContext, TEntity> : IRepository<TEntity> where TEntity : class where TDbContext : DbContext
    {
        


        public TDbContext DbContext { get; private set; }

        public SqlClient SqlClient { get { return DbContext.SqlClient; } }

        //public ISqlGenerator<TEntity, TPrimaryKey> SqlGenerator { get; set; }

        public RepositoryBase(TDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public object Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
