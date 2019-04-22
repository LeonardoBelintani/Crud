using Core.Entities;
using Core.Patterns;
using Infra.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service
{
    public class UserService : IUserService
    {
        private readonly ISqlServerContext _serverContext;

        public UserService(ISqlServerContext serverContext)
        {
            _serverContext = serverContext;
        }

        public IQueryable<User> All()
        {
            return _serverContext.Users;
        }

        public Result<bool> Delete(int id, string author)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Login(User user)
        {
            throw new NotImplementedException();
        }

        public Result<bool> Save(User user, string author)
        {
            throw new NotImplementedException();
        }
    }
}
