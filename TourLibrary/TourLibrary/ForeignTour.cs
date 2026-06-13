using System;

namespace TourLibrary
{
    public class ForeignTour : Tour
    {
        public string Country { get; set; }

        public bool VisaRequired { get; set; }

        public decimal VisaCost { get; set; }

        public ForeignTour(
            string name,
            string code,
            string places,
            TransportType transport,
            TimeSpan duration,
            string country)
            : base(name, code, places, transport, duration)
        {
            Country = country;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();

            string[] info = new string[5];

            info[0] = baseInfo[0];
            info[1] = baseInfo[1];
            info[2] = $"Зарубежный тур";
            info[3] = $"Страна: {Country}";
            info[4] = $"Требуется виза: {VisaRequired}";

            return info;
        }
    }
}