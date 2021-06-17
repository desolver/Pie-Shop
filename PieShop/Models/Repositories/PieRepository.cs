using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PieShop.Models.Repositories
{
    public class PieRepository : IPieRepository
    {
        private readonly AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pie> AllPies =>
            _appDbContext.Pies.Include(pie => pie.Category);

        public IEnumerable<Pie> PiesOfTheWeek =>
            _appDbContext.Pies.Include(pie => pie.Category).Where(pie => pie.IsPieOfTheWeek);

        public Pie GetPieById(int pieId) => _appDbContext.Pies.FirstOrDefault(pie => pie.Id == pieId);
    }
}