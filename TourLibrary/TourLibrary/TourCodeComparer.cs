using System.Collections.Generic;

namespace TourLibrary
{
    public class TourCodeComparer : IComparer<Tour>
    {
        public int Compare(Tour x, Tour y)
        {
            return x.Code.CompareTo(y.Code);
        }
    }
}