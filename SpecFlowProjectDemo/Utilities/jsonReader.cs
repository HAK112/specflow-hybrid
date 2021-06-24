using System;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SpecFlowProjectDemo.Utilities 
{
    static class jSonReader
    {
        public static string getValue(string filePath, string key){
            string value=null;
            JObject data = JObject.Parse(File.ReadAllText(filePath));
            value = data.GetValue(key).ToString();
            return value;
        }

       public static Dictionary<string, object> getAllValues(string filePath){
            Dictionary<string, object> json_Dictionary = null;
            try{
            string json = File.ReadAllText(filePath);
            json_Dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);            
            }catch(Exception e){
                Console.WriteLine("Error: "+e.ToString());
                return json_Dictionary;
            }
            return json_Dictionary;
        }
    }
}