using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Net.Extension.Test
{
    [Table("People")]
    public class PeopleEntity
    {
        [Key(KeyType.Guid)]
        [Column("Id")]
        public int Id { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [Column("Name")]
        public string Name { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [Column("Age")]
        public int Age { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [Column("Birthday")]
        public DateTime Birthday { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Column("Sex")]
        public int Sex { get; set; }

        /// <summary>
        /// 住址
        /// </summary>
        [Column("Address")]
        public string Address { get; set; }
    }
}
