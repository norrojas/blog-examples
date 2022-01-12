using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MainApp
{
    public interface ISortStrategy
    {
        IOrderedEnumerable<string> Sort(IEnumerable<string> input);
    }
}
