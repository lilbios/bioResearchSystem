﻿using bioResearchSystem.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace bioResearchSystem.Models.Repositories
{
    public interface IRepositoryUser
    {
        public Task CreateAsync(AppUser value);
        public Task<AppUser> GetAsync(string id);
        public  Task<ICollection<AppUser>> GetAllAsync();
        public  Task RemoveAsync(AppUser value);
        public  Task UpdateAsync(AppUser user);
        public Task<AppUser> Find(Expression<Func<AppUser,bool>> expression);

    }
}
