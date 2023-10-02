using ExpensesTrackerCore;


namespace ExpensesTrackerData.SqlServer
{
    public class CustomerEntity : IDataHelper<Customer>
    {
        //  Variables:
        private AppDbContext _appDbContext;
        private Customer table;

        //  Consturctors:
        public CustomerEntity()
        {
            _appDbContext = new AppDbContext();
        }

        #region Methods
        public int Add(Customer table)
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

        public async Task<int> AddAsync(Customer table)
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

        public int Edit(Customer table)
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

        public async Task<int> EditAsync(Customer table)
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

        public Customer Find(int Id)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Customers.Where(x => x.Id == Id).First();
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

        public async Task<Customer> FindAsync(int Id)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Customers.Where(x => x.Id == Id).First());
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

        public List<Customer> GetAllData()
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Customers.ToList();
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

        public async Task<List<Customer>> GetAllDataAsync()
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Customers.ToList());
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

        public List<Customer> Search(string SearchIteam)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Customers.Where(x => x.Id.ToString() == SearchIteam ||
                    x.Name.Contains(SearchIteam) ||
                    x.PhoneNumber.Contains(SearchIteam) ||
                    x.Address.Contains(SearchIteam) ||
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

        public async Task<List<Customer>> SearchAsync(string SearchIteam)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Customers.Where(x => x.Id.ToString() == SearchIteam ||
                    x.Name.Contains(SearchIteam) ||
                    x.PhoneNumber.Contains(SearchIteam) ||
                    x.Address.Contains(SearchIteam) ||
                    x.Email.Contains(SearchIteam) ||
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
