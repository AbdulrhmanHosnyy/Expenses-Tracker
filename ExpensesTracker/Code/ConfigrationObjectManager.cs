using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Code
{
    public static class ConfigrationObjectManager
    {
        private static Dictionary<string, object> objectList = 
            new Dictionary<string, object>();

        public static void Register(string key, object value)
        {
            objectList.Add(key, value);
        }

        public static object Get(string key)
        {
            return objectList[key];
        }
    }
}
