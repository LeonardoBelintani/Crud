using Core.Entities;
using Core.Enumerators;
using Core.Patterns;
using Core.Validations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bus.Commands.UserCommands
{
    public class SaveUserCommand : IRequest<User>
    {
        public readonly string Author;
        public User User { get; set; }
        public UserScenario Scenario { get; set; }
        public UserValidator Validator { get; set; }

        public SaveUserCommand(string author, User user)
        {
            Author = author;
            User = user;
            Scenario = user.Id == 0? UserScenario.Create : UserScenario.Update;

            Validator = new UserValidator(user, Scenario);
            if (!Validator.Execute())
                throw new FlowException(validator: Validator);
        }
    }
}
