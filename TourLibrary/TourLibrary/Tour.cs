using System;

namespace TourLibrary
{
    public class Tour : IComparable<Tour>
    {
        public string Name { get; set; }

        public readonly string Code;

        public string Places { get; set; }

        public TransportType Transport { get; set; }

        public TimeSpan Duration { get; set; }

        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate => StartDate + Duration;

        public string Description { get; set; }

        public Tour(
            string name,
            string code,
            string places,
            TransportType transport,
            TimeSpan duration)
        {
            Name = name;
            Code = code;
            Places = places;
            Transport = transport;
            Duration = duration;
        }

        public virtual string[] GetInfo()
        {
            string[] info = new string[2];

            info[0] = $"{Name} ({Code})";

            info[1] =
                $"Места посещения: {Places}. " +
                $"Транспорт: {Transport}. " +
                $"Продолжительность: {Duration.Days} дней.";

            return info;
        }

        public int CompareTo(Tour other)
        {
            if (other == null)
                return 1;

            if (StartDate != other.StartDate)
                return StartDate.CompareTo(other.StartDate);

            return Name.CompareTo(other.Name);
        }
    }
}