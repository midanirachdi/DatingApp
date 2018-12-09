using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.API.Models;

namespace DatingApp.API.Data
{
    // in c# by convention , all interfaces start with I
    public interface IAuthRepository
    {
        /*
         * Repository pattern:
         *  - minimizes duplicate query logic (in the controller)
         *  - decouples app from persistence framework (EF)
         *  - keep all DB queries in the same place
         */
        Task<User> Register(User user, string password);

        Task<User> Login(string username, string password);

        // return type is bool+
        Task<bool> UserExists(string username);

    }
}
