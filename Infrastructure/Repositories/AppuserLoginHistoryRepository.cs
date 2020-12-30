﻿using Context;
using Infrastructure.Repositories.Base;
using Model;
using Model.DTO;
using Repositories.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{

    public class AppuserLoginHistoryRepository : RepositoryBase<AppuserLoginHistory>
    {
        private readonly CommonContext _ctx;
        public AppuserLoginHistoryRepository(CommonContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
        public override void InsertOrUpdate(AppuserLoginHistory entity)
        {
            if (entity.Id.Equals(0))
            {
                this.Context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                this.Context.Entry(entity).State = EntityState.Modified;
            }
            _ctx.SaveChanges();
        }
   
    }
}
