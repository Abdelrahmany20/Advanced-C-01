using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_C_01.Classes
{
    internal class Range<T> where T : IComparable<T>
    {
        //Q02
        public T Min { get; set; }
        public T Max { get; set; }

        public Range(T min, T max)

        {
            Min = min;
            Max = max;

        }
        //Q03
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) > 0 && value.CompareTo(Max) < 0;
        }
        //Q04
        public T  Length()
        {
          /*dynamic*/  T   minValue = Min;
          /*dynamic */ T   maxValue = Max;

            return maxValue - minValue;
        }

        
    }
}
