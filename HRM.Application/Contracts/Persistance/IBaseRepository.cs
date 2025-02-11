﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Application.Contracts.Persistance
{
    public interface IBaseRepository <T> where T : class
    {
        Task<T> Get(int id);

        /// <summary>
        /// برای زمانی که لیست بازگردانده شده لازم به خواندن ندارد
        /// در این حالت changeTracker فعال نمیشود
        /// </summary>
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T entity);
        Task Update(T entity);
        Task<bool> Exists(int id);
        Task Delete(T entity);

    }
}
