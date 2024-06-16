using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTask{
    public class MergeSortAlgorithm{
        static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; i++)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[middle + 1 + j];

        int iL = 0, iR = 0;
        int k = left;

        while (iL < n1 && iR < n2)
        {
            if (L[iL] <= R[iR])
            {
                arr[k] = L[iL];
                iL++;
            }
            else
            {
                arr[k] = R[iR];
                iR++;
            }
            k++;
        }

        while (iL < n1)
        {
            arr[k] = L[iL];
            iL++;
            k++;
        }

        while (iR < n2)
        {
            arr[k] = R[iR];
            iR++;
            k++;
        }
    }
    static void MergeSort(string[] arr, int left, int right)
{
    if (left < right)
    {
        int middle = (left + right) / 2;

        MergeSort(arr, left, middle);
        MergeSort(arr, middle + 1, right);

        Merge(arr, left, middle, right);
    }
}

static void Merge(string[] arr, int left, int middle, int right)
{
    int n1 = middle - left + 1;
    int n2 = right - middle;

    string[] L = new string[n1];
    string[] R = new string[n2];

    for (int i = 0; i < n1; i++)
        L[i] = arr[left + i];
    for (int j = 0; j < n2; j++)
        R[j] = arr[middle + 1 + j];

    int iL = 0, iR = 0;
    int k = left;

    while (iL < n1 && iR < n2)
    {
        if (L[iL].CompareTo(R[iR]) <= 0)
        {
            arr[k] = L[iL];
            iL++;
        }
        else
        {
            arr[k] = R[iR];
            iR++;
        }
        k++;
    }

    while (iL < n1)
    {
        arr[k] = L[iL];
        iL++;
        k++;
    }

    while (iR < n2)
    {
        arr[k] = R[iR];
        iR++;
        k++;
    }
}

    }
}