using ExpensesTrackerCore;


namespace ExpensesTrackerData.SqlServer
{
    public class IncomeEntity : IDataHelper<Income>
    {
        //  Variables:
        private AppDbContext _appDbContext;
        private Income table;

        //  Consturctors:
        public IncomeEntity()
        {
            _appDbContext = new AppDbContext();
        }

        #region Methods
        public int Add(Income table)
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

        public async Task<int> AddAsync(Income table)
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

        public int Edit(Income table)
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

        public async Task<int> EditAsync(Income table)
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

        public Income Find(int Id)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Incomes.Where(x => x.Id == Id).First();
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

        public async Task<Income> FindAsync(int Id)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Incomes.Where(x => x.Id == Id).First());
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

        public List<Income> GetAllData()
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Incomes.ToList();
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

        public async Task<List<Income>> GetAllDataAsync()
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Incomes.ToList());
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

        public List<Income> Search(string SearchIteam)
        {
            try
            {
                if (_appDbContext.Database.CanConnect())
                {
                    return _appDbContext.Incomes.Where(x => x.Id.ToString() == SearchIteam ||
                    x.CategoryName.Contains(SearchIteam) ||
                    x.SupplierName.Contains(SearchIteam) ||
                    x.ReceiptNumber.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Amount.ToString().Contains(SearchIteam) ||
                    x.IncomeDate.Date.ToString().Contains(SearchIteam)).ToList();
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

        public async Task<List<Income>> SearchAsync(string SearchIteam)
        {
            try
            {
                if (await _appDbContext.Database.CanConnectAsync())
                {
                    return await Task.Run(() => _appDbContext.Incomes.Where(x => x.Id.ToString() == SearchIteam ||
                    x.CategoryName.Contains(SearchIteam) ||
                    x.SupplierName.Contains(SearchIteam) ||
                    x.ReceiptNumber.Contains(SearchIteam) ||
                    x.Details.Contains(SearchIteam) ||
                    x.Amount.ToString().Contains(SearchIteam) ||
                    x.IncomeDate.Date.ToString().Contains(SearchIteam)).ToList());
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
