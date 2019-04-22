using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Contracts
{
    public interface ISqlServerContext
    {
        IQueryable<User> Users { get; }
    }
}
