using System.Collections;
using System.Collections.Generic;

namespace TourLibrary
{
    public class TravelAgency : IEnumerable<Tour>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        private List<Tour> tours;

        public int Count => tours.Count;

        public TravelAgency(
            string name,
            string address,
            IEnumerable<Tour> collection)
        {
            Name = name;
            Address = address;

            tours = new List<Tour>();

            foreach (var tour in collection)
            {
                if (!tours.Contains(tour))
                    tours.Add(tour);
            }
        }

        public IEnumerator<Tour> GetEnumerator()
        {
            return tours.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
