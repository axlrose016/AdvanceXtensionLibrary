﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceXtensionLibrary_Repository.Core.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Get Record
        TEntity Get(int id); // Get Specific Record with ID.
        IEnumerable<TEntity> GetAll(); // Get All Record.
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate); // Get Record with predicate.

        //Add Record
        void Add(TEntity entity); // Add Record
        void AddRange(IEnumerable<TEntity> entities); // Add Records

        //Remove Record
        void Remove(TEntity entity); // Remove Record
        void RemoveRange(IEnumerable<TEntity> entities); // Remove Records.
    }
}
