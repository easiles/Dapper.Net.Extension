using System;

namespace Dapper.Net.Extension
{
    /// <summary>
    /// 表名
    /// </summary>
    public class TableAttribute : Attribute
    {
        /// <summary>
        /// 数据库表名
        /// </summary>
        public string TableName { get; }

        public TableAttribute(string tableName)
        {
            TableName = tableName;
        }
    }
}
