using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTask
{
     public class QuickSort<T> : ISorts<T> where T : IComparable<T>
    {
        public List<T> Sort(List<T> data)
        {
            var array = new List<T>(data);
            QuickSortt(array, 0, array.Count - 1);
            return array;
        }

        private void QuickSortt(List<T> arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                QuickSortt(arr, low, partitionIndex - 1);
                QuickSortt(arr, partitionIndex + 1, high);
            }
        }

        private int Partition(List<T> arr, int low, int right)
        {
            T pivot = arr[right];
            int i = low - 1;

            for (int j = low; j < right; j++)
            {
                if (arr[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    T temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            T temp1 = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp1;

            return i + 1;
        }

       
    }
}