using Context;
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

    public class AppuserRepository:RepositoryBase<Appuser>
    {
        private readonly CommonContext _ctx;
        public AppuserRepository(CommonContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }
        public override void InsertOrUpdate(Appuser entity)
        {
            if (entity.Id.Equals(0))
            {
                this.Context.Entry(entity).State = EntityState.Added;
            }
            else
            {
                this.Context.Entry(entity).State = EntityState.Modified;
            }
        }
        public AppuserDTO Login(string username, string password)
        {
            var data = GetAll.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (data != null)
            {
                return new AppuserDTO
                {
                    Id= data.Id,
                    FullName = data.FirstName + " " + data.LastName,
                    Username = data.Username
                };
            }
            return null;
        }
    }
}
