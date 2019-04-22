using Core.Entities;
using Infra.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Contexts
{
    public class SqlServerContext : DbContext, ISqlServerContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options)
        {

        }

        public IQueryable<User> Users => Set<User>(); 
    }
}
