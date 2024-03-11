﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Pract4WPF
{
    public class SerDeser
    {
        public static void Serialization<T>(List<T> note)
        {
            string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Notes.json");
            if (File.Exists(path))
            {
                string json = JsonConvert.SerializeObject(note);
                File.WriteAllText(path, json);
            }
            else
            {
                File.Create(path).Close();
                var json = JsonConvert.SerializeObject(note);
                File.WriteAllText(path, json);
            }
        }
        public static List<T> Deserialization<T>()
        {
            string path = (Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Notes.json");
            if (File.Exists(path))
            {
                string txt = File.ReadAllText(path);
                List<T> values = JsonConvert.DeserializeObject<List<T>>(txt);
                if (values != null)
                {
                    return values;
                }
                else { return new List<T>(); }
            }
            else
            {
                return new List<T>();
            }
        }
    }
}
