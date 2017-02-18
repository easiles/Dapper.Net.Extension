using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper.Net.Extension
{
    public class KeyAttribute : Attribute
    {
        public KeyType KeyType { get; }
        public KeyAttribute(KeyType type)
        {
            KeyType = type;
        }
    }
}
