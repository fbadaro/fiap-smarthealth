﻿using Fiap.Smarthealth.Core.Entities;
using Fiap.Smarthealth.Data.Repository;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Smarthealth.Data.SQLServer.Repository;

public class RepositorySQLBase<TEntity, TPrimaryKey> : IRepositoryBase<TEntity, TPrimaryKey>
    where TEntity : class, IEntity<TPrimaryKey>
{
    protected readonly SmarthealthDBContext _context;

    public RepositorySQLBase(SmarthealthDBContext context)
    {
        _context = context;
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(TPrimaryKey id)
    {        
        _context.Remove(await GetById(id));
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
    }

    public async Task<TEntity> GetById(TPrimaryKey id)
    {               
        var entity = await _context.Set<TEntity>().FindAsync(id);
        return entity == null ? throw new Exception("Entidade não encontrada na base de dados") : entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public void Dispose()
    {
        _context?.Dispose();
    }
}
