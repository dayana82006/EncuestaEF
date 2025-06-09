using Application.Interface;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ApiP.Controllers;

public class CategoriesCatalogController : BaseApiController
{
    private readonly IUnitOfWork _unitOfWork;
    public CategoriesCatalogController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<IEnumerable<CategoriesCatalog>>> Get()
    {

        var categories = await _unitOfWork.CategoriesCatalog.GetByIdAsync(id);
        if (categories == null || !categories.Any())
        {
            return NotFound("No categories found.");
        }
        return Ok(categories);
    }
}
