using cd4_api.Models;
using cd4_api.ViewModels.Client.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cd4_api.Services.Client.Users
{
    public interface IUserService
    {
        Task<Dbuser> Login(UserLoginViewModel userLoginViewModel);

        Task<int> Register(UserRegisterViewModel userRegisterViewModel);
    }
}
