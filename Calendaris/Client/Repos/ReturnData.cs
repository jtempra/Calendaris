using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calendaris.Client.Repos
{
    public class ReturnData<T>
    {
        public List<T> Items { get; set; }
        public int Count { get; set; }
    }
}
