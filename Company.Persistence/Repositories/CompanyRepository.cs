namespace Company.Persistence.Repositories
{
    public class CompanyRepository : GenericRepository<CompanyModel>, ICompanyRepository
    {
        private readonly CompanyDbContext _dbContext; 
        public CompanyRepository(CompanyDbContext dbContext) : base (dbContext)
        {
            _dbContext = dbContext;   
        }

    }
}
