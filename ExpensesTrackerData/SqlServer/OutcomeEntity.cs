using ExpensesTrackerCore;


namespace ExpensesTrackerData.SqlServer
{
    public class OutcomeEntity : IDataHelper<Outcome>
    {
        //  Variables:
        private AppDbContext _appDbContext;
        private Outcome table;

        //  Consturctors:
        public OutcomeEntity()
        {
            _appDbContext = new AppDbContext();
        }

        #region Methods
        public int Add(Outcome table)
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

        public async Task<int> AddAsync(Outcome table)
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

        public int Edit(Outcome table)
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

        public async Task<int> EditAsync(Outcome table)
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

        public Outcome Find(int Id)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Outcomes.Where(x => x.Id == Id).First();
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

        public async Task<Outcome> FindAsync(int Id)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Outcomes.Where(x => x.Id == Id).First());
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

        public List<Outcome> GetAllData()
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Outcomes.ToList();
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

        public async Task<List<Outcome>> GetAllDataAsync()
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Outcomes.ToList());
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

        public List<Outcome> Search(string SearchIteam)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Outcomes.Where(x => x.Id.ToString() == SearchIteam ||
                    x.CategoryName.Contains(SearchIteam) ||
                    x.SupplierName.Contains(SearchIteam) ||
                    x.ReceiptNumber.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Amount.ToString().Contains(SearchIteam) ||
                    x.OutcomeDate.Date.ToString().Contains(SearchIteam)).ToList();
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

        public async Task<List<Outcome>> SearchAsync(string SearchIteam)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Outcomes.Where(x => x.Id.ToString() == SearchIteam ||
                    x.CategoryName.Contains(SearchIteam) ||
                    x.SupplierName.Contains(SearchIteam) ||
                    x.ReceiptNumber.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Amount.ToString().Contains(SearchIteam) ||
                    x.OutcomeDate.Date.ToString().Contains(SearchIteam)).ToList());
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
