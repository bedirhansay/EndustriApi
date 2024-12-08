using AutoMapper;
using EndustriApi.DatabaseContext;
using EndustriApi.DTO;
using EndustriApi.Entity;
using EndustriApi.Services.Abstract;
using Microsoft.EntityFrameworkCore;

namespace EndustriApi.Services.Concrete;

public class CategoryService : ICategoryService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;


    public CategoryService(ApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<List<Category>> GetAllCategories()
    {
        var categories = await _context.Categories.ToListAsync();
        return categories;
    }
    public async Task<CategoryDto> CreateCategory(CategoryDto createCategoryCommand)
    {

        var categoryEntity = _mapper.Map<Category>(createCategoryCommand);
        var createdEntity = await _context.Categories.AddAsync(categoryEntity);
        await _context.SaveChangesAsync();

        var resultDto = _mapper.Map<CategoryDto>(createdEntity.Entity);

        return resultDto;
    }
    public async Task<UpdateCategoryDto> UpdateCategory(UpdateCategoryDto updateCategoryCommand)
    {
        var existingCategory = await _context.Categories.FindAsync(updateCategoryCommand.CategoryId);

        if (existingCategory == null)
        {
            throw new Exception("Category not found");
        }

        _mapper.Map(updateCategoryCommand, existingCategory);

        await _context.SaveChangesAsync();

        var updatedDto = _mapper.Map<UpdateCategoryDto>(existingCategory);
        return updatedDto;
    }
    public async Task<Category> DeleteCategory(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category == null)
        {
            throw new Exception("Silinmek istenen kategori bulunamadı.");
        }
        var deletedItem = _context.Categories.Remove(category);
       await _context.SaveChangesAsync();
       var resultDto = _mapper.Map<Category>(deletedItem.Entity);
       
        return resultDto;
        
   }
    public async Task<Category> GetCategoryById(int id)
    {
        var category = await _context.Categories.FindAsync(id);
        if (category == null)
        {
            throw new Exception("İd ile ilgili alan bulunamadı");
        }
        var resultDto = _mapper.Map<Category>(category);
        return category;
    }
}