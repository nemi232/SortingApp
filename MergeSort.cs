using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTask
{
    //divide and conquer 
    public class MergeSort<T> : ISorts<T> where T : IComparable<T>
    {
       public List<T> Sort(List<T> data)
    {
        if (data.Count <= 1)
            return data;

        int middle = data.Count / 2;
        List<T> left = data.GetRange(0, middle);
        List<T> right = data.GetRange(middle, data.Count - middle);

        left = Sort(left);
        right = Sort(right);

        return Merge(left, right);
    }

    private List<T> Merge(List<T> l, List<T> r)
    {
        List<T> merged = new List<T>();
        int leftIndex = 0, rightIndex = 0;

        while (leftIndex < l.Count && rightIndex < r.Count)
        {
            if (l[leftIndex].CompareTo(r[rightIndex]) <= 0)
            {
                merged.Add(l[leftIndex]);
                leftIndex++;
            }
            else
            {
                merged.Add(r[rightIndex]);
                rightIndex++;
            }
        }

        while (leftIndex < l.Count)
        {
            merged.Add(l[leftIndex]);
            leftIndex++;
        }

        while (rightIndex < r.Count)
        {
            merged.Add(r[rightIndex]);
            rightIndex++;
        }

        return merged;
    }


    }
}

