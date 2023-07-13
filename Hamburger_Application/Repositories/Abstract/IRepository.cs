﻿using Hamburger_Application.Entities.Abstract;
using System.Linq.Expressions;

namespace Hamburger_Application.Repositories.Abstract
{
    public interface IRepository<T>
    {
        bool Add(T entity);
        bool Delete(T entity);
        bool Update(T entity);
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> GetWhere(Expression<Func<T, bool>> expression);
        //void AddPhoto(BaseEntity entity, IFormFile formFile);
    }
}