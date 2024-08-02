using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__As_01
{


    //1-Create a generic class named Range<T> where T represents the type of values
    internal class Range<T>where T: IComparable<T>
    {


        //2-Implement a constructor that takes the minimum and maximum values to define the range.
        public Range(int _min, int _max)
        {
            min= _min; max = _max;
        }
        public int min {  get; set; }
        public int max { get; set; }


        //3-Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
        public bool IsInRange(T value)
        {
            for(int i = min; i <= max; i++)
            {
               if(i.Equals(value))
                {
                    return true;
                }
            }
            return false;
        }


        //4-Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
        public int Length()
        {
            int rangeLength = max- min;
            return rangeLength;
        }

    }
}
