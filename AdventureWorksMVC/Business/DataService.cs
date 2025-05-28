namespace AdventureWorks.Business
{
    public interface IDataService
    {
        CycleStoreDbContext GetDbContext();
    }

    public class DataService : IDataService
    {
        private readonly CycleStoreDbContext _context;

        public DataService(CycleStoreDbContext context)
        {
            _context = context;
        }

        public CycleStoreDbContext GetDbContext()
        {
            return _context;
        }
    }
}