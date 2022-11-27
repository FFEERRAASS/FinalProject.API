using FinalProject.Core.Data;
using FinalProject.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FinalProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;
        public CategoryController(ICategoryService _categoryService)
        {
            this.categoryService = _categoryService;
        }

        [HttpGet("GetAllCategory")]
        public List<Category> GetAllCategory()
        {
            return categoryService.GetAllCategory();
        }

        [HttpPost("CREATECategory")]
        public void CREATECategory(Category document)
        {
            categoryService.CREATECategory(document);
        }

        [HttpPut("UPDATECategory/{id}")]
        public void UPDATECategory(int id, Category document)
        {
            categoryService.UPDATECategory(id, document);
        }

        [HttpGet("GetCategoryById/{id}")]
        public Category GetCategoryById(int id)
        {
            return categoryService.GetCategoryById(id);
        }
        [HttpDelete("DeleteCategory/{id}")]
        public void DeleteCategory(int id)
        {
            categoryService.DeleteCategory(id);
        }

    }
}
