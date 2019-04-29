using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Bus.Commands.UserCommands;
using System.Threading;
using System.Threading.Tasks;
using Core.Entities;
using Core.Validations;
using Service.Contracts;
using Core.Enumerators;

namespace Bus.Handlers.UserHandlers
{
    public class SaveUserHandler : IRequestHandler<SaveUserCommand, User>
    {
        private readonly IUserService _service;

        public SaveUserHandler(IUserService service)
        {
            _service = service;
        }

        public Task<User> Handle(SaveUserCommand request, CancellationToken cancellationToken)
        {
           return new Task<User>(() => {
               return _service.Save(request.User, request.Author).Data;
           });
        }
    }
}
