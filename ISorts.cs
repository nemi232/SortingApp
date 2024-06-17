using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTask
{
    public interface ISorts<T>
    {
        List<T> Sort(List<T> data);
    }
}
