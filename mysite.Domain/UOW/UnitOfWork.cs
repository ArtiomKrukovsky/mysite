using AllExpirience.Models;
using mysite.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysite.Domain.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        HelpDBContext context = new HelpDBContext();

        public UnitOfWork(IRepository<Help> helprepository, IRepository<Country> countryrepository)
        {
            helpRepository = helprepository;
            countryRepository = countryrepository;
        }

        private IRepository<Help> helpRepository;
        private IRepository<Country> countryRepository;

        public IRepository<Help> Helps
        {
            get
            {
                return helpRepository;
            }
        }

        public IRepository<Country> Countries
        {
            get
            {
                return countryRepository;
            }
        }

        public void SaveChanges()
        {
            Helps.SaveChanges();
        }
    }
}
