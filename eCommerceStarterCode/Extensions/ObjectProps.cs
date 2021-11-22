using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Extensions
{
    public static class ObjectProps
    {
        public static object GetProperty<T>(this T obj, string name) where T : class
        {
            Type t = typeof(T);
            return t.GetProperty(name).GetValue(obj, null);
        }
    }
}
