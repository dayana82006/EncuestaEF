using System;
using Application.Interface;
using Infrastructure;
using Infrastructure.Data;
using Infrastructure.Repositories;
namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly ProjectDbContext _context;
    private ISurveyRepository _survey;
    private IOptionsQuestionsRepository _optionsQuestions;
    private IOptionsResponsesRepository _optionsResponses;
    private IQuestionsRepository _questions;
    private ICategoriesCatalogRepository _categoriesCatalogs;
    private ICategoryOptionsRepository _categoryOptions;
    private IChaptersRepository _chapters;
    private ISubQuestionsRepository _subQuestions;
    private ISumaryOptionsRepository _sumaryOptions;
    public UnitOfWork(ProjectDbContext context)
    {
        _context = context;
    }
   
    public ICategoriesCatalogRepository CategoriesCatalogRepository
    {
        get
        {
            if (_categoriesCatalogs == null)
            {
                _categoriesCatalogs = new CategoriesCatalogRepository(_context);
            }
            return _categoriesCatalogs;
        }
    }



    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public Task<int> SaveAsync()
    {
        throw new NotImplementedException();
    }

}
