using MyPortfolio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPortfolio.IUnitOfWork
{
    public interface IUnitOfWork<J> where J:class
    {
        IGenericRepository<J> Entity { get;}
        void Save();

    }
}
