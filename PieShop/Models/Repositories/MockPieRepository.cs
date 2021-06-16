using System.Collections.Generic;
using System.Linq;

namespace PieShop.Models.Repositories
{
    public class MockPieRepository : IPieRepository
    {
        public IEnumerable<Pie> AllPies => _allPies;
        public IEnumerable<Pie> PiesOfTheWeek { get; }

        private readonly ICategoryRepository _categoryRepository;
        private readonly List<Pie> _allPies;

        public MockPieRepository()
        {
            _categoryRepository = new MockCategoryRepository();

            var categories = _categoryRepository.AllCategories.ToArray();
            
            _allPies = new List<Pie>
            {
                new Pie {Id = 1, Name = "Strawberry Pie", Price = 15.95M, ShortDescription = "", LongDescription = "", Category = categories[0]},
                new Pie {Id = 2, Name = "Cheese cake", Price = 18.95M, ShortDescription = "", LongDescription = "", Category = categories[1]},
                new Pie {Id = 3, Name = "Rhubarb Pie", Price = 15.95M, ShortDescription = "", LongDescription = "", Category = categories[2]},
                new Pie {Id = 4, Name = "Pumpkin Pie", Price = 12.95M, ShortDescription = "", LongDescription = "", Category = categories[2]}
            };
        }

        public Pie GetPieById(int pieId)
        {
            return _allPies.FirstOrDefault(pie => pie.Id == pieId);
        }
    }
}