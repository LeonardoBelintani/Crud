using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Contracts;
using Core.Entities;
using Core.Enumerators;
using Core.Resources;
using FluentValidation;
using FluentValidation.Results;

namespace Core.Validations
{
    public class UserValidator : AbstractValidator<User>, IValidatorEntity
    {
        private readonly User Model;
        public ValidationResult Result { get; set; }

        public UserValidator(User user, UserScenario scenario)
        {
            Model = user;

            if(scenario != UserScenario.Create)
            {
                RuleFor(x => x.Id)
                    .NotNull()
                    .GreaterThan(0)
                    .WithSeverity(Severity.Error)
                    .WithMessage(UserResource.IdValidate);
            }

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50)
                .WithSeverity(Severity.Error)
                .WithMessage(UserResource.NameValidate);

            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6)
                .MaximumLength(255)
                .EmailAddress()
                .WithSeverity(Severity.Error)
                .WithMessage(UserResource.EmailValidate);

            RuleFor(x => x.Login)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6)
                .MaximumLength(20)
                .WithSeverity(Severity.Error)
                .WithMessage(UserResource.LoginValidate);

            RuleFor(x => x.Password)
                .NotNull()
                .NotEmpty()
                .MinimumLength(6)
                .MaximumLength(20)
                .WithSeverity(Severity.Error)
                .WithMessage(UserResource.PasswordValidate);

            if (scenario == UserScenario.Create)
            {
                RuleFor(x => x.CreatedAt)
                    .NotNull()
                    .GreaterThan(DateTime.Today)
                    .WithSeverity(Severity.Error)
                    .WithMessage(UserResource.CreatedAtValidate);
            }

            if(scenario == UserScenario.Update)
            {
                RuleFor(x => x.UpdatedAt)
                    .NotNull()
                    .GreaterThan(DateTime.Today)
                    .WithSeverity(Severity.Error)
                    .WithMessage(UserResource.UpdatedAtValidate);
            }
        }


        public bool Execute()
        {
            Result = Validate(Model);

            return Result.IsValid;
        }

        public string GetFormattedErrors()
        {
            return Result.Errors.ToList().Select(x => x.ErrorMessage).Aggregate((x, y) => $"{x}, {y}");
        }
    }
}
