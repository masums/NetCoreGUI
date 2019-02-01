using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Utility
{
    public static class ClassUtil
    {
        public static T CreateInstance<T>() where T : class, new()
        {
            return new T();
        }

        public static bool IsDefault<T>(this T source) where T : struct
        {
            return source.Equals(default(T));
        }
    }
}
