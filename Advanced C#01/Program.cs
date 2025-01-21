using Advanced_C_01.Classes;
using System.ComponentModel;

namespace Advanced_C_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01
            //int[] arr = { 4, 7, 1, 3, 5, 2, 6 };

            //Bubble_sort<int>.bubblesort(arr);
            //foreach (int i in arr)
            //{
            //Console.WriteLine(i);
            //}

            #endregion


            #region Q02

            Range<int> intRange = new Range<int>(1, 10);


            Console.WriteLine($"Min : {intRange.Min} , Max : {intRange.Max}");
            Console.WriteLine(intRange.IsInRange(5));  //true
            Console.WriteLine(intRange.IsInRange(15));  // false





            Range<int> range = new Range<int>(5, 100);
            Console.WriteLine(range.Length()); 
            #endregion

        }
    }
    
}
