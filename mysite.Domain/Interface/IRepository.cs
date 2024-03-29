﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysite.Domain.Interface
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll();
        void Add(T Entity);
        void SaveChanges();
    }
}
