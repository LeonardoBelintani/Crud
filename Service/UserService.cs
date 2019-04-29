using Core.Entities;
using Core.Patterns;
using Infra.Contracts;
using Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Resources;
using Core.Validations;
using Core.Enumerators;

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
            var user = All().SingleOrDefault(x => x.Id == id);
            if (user is null)
                return new Result<bool>(false, ApplicationResource.UserNotFound);
            else
                _serverContext.RemoveRecord(user);

            return new Result<bool>(true, ApplicationResource.DeleteSuccess);
        }

        public Result<User> Login(string login, string password)
        {
            var user = _serverContext.Users.SingleOrDefault(x => x.Login == login && x.Password == password);
            if (user is null)
                return new Result<User>(true, UserResource.MsgUserLoginSuccess, user);
            else
                return new Result<User>(false, UserResource.MsgUserLoginFail);
        }

        public Result<User> Save(User user, string author)
        {
            if (user.Id == 0)
                _serverContext.InsertRecord(user);
            else
                _serverContext.UpdateRecord(user);

            return new Result<User>(true, "Success", user);
        }
    }
}
