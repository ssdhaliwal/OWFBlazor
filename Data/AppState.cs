using System.Collections.Generic;

namespace OWFBlazorDemo.Services
{
    public class AppState
    {
        public int Age { get; set; }
        Dictionary<string, object> ObjectRepo = new Dictionary<string, object>();

        public object get(string key) {
            return ObjectRepo[key];
        }

        public void set(string key, object value) {
            if (ObjectRepo.ContainsKey(key)) {
                ObjectRepo[key] = value;
            } else {
                ObjectRepo.Add(key, value);
            }
        }
    }
}