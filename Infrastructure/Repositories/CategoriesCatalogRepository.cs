using System.Linq.Expressions;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class CategoriesCatalogRepository : IGenericRepository<CategoriesCatalog>, ICategoriesCatalogRepository
{
    public CategoriesCatalogRepository(ProjectDbContext context)
    {
        Context = context;
    }

    public ProjectDbContext Context { get; }


    public Task<CategoriesCatalog> Add(CategoriesCatalog entity)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Exists(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CategoriesCatalog> Find(Expression<Func<CategoriesCatalog, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CategoriesCatalog>> Find(Func<CategoriesCatalog, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CategoriesCatalog>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CategoriesCatalog?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CategoriesCatalog> Update(CategoriesCatalog entity)
    {
        throw new NotImplementedException();
    }

}
