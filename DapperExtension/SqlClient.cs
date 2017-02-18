using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Net.Extension
{
    public class SqlClient
    {
        private static string ConnectionString;
        public SqlClient(string dbConnStr)
        {
            ConnectionString = dbConnStr;
        }


        /// <summary>
        /// 查询全部
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual IEnumerable<TEntity> Query<TEntity>(string sql, dynamic parameters = null) where TEntity : class
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return SqlMapper.Query<TEntity>(conn, sql, parameters);
            }

        }

        /// <summary>
        /// 查询受影响行
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual int QueryScalar(string sql, dynamic parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return (int)SqlMapper.ExecuteScalar(conn, sql, parameters);
            }
        }

        /// <summary>
        /// 执行SQL
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public virtual int ExecuteWriteSql(string sql, dynamic parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                return SqlMapper.Execute(conn, sql, parameters);
            }
        }
    }
}
