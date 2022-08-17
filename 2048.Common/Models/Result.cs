using System;

namespace _2048.Common.Models
{
    public class Result
    {
        public string Name { get; set; }
        public int MapSize { get; set; }
        public int Score { get; set; }
        public DateTime Data { get; set; }

        public Result()
        {

        }
        public Result(string name, int mapSize, int score)
        {
            Data = DateTime.Now;
            Name = name;
            MapSize = mapSize;
            Score = score;
        }
    }

}
