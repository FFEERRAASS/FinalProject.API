
using FinalProject.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Core.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAllCategory();
        void CREATECategory(Category category);
        void UPDATECategory(int id, Category category);
        Category GetCategoryById(int id);
        void DeleteCategory(int id);
    }
}
