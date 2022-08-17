namespace _2048.Common
{
    public class MapSizeStorage
    {
        private static JsonProvider storage = new("mapSize");
        private int MapSize { get; set; }

        public MapSizeStorage()
        {
            MapSize = storage.Read<int>();
            if (MapSize == 0) Reset();
        }

        public int GetSize()
        {
            return MapSize;
        }

        public void Reset()
        {
            MapSize = 4;
            Save();
        }

        public void SetSize(int scale)
        {
            MapSize = scale;
            Save();
        }

        private void Save()
        {
            storage.Write(MapSize);
        }
    }
}
