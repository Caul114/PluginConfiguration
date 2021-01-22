﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginConfiguration
{
    public class Json
    {
        private List<Data> _data = new List<Data>();

        // Metodo per CREARE il file Json
        public List<Data> WriteJson(int id, string name, string path)
        {
            _data.Add(new Data()
            {
                Id = id,
                Name = name,
                Path = path
            });
            string jsonString = JsonConvert.SerializeObject(_data.ToArray());
            //write string to file
            File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Bold Software\DataCell\ConfigPath.json", jsonString);

            return _data;
        }

        // Metodo per MODIFICARE o AGGIUNGERE un oggetto del file .json
        public void UpdateJson(int id, int index, string name, string path)
        {
            string jsonText = File.ReadAllText(ModelessForm.thisModForm.PathFileTxt);
            IList<Data> traduction = JsonConvert.DeserializeObject<IList<Data>>(jsonText);
            dynamic jsonObj = JsonConvert.DeserializeObject(jsonText);
            // Se l'oggetto .json esiste già...
            if (traduction.Any(x => x.Id == id))
            {
                jsonObj[index]["Path"] = path;
                string output = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(ModelessForm.thisModForm.PathFileTxt, output);
            }
            else // ... altrimenti lo crea
            {
                traduction.Add(new Data { Id = id, Name = name, Path = path });
                jsonText = JsonConvert.SerializeObject(traduction);
                File.WriteAllText(ModelessForm.thisModForm.PathFileTxt, jsonText);
            }
        }
    }
}
