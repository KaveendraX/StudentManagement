﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using H2C.Student.Common.DomainModels;

namespace H2C.Student.Repository.Contracts
{
    public interface IStdMgtDbContext : IDisposable
    {

        Database Database { get; }
        int SaveChanges();
        //Task<int> SaveChangesAsync();
        //Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        DbSet Set(Type entityType);
        DbEntityEntry Entry(object entity);
        DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<Studnt> Student { get; set; }
                
        DbContext GetDatabaseContext { get; }
    }
}
