using ExpensesTrackerCore;
using ExpensesTrackerData.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Code
{
    public static class DependencyInjection
    {
        public static void AddDependencyValues()
        {
            ConfigrationObjectManager.Register("Category", new CategoryEntity());
            ConfigrationObjectManager.Register("SystemRecord", new SystemRecordEntity());
            ConfigrationObjectManager.Register("Customer", new CustomerEntity());
            ConfigrationObjectManager.Register("Supplier", new SupplierEntity());
            ConfigrationObjectManager.Register("Project", new ProjectEntity());
            ConfigrationObjectManager.Register("Outcome", new OutcomeEntity());
            ConfigrationObjectManager.Register("Income", new IncomeEntity());
            ConfigrationObjectManager.Register("User", new UserEntity());
            ConfigrationObjectManager.Register("UserPermission", new UserPermissionEntity());


        }
    }
}
