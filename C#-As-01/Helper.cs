using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__As_01
{
    internal class Helper<T> where T:IComparable
    {
   
        #region Q01
        //1.	The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases
        public static void BubbleSort(T[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)//Reduce the size of the array to be sorted in subsequent passes
                    {
                        if (arr[j].CompareTo(arr[j + 1]) == 1)
                        {
                            Helper<T>.Swap(ref arr[j], ref arr[j + 1]);
                        }
                    }
                }
            }
        }
        #endregion


    }
    }
