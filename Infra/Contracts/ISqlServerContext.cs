using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infra.Contracts
{
    public interface ISqlServerContext
    {
        bool InsertRecord<T>(T entity) where T : class;
        bool InsertRecords<T>(IList<T> entity) where T : class;
        bool UpdateRecord<T>(T entity) where T : class;
        bool UpdateRecords<T>(T entity) where T : class;
        bool RemoveRecord<T>(T entity) where T : class;
        bool RemoveRecords<T>(T entity) where T : class;
        void BeginTransaction();
        void Commit();
        void RollBack();
        IQueryable<User> Users { get; }
        IQueryable<Client> Clients { get; }
        IQueryable<ClientAddress> ClientAddresses { get; }
        IQueryable<ClientEmail> ClientEmails { get; }
        IQueryable<ClientPhone> ClientPhones { get; }
    }
}
