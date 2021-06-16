using System.Collections.Generic;

namespace PieShop.Models.Repositories
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => _allCategories;

        private readonly List<Category> _allCategories = new()
        {
            new Category {Id = 1, Name = "Fruit pies", Description = "All-fruity pies", Pies = new List<Pie>()},
            new Category {Id = 2, Name = "Cheese pies", Description = "Cheesy all the way", Pies = new List<Pie>()},
            new Category {Id = 3, Name = "Seasonal pies", Description = "Get in the mood for a seasonal pie", Pies = new List<Pie>()},
        };
    }
}