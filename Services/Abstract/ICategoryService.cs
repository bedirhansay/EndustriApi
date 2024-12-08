using EndustriApi.DTO;
using EndustriApi.Entity;

namespace EndustriApi.Services.Abstract;

public interface ICategoryService
{
    Task<List<Category>> GetAllCategories();
    Task<CategoryDto> CreateCategory(CategoryDto category);
    Task<UpdateCategoryDto> UpdateCategory(UpdateCategoryDto category);
    Task<Category> DeleteCategory(int id);
    Task<Category> GetCategoryById(int id);
 
}