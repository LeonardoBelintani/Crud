using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Contracts
{
    public interface IValidatorEntity
    {
        ValidationResult Result { get; set; }

        bool Validate();
    }
}
