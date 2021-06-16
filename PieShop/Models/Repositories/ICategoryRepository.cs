using System.Collections.Generic;

namespace PieShop.Models.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}