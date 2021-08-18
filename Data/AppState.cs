using System.Collections.Generic;

namespace OWFBlazorDemo.Services
{
    public class AppState
    {
        Dictionary<string, object> ObjectDictionary = new Dictionary<string, object>();

        public void reset()
        {
            ObjectDictionary.Clear();
        }

        public object get(string key, object defaultValue = null)
        {
            object value = null;
            if (ObjectDictionary.ContainsKey(key))
            {
                value = ObjectDictionary[key];
            }

            return ((value != null) ? value : defaultValue);
        }

        public void set(string key, object value)
        {
            if (ObjectDictionary.ContainsKey(key))
            {
                ObjectDictionary[key] = value;
            }
            else
            {
                ObjectDictionary.Add(key, value);
            }
        }

        public void remove(string key)
        {
            if (ObjectDictionary.ContainsKey(key))
            {
                ObjectDictionary.Remove(key);
            }
        }

        // managing child-dictionaries
        private List<string> getChildList(string key)
        {
            List<string> result = null;
            if (ObjectDictionary.ContainsKey(key))
            {
                object o = ObjectDictionary[key];
                if (o.GetType().ToString() == "System.Collections.Generic.List<string>")
                {
                    result = (List<string>)o;
                }
            }
            else
            {
                result = new List<string>();
                set(key, result);
            }

            return result;
        }

        public void add(string key, string value)
        {
            List<string> childList = getChildList(key);

            // add the new value if it does not exists
            if (childList != null)
            {
                if (!childList.Contains(value))
                {
                    childList.Add(value);
                }
            }
        }
        public void add(string key, List<string> values)
        {
            List<string> childList = getChildList(key);

            // add the new value if it does not exists
            if (childList != null)
            {
                foreach (string value in values)
                {
                    if (!childList.Contains(value))
                    {
                        childList.Add(value);
                    }
                }
            }
        }

        public void subtract(string key, string match, bool partial = false)
        {
            List<string> childList = getChildList(key);

            // add the new value if it does not exists
            if (childList != null)
            {
                var index = -1;
                foreach (string value in childList)
                {
                    if (partial && (value.StartsWith(match)))
                    {
                        index = childList.IndexOf(value);
                        childList.RemoveAt(index);
                    }
                    else if (!partial && (value == match))
                    {
                        childList.Remove(value);
                        break;
                    }
                }
            }
        }

        public void subtract(string key, List<string> values)
        {
            List<string> childList = getChildList(key);

            // add the new value if it does not exists
            if (childList != null)
            {
                foreach (string value in values)
                {
                    if (childList.Contains(value))
                    {
                        childList.Remove(value);
                    }
                }
            }
        }

        public bool check(string key, string match, bool partial = false)
        {
            bool result = false;
            List<string> childList = getChildList(key);

            // add the new value if it does not exists
            if (childList != null)
            {
                foreach (string value in childList)
                {
                    if (partial && (value.StartsWith(match)))
                    {
                        result = true;
                        break;
                    }
                    else if (!partial && (value == match))
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        public bool check(string key, List<string> values, bool matchAll = false)
        {
            bool result = false;
            List<string> childList = getChildList(key);

            // add the new value if it does not exists
            if (childList != null)
            {
                foreach (string value in values)
                {
                    if (childList.Contains(value))
                    {
                        result = true;
                        if (!matchAll)
                        {
                            break;
                        }
                    }
                    else if (matchAll)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }

        public List<string> list(string key, string match, bool partial = false)
        {
            List<string> result = new List<string>();
            List<string> childList = getChildList(key);

            // add the new value if it does not exists
            if (childList != null)
            {
                foreach (string value in childList)
                {
                    if (partial && (value.StartsWith(match)))
                    {
                        result.Add(value);
                    }
                    else if (!partial && (value == match))
                    {
                        result.Add(value);
                        break;
                    }
                }
            }

            return result;
        }

        public List<string> list(string key, List<string> match, bool matched = true)
        {
            List<string> result = new List<string>();
            List<string> childList = getChildList(key);

            // add the new value if it does not exists
            if (childList != null)
            {
                foreach (string value in childList)
                {
                    if (match.IndexOf(value) >= 0)
                    {
                        if (matched)
                        {
                            result.Add(value);
                        }
                    }
                    else if (!matched)
                    {
                        result.Add(value);
                    }
                }
            }

            return result;
        }
    }
}