using ExpensesTrackerCore;


namespace ExpensesTrackerData.SqlServer
{
    public class SystemRecordEntity : IDataHelper<SystemRecord>
    {
        //  Variables:
        private AppDbContext _appDbContext;
        private SystemRecord table;

        //  Consturctors:
        public SystemRecordEntity()
        {
            _appDbContext = new AppDbContext();
        }

        #region Methods
        public int Add(SystemRecord table)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    _appDbContext.Add(table);
                    _appDbContext.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public async Task<int> AddAsync(SystemRecord table)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    await _appDbContext.AddAsync(table);
                    await _appDbContext.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int Delete(int Id)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    table = Find(Id);
                    _appDbContext.Remove(table);
                    _appDbContext.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public async Task<int> DeleteAsync(int Id)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    table = await FindAsync(Id);
                    await Task.Run(() => _appDbContext.Remove(table));
                    await _appDbContext.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public int Edit(SystemRecord table)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    _appDbContext = new AppDbContext();
                    _appDbContext.Update(table);
                    _appDbContext.SaveChanges();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public async Task<int> EditAsync(SystemRecord table)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    _appDbContext = new AppDbContext();
                    await Task.Run(() => _appDbContext.Update(table));
                    await _appDbContext.SaveChangesAsync();
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception)
            {

                return 0;
            }
        }

        public SystemRecord Find(int Id)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.SystemRecords.Where(x => x.Id == Id).First();
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<SystemRecord> FindAsync(int Id)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.SystemRecords.Where(x => x.Id == Id).First());
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<SystemRecord> GetAllData()
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.SystemRecords.ToList();
                }
                else
                {
                    return null;
                }

            }
            catch 
            {
                return null;
            }
        }

        public async Task<List<SystemRecord>> GetAllDataAsync()
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.SystemRecords.ToList());
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<SystemRecord> Search(string SearchIteam)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.SystemRecords.Where(x => x.Id.ToString() == SearchIteam ||
                    x.Username.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Title.ToString().Contains(SearchIteam) ||
                    x.AddedDate.Date.ToString().Contains(SearchIteam)).ToList();
                }
                else
                {
                    return null;
                }

            }
            catch 
            {
                return null;
            }
        }

        public async Task<List<SystemRecord>> SearchAsync(string SearchIteam)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.SystemRecords.Where(x => x.Id.ToString() == SearchIteam ||
                    x.Username.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Title.ToString().Contains(SearchIteam) ||
                    x.AddedDate.Date.ToString().Contains(SearchIteam)).ToList());
                }
                else
                {
                    return null;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
