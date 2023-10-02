using ExpensesTrackerCore;


namespace ExpensesTrackerData.SqlServer
{
    public class ProjectEntity : IDataHelper<Project>
    {
        //  Variables:
        private AppDbContext _appDbContext;
        private Project table;

        //  Consturctors:
        public ProjectEntity()
        {
            _appDbContext = new AppDbContext();
        }

        #region Methods
        public int Add(Project table)
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

        public async Task<int> AddAsync(Project table)
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

        public int Edit(Project table)
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

        public async Task<int> EditAsync(Project table)
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

        public Project Find(int Id)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Projects.Where(x => x.Id == Id).First();
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

        public async Task<Project> FindAsync(int Id)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Projects.Where(x => x.Id == Id).First());
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

        public List<Project> GetAllData()
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Projects.ToList();
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

        public async Task<List<Project>> GetAllDataAsync()
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Projects.ToList());
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

        public List<Project> Search(string SearchIteam)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Projects.Where(x => x.Id.ToString() == SearchIteam ||
                    x.Name.Contains(SearchIteam) ||
                    x.Customer.Contains(SearchIteam) ||
                    x.Company.Contains(SearchIteam) ||
                    x.Address.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Income.ToString().Contains(SearchIteam) ||
                    x.Outcome.ToString().Contains(SearchIteam) ||
                    x.Revenue.ToString().Contains(SearchIteam) ||
                    x.StartDate.Date.ToString().Contains(SearchIteam) ||
                    x.FinishDate.Date.ToString().Contains(SearchIteam) ||
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

        public async Task<List<Project>> SearchAsync(string SearchIteam)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Projects.Where(x => x.Id.ToString() == SearchIteam ||
                    x.Name.Contains(SearchIteam) ||
                    x.Customer.Contains(SearchIteam) ||
                    x.Company.Contains(SearchIteam) ||
                    x.Address.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Income.ToString().Contains(SearchIteam) ||
                    x.Outcome.ToString().Contains(SearchIteam) ||
                    x.Revenue.ToString().Contains(SearchIteam) ||
                    x.StartDate.Date.ToString().Contains(SearchIteam) ||
                    x.FinishDate.Date.ToString().Contains(SearchIteam) ||
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
