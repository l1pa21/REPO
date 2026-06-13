using System;

namespace TourLibrary
{
    public class HikingTour : Tour
    {
        public int DifficultyLevel { get; set; }

        public HikingType HikingType { get; set; }

        public HikingTour(
            string name,
            string code,
            string places,
            TransportType transport,
            TimeSpan duration,
            int difficultyLevel,
            HikingType hikingType)
            : base(name, code, places, transport, duration)
        {
            DifficultyLevel = difficultyLevel;
            HikingType = hikingType;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();

            string[] info = new string[5];

            info[0] = baseInfo[0];
            info[1] = baseInfo[1];
            info[2] = $"Походный тур";
            info[3] = $"Сложность: {DifficultyLevel}";
            info[4] = $"Тип похода: {HikingType}";

            return info;
        }
    }
}