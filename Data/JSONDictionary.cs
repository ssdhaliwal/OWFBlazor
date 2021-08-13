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
        public static IDictionary<string, object> JSONAsDictionary(string payload) {
            IDictionary<string, object> result = JsonConvert.DeserializeObject<IDictionary<string, object>>(
                payload, new JsonConverter[] {new JSONDictionaryConverter()});
            
            //System.Console.WriteLine(payload);
            //JSONDisplay(result);

            return result;
        }

        public static void JSONDisplay(IDictionary<string, object> obj, int level = 0)
        {
            int processJArray(KeyValuePair<string, object> kvp, int level) {
                System.Console.WriteLine("".PadLeft((level * 4), ' ') + kvp.Key);

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

                        JSONDisplay((System.Collections.Generic.IDictionary<string, object>)lDict, ++level);
                        level--;
                    }
                }

                return level;
            };

            foreach (KeyValuePair<string, object> kvp in (IDictionary<string, object>)obj)
            {
                var vType = (kvp.Value != null) ? kvp.Value.GetType().ToString() : "null";
                if (vType == "Newtonsoft.Json.Linq.JArray")
                {
                    level = processJArray(kvp, level);
                }
                else if (vType == "System.Collections.Generic.Dictionary`2[System.String,System.Object]")
                {
                    System.Console.WriteLine("".PadLeft((level * 4), ' ') + kvp.Key);
                    JSONDisplay((System.Collections.Generic.IDictionary<string, object>)kvp.Value, ++level);
                    level--;
                }
                else
                {
                    System.Console.WriteLine("".PadLeft((level * 4), ' ') + (kvp.Key + "=" + kvp.Value));
                }
            }
        }
        public static List<string> JSONAsList(IDictionary<string, object> obj, 
            string path = "", List<string> properties = null)
        {
            if (properties == null) {
                properties = new List<string>();
            }

            void processJArray(KeyValuePair<string, object> kvp) {
                var list = from item in (Newtonsoft.Json.Linq.JArray)kvp.Value select item;
                int index = 0;
                foreach (var lObj in list)
                {
                    if (lObj.GetType().ToString() == "Newtonsoft.Json.Linq.JValue")
                    {
                        properties.Add(((path == "") ? "" : (path + ".")) + kvp.Key + "." + index++ + "." + lObj.ToString());
                    }
                    else if (lObj.GetType().ToString() == "Newtonsoft.Json.Linq.JObject")
                    {
                        var lDict = JsonConvert.DeserializeObject<IDictionary<string, object>>(
                            lObj.ToString(), new JsonConverter[] { new JSONDictionaryConverter() });

                        JSONAsList((System.Collections.Generic.IDictionary<string, object>)lDict, 
                            ((path == "") ? "" : (path + ".")) + kvp.Key + "." + index++, properties);
                    }
                }
            };

            foreach (KeyValuePair<string, object> kvp in obj)
            {
                var vType = (kvp.Value != null) ? kvp.Value.GetType().ToString() : "null";
                if (vType == "Newtonsoft.Json.Linq.JArray")
                {
                    processJArray(kvp);
                }
                else if (vType == "System.Collections.Generic.Dictionary`2[System.String,System.Object]")
                {
                    JSONAsList((System.Collections.Generic.IDictionary<string, object>)kvp.Value, 
                        ((path == "") ? "" : (path + ".")) + kvp.Key, properties);
                }
                else
                {
                    properties.Add(((path == "") ? "" : (path + ".")) + kvp.Key + "=" + kvp.Value);
                }
            }

            return properties;
        }

        public static string JSONAsHTMLString(string payload)
        {
            IDictionary<string, object> jsonObject = JSONAsDictionary(payload);
            List<string> properties = JSONAsList(jsonObject);
            
            return string.Join( "<br/>", properties );
        }
    }
}
