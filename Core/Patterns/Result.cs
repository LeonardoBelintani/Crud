using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Patterns
{
    public abstract class Result<T>
    {
        public bool Status { get; private set; }
        public string Message { get; private set; }
        public T Data { get; private set; }
        
        public static implicit operator bool(Result<T> result)
        {
            return result.Status;
        }
    }
}
