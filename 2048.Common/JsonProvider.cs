﻿using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using _2048.Common.Models;

namespace _2048.Common
{
    public class JsonProvider
    {
        private string path { get; }

        public JsonProvider(string name)
        {
            path = Directory.GetCurrentDirectory() + @"\" + name + ".json";
        }

        public void Write<T>(T TObject)
        {
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            var json = JsonSerializer.Serialize(TObject, options);
            File.WriteAllText(path, json);
        }

        public T Read<T>() where T : new()
        {
            T TObject = new T();
            try
            {
                var json = File.ReadAllText(path);
                TObject = JsonSerializer.Deserialize<T>(json);
            }
            catch (FileNotFoundException)
            {
            }
            return TObject;
        }
    }
}