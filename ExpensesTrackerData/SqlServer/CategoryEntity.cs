using ExpensesTrackerCore;


namespace ExpensesTrackerData.SqlServer
{
    public class CategoryEntity : IDataHelper<Category>
    {
        //  Variables:
        private AppDbContext _appDbContext;
        private Category table;

        //  Consturctors:
        public CategoryEntity()
        {
            _appDbContext = new AppDbContext();
        }

        #region Methods
        public int Add(Category table)
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

        public async Task<int> AddAsync(Category table)
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

        public int Edit(Category table)
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

        public async Task<int> EditAsync(Category table)
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

        public Category Find(int Id)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Categories.Where(x => x.Id == Id).First();
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

        public async Task<Category> FindAsync(int Id)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Categories.Where(x => x.Id == Id).First());
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

        public List<Category> GetAllData()
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Categories.ToList();
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

        public async Task<List<Category>> GetAllDataAsync()
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Categories.ToList());
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

        public List<Category> Search(string SearchIteam)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Categories.Where(x => x.Id.ToString() == SearchIteam ||
                    x.Name.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Balance.ToString().Contains(SearchIteam) ||
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

        public async Task<List<Category>> SearchAsync(string SearchIteam)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Categories.Where(x => x.Id.ToString() == SearchIteam ||
                    x.Name.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Balance.ToString().Contains(SearchIteam) ||
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
