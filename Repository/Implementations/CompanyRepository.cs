using Contracts;
using Entities;
using Repository;

public class CompanyRepository : RepositoryBase<Company>, ICompanyRepository
{
    public CompanyRepository(RepositoryContext repositoryContext)
    : base(repositoryContext)
    {
    }
}