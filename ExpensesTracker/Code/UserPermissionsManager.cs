using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Code
{
    public static class UserPermissionsManager
    {
        private static Dictionary<string, bool> permissionList = 
            new Dictionary<string, bool>();

        public static void Register(string permissionName, bool permissionValue)
        {
            permissionList.Add(permissionName, permissionValue);
        }

        public static bool Get(string permissionName)
        {
            return permissionList[permissionName];
        }

        public static void ClearPermissions()
        {
            permissionList.Clear();
        }
    }
}
