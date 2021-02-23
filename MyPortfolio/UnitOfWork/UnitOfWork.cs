using MyPortfolio.Models;
using MyPortfolio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.IUnitOfWork
{
    public class UnitOfWork<K> : IUnitOfWork<K> where K : class
    {
        DataContext db;
        IGenericRepository<K> gr;
        public UnitOfWork(DataContext context)
        {
            db = context;
        }
        public IGenericRepository<K> Entity 
        {
            get
            {
                return gr ?? (gr = new GenericRepository<K>(db)); 
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
