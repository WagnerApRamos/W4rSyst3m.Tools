#region Using

using Newtonsoft.Json;
using System;

#endregion

namespace W4rSyst3m.Tools.Utilities
{
    public static class ObjectExtensions
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsNotNull(this object obj)
        {
            return !obj.IsNull();
        }

        public static T GetClone<T>(this T obj) 
            where T : class
        {
            if (obj.IsNull()) throw new ArgumentNullException("obj");

            return JsonConvert.DeserializeObject<T>(
                JsonConvert.SerializeObject(obj));
        }
    }
}
