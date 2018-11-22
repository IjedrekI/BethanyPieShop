using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanyPieShop.Models
{
    public class MockPiesRepository : IPieRepository
    {
        private List<Pie> _pies;

        public MockPiesRepository()
        {
            if (_pies == null)
            {
                InitializePies();
            }

        }



        public IEnumerable<Pie> GetAllPies()
        {
            return _pies;
        }

        public Pie GetPieById(int pieId)
        {
            return _pies.FirstOrDefault(p => p.Id == pieId);
        }
        private void InitializePies()
        {
            _pies = new List<Pie>
            {
            new Pie {Id = 1, Name = "Aple", ShortDescription ="ShortDescription", LongDescription = "LongDescription", Price = 10, ImageUrl = null, ImageThumbnailUrl = null, IsPieOfTheWeek = false},
            new Pie {Id = 2, Name = "Aple", ShortDescription ="ShortDescription", LongDescription = "LongDescription", Price = 10, ImageUrl = null, ImageThumbnailUrl = null, IsPieOfTheWeek = false},
            new Pie {Id = 3, Name = "Aple", ShortDescription ="ShortDescription", LongDescription = "LongDescription", Price = 10, ImageUrl = null, ImageThumbnailUrl = null, IsPieOfTheWeek = false}
            };
        }

    }
    
}
