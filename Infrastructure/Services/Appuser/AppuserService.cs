using Context;
using Infrastructure.Repositories;
using Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services.AppuserService
{
    public class AppuserService
    {
        AppuserRepository _appuserRepository = new AppuserRepository(new CommonContext());
        public AppuserDTO Login(string username, string password)
        {
            return _appuserRepository.Login(username, password);
        }
    }
}
