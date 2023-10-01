using CritoProject.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CritoProject.Services.Repositiories.MainRepo;

public abstract class MainRepo<TEntity> where TEntity : class
{
    #region database constructor
    private readonly DataContext _db;

    protected MainRepo(DataContext db)
    {
        _db = db;
    }
    #endregion

    #region Gets one object from a table in the database
    public virtual async Task<TEntity> GetOneAsync(Expression<Func<TEntity, bool>> expression)
    {
        try
        {
            var item = await _db.Set<TEntity>().FirstOrDefaultAsync(expression);
            return item!;
        }
        catch (Exception) { return null!; } 
    }
    #endregion

    #region Gets all object from a table in the database
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        try
        {
            return await _db.Set<TEntity>().ToListAsync();
        }
        catch (Exception) { return null!; }
    }
    public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression)
    {
        try
        {
            return await _db.Set<TEntity>().Where(expression).ToListAsync();
        }
        catch (Exception) { return null!; }
    }
    #endregion

    #region Adds one object to the table in the database
    public virtual async Task<TEntity> AddOneAsync(TEntity entity)
    {
        try
        {
            _db.Set<TEntity>().Add(entity);
            await _db.SaveChangesAsync();
            return entity;
        } 
        catch (Exception) { return null!; }
    }
    #endregion
}
