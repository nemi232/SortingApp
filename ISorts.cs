using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTask
{
    public interface ISorts
    {
        void BubbleSort(int[] arr);
        void QuickSort(int[] arr, int low, int high);

        void MergeSort();
    }
}
