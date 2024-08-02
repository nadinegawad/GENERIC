using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC
{
    internal class Point :IComparable
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X {  get; set; }
        public int Y { get; set; }

        public int CompareTo(object? obj)
        {
          if(obj is Point passedPoint)
            {
                if(this.X == passedPoint.X)
                {
                    return this.Y.CompareTo(passedPoint.Y);
                    
                }
                else
                {
                    return this.X.CompareTo(passedPoint.X);
                }

            }
            return -1;
        }

        public override string ToString()
        {
            return $"{X} :: {Y}";
        }
    }
}
