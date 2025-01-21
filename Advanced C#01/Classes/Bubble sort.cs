using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_01.Classes
{
    internal class Bubble_sort<T> where T : IComparable
    {


        public static T swap(ref T x, ref T y)
        {

            T temp = x;
            x = y;
            y = temp;

            return temp;
        }



        public static void bubblesort(T[] arr)
        {
            if (arr is not null)
            {
                for (int i = 0; i < arr.Length; i++)


                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {

                        if (arr[j].CompareTo(arr[j + 1]) == 1)
                        {
                            swap(ref arr[j], ref arr[j + 1]);

                        }

                    }
                }


            }


        }
    }
}
