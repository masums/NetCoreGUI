using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreGui.Utility
{
    public class ClassUtil
    {
        public static T CreateInstance<T>() where T : class, new()
        {
            return new T();
        }
    }
}
