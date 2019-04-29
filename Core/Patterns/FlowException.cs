using Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Patterns
{
    public class FlowException : Exception
    {
        public IValidatorEntity Validator { get; }

        public FlowException(string message) : base(message)
        { }

        public FlowException(IValidatorEntity validator) : base(message: validator.GetFormattedErrors())
        { }
    }
}
