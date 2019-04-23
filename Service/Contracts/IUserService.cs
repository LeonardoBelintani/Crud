using Core.Entities;
using Core.Patterns;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Service.Contracts
{
    public interface IUserService
    {
        IQueryable<User> All();
        Result<User> Save(User user, string author);
        Result<bool> Delete(int id, string author);
        Result<User> Login(string login, string password);
    }
}
