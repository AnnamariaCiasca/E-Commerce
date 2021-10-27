﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Core.Interfaces
{
    public interface IRepository<T>
    {
        List<T> Fetch();
        T GetById(int id);
        bool Add(T item);
        bool Update(T updatedItem);
        bool Delete(int id);
    }
}
