using System.Collections.Generic;
using System.Linq;

namespace MainApp
{
    public class SortDescendingStrategy : ISortStrategy
    {
        public IOrderedEnumerable<string> Sort(IEnumerable<string> input) 
            => input.OrderByDescending(x => x);
    }
}
