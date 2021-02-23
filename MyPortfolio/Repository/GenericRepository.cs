using Microsoft.EntityFrameworkCore;
using MyPortfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.Repository
{
    public class GenericRepository<G> : IGenericRepository<G> where G : class
    {
        DataContext db;
        DbSet<G> table = null;
        public GenericRepository(DataContext context)
        {
            db = context;
            table = db.Set<G>();
        }
        public IEnumerable<G> AllData()
        {
           return table.ToList();
        }

        public void Create(G g)
        {
            table.Add(g);
        }

        public void Delete(int id)
        {
            G g = GetById(id);
            table.Remove(g);
        }

        public void Edit(G g)
        {
            table.Attach(g);
            db.Entry(g).State = EntityState.Modified; 
        }

        public G GetById(int id)
        {
            G g = table.Find(id);
            return g;
        }
    }
}
