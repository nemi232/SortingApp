using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTask
{

/*
 * Bubble sort will never be the fastest algorithm since it has to iterate through
 * every element
 */

        public class Bubblesort<T> : ISorts<T>  where T : IComparable<T>
        {
        public List<T> Sort(List<T> data)
            {
                int n = data.Count;
                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1 - i; j++)
                    {
                        if (data[j].CompareTo(data[j + 1]) > 0)
                        {
                            T temp = data[j];
                            data[j] = data[j + 1];
                            data[j + 1] = temp;
                        }
                    }
                }
                return data;
            }


       
        }

    }
