using Context;
using Infrastructure.Repositories;
using Model;
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
        AppuserLoginHistoryRepository _appuserLoginHistoryRepository = new AppuserLoginHistoryRepository(new CommonContext());
        public AppuserDTO Login(string username, string password)
        {
            return _appuserRepository.Login(username, password);
        }
        public void InsertLoginHistory(int id)
        {
            var loginHistory = new AppuserLoginHistory();
            loginHistory.AppuserId = id;
            loginHistory.LoginDate = DateTime.Now;
            loginHistory.LogoutDate = null;
            _appuserLoginHistoryRepository.InsertOrUpdate(loginHistory);
        }
    }
}
