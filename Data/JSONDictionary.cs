using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace OWFBlazorDemo.Services
{
    public class JSONDictionaryConverter : CustomCreationConverter<IDictionary<string, object>>
    {
        public override IDictionary<string, object> Create(Type objectType)
        {
            return new Dictionary<string, object>();
        }

        public override bool CanConvert(Type objectType)
        {
            // in addition to handling IDictionary<string, object>
            // we want to handle the deserialization of dict value
            // which is of type object
            // - also; if the object is JSON string, we want to reparse it
            return objectType == typeof(object) || base.CanConvert(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject
                || reader.TokenType == JsonToken.Null)
            {
                return base.ReadJson(reader, objectType, existingValue, serializer);
            }

            // if the next token is not an object
            // then fall back on standard deserializer (strings, numbers etc.)
            return serializer.Deserialize(reader);
        }
    }

    public abstract class JSONServices
    {
        public static void DisplayObject(IDictionary<string, object> obj, int level = 0)
        {
            int lLevel = level * 4;
            foreach (KeyValuePair<string, object> kvp in obj)
            {
                var vType = kvp.Value.GetType().ToString();
                if (vType == "Newtonsoft.Json.Linq.JArray")
                {
                    System.Console.WriteLine("".PadLeft(lLevel, ' ') + kvp.Key);
                    var list = from item in (Newtonsoft.Json.Linq.JArray)kvp.Value select item;
                    int index = 0;
                    foreach (var lObj in list)
                    {
                        if (lObj.GetType().ToString() == "Newtonsoft.Json.Linq.JValue")
                        {
                            System.Console.WriteLine("".PadLeft(((level + 1) * 4), ' ') + index++ + ":" + lObj.ToString());
                        }
                        else if (lObj.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                        {
                            System.Console.WriteLine("".PadLeft(((level + 1) * 4), ' ') + index++ + ":");
                            var lDict = JsonConvert.DeserializeObject<IDictionary<string, object>>(
                                lObj.ToString(), new JsonConverter[] { new JSONDictionaryConverter() });

                            DisplayObject((System.Collections.Generic.IDictionary<string, object>)lDict, ++level);
                            level--;
                        }
                    }
                }
                else if (vType == "System.Collections.Generic.Dictionary`2[System.String,System.Object]")
                {
                    System.Console.WriteLine("".PadLeft(lLevel, ' ') + kvp.Key);
                    DisplayObject((System.Collections.Generic.IDictionary<string, object>)kvp.Value, ++level);
                    level--;
                }
                else
                {
                    System.Console.WriteLine("".PadLeft(lLevel, ' ') + (kvp.Key + "=" + kvp.Value));
                }
            }
        }
        public static List<string> PropertiesObject(IDictionary<string, object> obj, 
            string path = "", List<string> properties = null)
        {
            if (properties == null) {
                properties = new List<string>();
            }

            foreach (KeyValuePair<string, object> kvp in obj)
            {
                var vType = kvp.Value.GetType().ToString();
                if (vType == "Newtonsoft.Json.Linq.JArray")
                {
                    var list = from item in (Newtonsoft.Json.Linq.JArray)kvp.Value select item;
                    int index = 0;
                    foreach (var lObj in list)
                    {
                        if (lObj.GetType().ToString() == "Newtonsoft.Json.Linq.JValue")
                        {
                            properties.Add(((path == "") ? "" : (path + ".")) + kvp.Key + "." + index + "." + lObj.ToString());
                        }
                        else if (lObj.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                        {
                            var lDict = JsonConvert.DeserializeObject<IDictionary<string, object>>(
                                lObj.ToString(), new JsonConverter[] { new JSONDictionaryConverter() });

                            PropertiesObject((System.Collections.Generic.IDictionary<string, object>)lDict, 
                                ((path == "") ? "" : (path + ".")) + kvp.Key + "." + index, properties);
                        }
                    }
                }
                else if (vType == "System.Collections.Generic.Dictionary`2[System.String,System.Object]")
                {
                    PropertiesObject((System.Collections.Generic.IDictionary<string, object>)kvp.Value, 
                        ((path == "") ? "" : (path + ".")) + kvp.Key, properties);
                }
                else
                {
                    properties.Add(((path == "") ? "" : (path + ".")) + kvp.Key + "=" + kvp.Value);
                }
            }

            return properties;
        }
    }
}
