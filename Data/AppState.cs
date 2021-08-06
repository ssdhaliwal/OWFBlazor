using System.Collections.Generic;

namespace OWFBlazorDemo.Services
{
    public class AppState
    {
        Dictionary<string, object> ObjectRepo = new Dictionary<string, object>();
        
        public object get(string key, object defaultValue = null) {
            object value = null;
            if (ObjectRepo.ContainsKey(key)) {
                value = ObjectRepo[key];
            }

            return ((value != null) ? value : defaultValue);
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