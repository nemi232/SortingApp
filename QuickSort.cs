using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTask
{
     public class QuickSortStrategy<T> : ISorts<T> where T : IComparable<T>
    {
        public List<T> Sort(List<T> data)
        {
            var array = new List<T>(data);
            QuickSort(array, 0, array.Count - 1);
            return array;
        }

        private void QuickSort(List<T> arr, int low, int high)
        {
            if (low < high)
            {
                int partitionIndex = Partition(arr, low, high);

                QuickSort(arr, low, partitionIndex - 1);
                QuickSort(arr, partitionIndex + 1, high);
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

        // void QuickSort(int[] arr, int low, int high)
        // {
        //     if (low < high)
        //     {
        //         int pi = Partition(arr, low, high);

        //         QuickSort(arr, low, pi - 1);
        //         QuickSort(arr, pi + 1, high);
        //     }
        // }

        // int Partition(int[] arr, int low, int high)
        // {
        //     int pivot = arr[high];
        //     int i = (low - 1);

        //     for (int j = low; j < high; j++)
        //     {
        //         if (arr[j] <= pivot)
        //         {
        //             i++;

        //             // Swap arr[i] and arr[j]
        //             int temp = arr[i];
        //             arr[i] = arr[j];
        //             arr[j] = temp;
        //         }
        //     }

        //     // Swap arr[i+1] and arr[high] (or pivot)
        //     int temp1 = arr[i + 1];
        //     arr[i + 1] = arr[high];
        //     arr[high] = temp1;

        //     return i + 1;
        // }
        // void QuickSort(string[] arr, int low, int high)
        // {
        //     if (low < high)
        //     {
        //         int pi = Partition(arr, low, high);

        //         QuickSort(arr, low, pi - 1);
        //         QuickSort(arr, pi + 1, high);
        //     }
        // }

        // int Partition(string[] arr, int low, int high)
        // {
        //     string pivot = arr[high];
        //     int i = (low - 1);

        //     for (int j = low; j < high; j++)
        //     {
        //         if (string.Compare(arr[j], pivot) <= 0)
        //         {
        //             i++;

        //             // Swap arr[i] and arr[j]
        //             string temp = arr[i];
        //             arr[i] = arr[j];
        //             arr[j] = temp;
        //         }
        //     }

        //     // Swap arr[i+1] and arr[high] (or pivot)
        //     string temp1 = arr[i + 1];
        //     arr[i + 1] = arr[high];
        //     arr[high] = temp1;

        //     return i + 1;
        // }
    }
}