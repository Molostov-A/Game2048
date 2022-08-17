using System.Collections.Generic;
using _2048.Common.Models;

namespace _2048.Common
{
    public class RecordsStorage
    {
        private static JsonProvider storage;
        private List<Result> Results { get; }

        public RecordsStorage()
        {
            storage = new JsonProvider("record");
            Results = storage.Read<List<Result>>();
        }

        public List<Result> GetRecords()
        {
            return Results;
        }

        public int GetLastRecords(int mapSize)
        {
            var records = GetRecords();
            Result lastRecords = new Result()
            {
                Score = 0,
                MapSize = mapSize
            };
            foreach (var record in records)
            {
                if (lastRecords.Score < record.Score && lastRecords.MapSize == record.MapSize)
                {
                    lastRecords = record;
                }
            }
            return lastRecords.Score;
        }

        public void Add(Result result)
        {
            Results.Add(result);
            Save();
        }

        private void Save()
        {
            storage.Write(Results);
        }
    }
}
