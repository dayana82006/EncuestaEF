namespace Application.Interface;

public interface IUnitOfWork
{
    ICategoriesCatalogRepository CategoriesCatalogs { get; }
    ICategoryOptionsRepository CategoryOptions { get; }
    IChaptersRepository Chapters { get; }
    IOptionsResponsesRepository OptionsResponses { get; }
    ISubQuestionsRepository SubQuestions { get; }
    IQuestionsRepository Questions { get; }
    ISumaryOptionsRepository SumaryOptions { get; }
    ISurveyRepository Surveys { get; }
    IOptionsQuestionsRepository OptionsQuestions { get; }
    object CategoriesCatalogRepository { get; }


    Task<int> SaveAsync();
}
