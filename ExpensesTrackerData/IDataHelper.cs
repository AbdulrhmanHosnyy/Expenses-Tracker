using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTrackerData
{
    public interface IDataHelper<Table>
    {
        //  Read
        /// <summary>Gets all data.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        List<Table> GetAllData();
        /// <summary>Searches the specified search iteam.</summary>
        /// <param name="SearchIteam">The search iteam.</param>
        /// <returns>Searched Data</returns>
        List<Table> Search(string SearchIteam);
        /// <summary>Finds the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Row Table When Id matches any Id</returns>
        Table Find(int Id);

        //  Write
        /// <summary>Adds the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 in success, and 0 in failure</returns>
        int Add(Table table);
        /// <summary>Edits the specified table.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 in sucess, and 0 in failure</returns>
        int Edit(Table table);
        /// <summary>Deletes the specified identifier.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>1 in success, and 0 in failure</returns>
        int Delete(int Id);

        //  Read Async
        /// <summary>Gets all data asynchronous.</summary>
        /// <returns>All data of the table</returns>
        Task<List<Table>> GetAllDataAsync();
        /// <summary>Searches the asynchronous.</summary>
        /// <param name="SearchIteam">The search iteam.</param>
        /// <returns>Searched Data</returns>
        Task<List<Table>> SearchAsync(string SearchIteam);
        /// <summary>Finds the asynchronous.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>Row Table When Id matches any Id</returns>
        Task<Table> FindAsync(int Id);

        //  Write Async
        /// <summary>Adds the asynchronous.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 in success, and 0 in failure</returns>
        Task<int> AddAsync(Table table);
        /// <summary>Edits the asynchronous.</summary>
        /// <param name="table">The table.</param>
        /// <returns>1 in success, and 0 in failure</returns>
        Task<int> EditAsync(Table table);
        /// <summary>Deletes the asynchronous.</summary>
        /// <param name="Id">The identifier.</param>
        /// <returns>1 in success, and 0 in failure</returns>
        Task<int> DeleteAsync(int Id);
    }
}
