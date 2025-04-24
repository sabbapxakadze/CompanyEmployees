using Entities;

namespace Service.Contracts.Interfaces;

public interface ICompanyService
{
    IEnumerable<Company> GetAllCompanies(bool trackChanges);
}