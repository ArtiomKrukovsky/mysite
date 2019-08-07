using AllExpirience.Models;
using mysite.Domain.Interface;
using mysite.Domain.Repository;
using mysite.Domain.UOW;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AllExpirience.Util
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IRepository<Help>>().To<GeneralRepository<Help>>();
            Bind<IRepository<Country>>().To<GeneralRepository<Country>>();
        }
    }
}