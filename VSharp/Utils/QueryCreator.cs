using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace VSharp.Utils
{
    public static class QueryCreator
    {
        public static string MakeQuery<T>(T obj)
        {
            var properties = obj.GetType().GetProperties().Where(x => x.GetCustomAttribute<JsonPropertyAttribute>() != null && x.GetValue(obj) != null);
            var queryObjects = new List<string>();

            foreach (var propertyInfo in properties)
            {

                var val = JsonConvert.SerializeObject(propertyInfo.GetValue(obj));
                if (val.StartsWith("\"")) val = val.Substring(1, val.Length - 2);
                queryObjects.Add(propertyInfo.GetCustomAttribute<JsonPropertyAttribute>().PropertyName + "=" + val);
            }

            return String.Join("&", queryObjects.ToArray());
        }
    }
}