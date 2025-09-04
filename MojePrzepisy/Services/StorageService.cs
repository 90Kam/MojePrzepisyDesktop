using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using MojePrzepisy.Models;


namespace MojePrzepisy.Services
{
    public static class StorageService
    {
        private static readonly string AppDir = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
        "MojePrzepisy");
        private static readonly string FilePath = Path.Combine(AppDir, "przepisy.json");


        private static readonly JsonSerializerOptions JsonOptions = new() { WriteIndented = true };


        public static List<Przepis> Load()
        {
            try
            {
                if (!File.Exists(FilePath)) return new List<Przepis>();
                var json = File.ReadAllText(FilePath);
                return JsonSerializer.Deserialize<List<Przepis>>(json, JsonOptions) ?? new List<Przepis>();
            }
            catch { return new List<Przepis>(); }
        }


        public static void Save(IEnumerable<Przepis> przepisy)
        {
            Directory.CreateDirectory(AppDir);
            var json = JsonSerializer.Serialize(przepisy, JsonOptions);
            File.WriteAllText(FilePath, json);
        }


        public static string GetFilePath() => FilePath;
    }
}