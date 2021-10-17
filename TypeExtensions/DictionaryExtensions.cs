using System;
using System.Collections.Generic;
using System.Text;

namespace TypeExtensions
{
    public static class DictionaryExtension
    {
        public static Dictionary<T, V> AddOrUpdate<T, V>(this Dictionary<T, V> dict, T key, V value)
        {
            if (dict == null)
            {
                dict = new Dictionary<T, V>();
            }

            if (dict.ContainsKey(key))
                dict[key] = value;
            else
                dict.Add(key, value);

            return dict;
        }
    }

}
