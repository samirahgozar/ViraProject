using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Vira.Core.Domain;

namespace Vira.Services.Authentication
{
    public interface IAuthRepository
    {
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExist(string username);
    }
}
