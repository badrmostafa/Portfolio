using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository
{
    public interface IGenericRepository<G> where G:class
    {
        IEnumerable<G> AllData();
        G GetById(int id);
        void Create(G g);
        void Edit(G g);
        void Delete(int id);
    }
}
