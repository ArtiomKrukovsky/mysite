using AllExpirience.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysite.Domain.Interface
{
    public interface IUnitOfWork
    {
        IRepository<Help> Helps { get; }
        IRepository<Country> Countries { get; }

        void SaveChanges();
    }
}
