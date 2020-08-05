﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Interface
{
    public interface IRepository<TSource> where TSource : class
    {
        TSource Read(params object[] keyValue);
        TSource Create(TSource item);
        void Create(IEnumerable<TSource> range);
        void Delete(TSource item);
        IQueryable<TSource> ReadAll(Func<TSource, bool> predicate);
        IQueryable<TSource> ReadAll();
        void Update(TSource item);
        void DeleteAll();
        void Save(string tableName);
    }
}
