using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExpensesTrackerData.SqlServer
{
    public class BackUpRestoreHelper
    {
        private AppDbContext db;
        public BackUpRestoreHelper()
        {
            db = new AppDbContext();
        }

        public string BackUp(string Path)
        {
            try
            {
                db = new AppDbContext();
                db.Database.SetCommandTimeout(0);
                string dbName = db.Database.GetDbConnection().Database;
                string fileName = Path + dbName + DateTime.Now.ToString("yyyyMMddHHmm") + ".bak";
                string sqlQuery = "BACKUP DATABASE [" + dbName + "] TO  DISK = " +
                    "N'" + fileName + "' WITH NOFORMAT, NOINIT,  NAME = " +
                    "N'" + dbName + "', SKIP, NOREWIND, NOUNLOAD,  " +
                    "STATS = 10\r\n";
                db.Database.ExecuteSqlRaw(sqlQuery);
                return "1";
            }
            catch(Exception ex) 
            {
                return ex.Message;
            }
        }
        public string Restore(string FileName)
        {
            try
            {
                db = new AppDbContext();
                db.Database.SetCommandTimeout(0);
                string dbName = db.Database.GetDbConnection().Database;
                string AlterDbSetSingle = "ALTER DATABASE [" + dbName + "] SET SINGLE_USER " +
                    "WITH ROLLBACK IMMEDIATE;";
                string AlterDbSetDouble = ";ALTER DATABASE [" + dbName + "] SET MULTI_USER";
                string sqlQuery = AlterDbSetSingle + "USE [master];RESTORE DATABASE [" + dbName + "] " +
                    "FROM  DISK = N'" + FileName + "' WITH  FILE = 1,  " +
                    "NOUNLOAD,  REPLACE,  STATS = 5\r\n" + AlterDbSetDouble;
                db.Database.ExecuteSqlRaw(sqlQuery);
                return "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
    
}

