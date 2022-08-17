namespace _2048.Common
{
    public class ScaleStorage
    {
        private static JsonProvider storage = new("scale");
        private int Scale { get; set; }

        public ScaleStorage()
        {
            Scale = storage.Read<int>();
            if (Scale == 0) Reset();
        }

        public int GetScale()
        {
            return Scale;
        }

        public void Reset()
        {
            Scale = 5;
            Save();
        }

        public void SetScale(int scale)
        {
            Scale = scale;
            Save();
        }

        private void Save()
        {
            storage.Write(Scale);
        }
    }
}
