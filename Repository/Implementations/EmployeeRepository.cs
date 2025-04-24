using Contracts;
using Entities;
using Repository;

public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository 
{
    public EmployeeRepository(RepositoryContext repositoryContext)
    : base(repositoryContext)
    {
    }
}