using Core.Entities;
using Infra.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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
        /// <summary>
        /// Insert new record in database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool InsertRecord<T>(T entity) where T : class
        {
            Add(entity);
            var rowsAffected = SaveChanges();

            return rowsAffected > 0;
        }
        /// <summary>
        /// Insert many records in database
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool InsertRecords<T>(IList<T> entity) where T : class
        {
            AddRange(entity);
            var rowsAffected = SaveChanges();

            return rowsAffected > 0;
        }
        /// <summary>
        /// Update a record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool UpdateRecord<T>(T entity) where T : class
        {
            Update(entity);
            var rowsAffected = SaveChanges();

            return rowsAffected > 0;
        }
        /// <summary>
        /// Update a lot of records
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool UpdateRecords<T>(T entity) where T : class
        {
            UpdateRange(entity);
            var rowsAffected = SaveChanges();

            return rowsAffected > 0;
        }
        /// <summary>
        /// Remove record
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool RemoveRecord<T>(T entity) where T : class
        {
            Remove(entity);
            var rowsAffected = SaveChanges();

            return rowsAffected > 0;
        }
        /// <summary>
        /// Remove a lot of records
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool RemoveRecords<T>(T entity) where T : class
        {
            RemoveRange(entity);
            var rowsAffected = SaveChanges();

            return rowsAffected > 0;
        }
        /// <summary>
        /// Start a new transaction in basic level
        /// </summary>
        public void BeginTransaction()
        {
            BeginTransaction();
        }
        /// <summary>
        /// Commit actual transaction
        /// </summary>
        public void Commit()
        {
            Commit();
        }
        /// <summary>
        /// Roolback actual transaction
        /// </summary>
        public void RollBack()
        {
            RollBack();
        }

        public IQueryable<User> Users => Set<User>();
        public IQueryable<Client> Clients => Set<Client>();
        public IQueryable<ClientAddress> ClientAddresses => Set<ClientAddress>();
        public IQueryable<ClientEmail> ClientEmails => Set<ClientEmail>();
        public IQueryable<ClientPhone> ClientPhones => Set<ClientPhone>();
    }
}
