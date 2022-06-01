using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using NLayer.Core.Repositories;
// ReSharper disable All

namespace NLayer.Repository.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly AppDbContext _context; //Sadece miras aldığım yerden erişilsin istediğim için protected kullanıyorum

    private readonly DbSet<T> _dbSet; //Kesinlikle set edilmemesi için başka dbsetler vs almaması için readonly!!!

    public GenericRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbSet.FindAsync(id);
    }

    public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
    {
        return _dbSet.AsNoTracking().AsQueryable(); //Asnotracking dememizin sebebi: EFCore çekmiş olduğu verileri memorye almayıp daha performanslı çalışmasını sağlar.
        
    }

    public IQueryable<T> Where(Expression<Func<T, bool>> expression)
    {
        return _dbSet.Where(expression);
    }

    public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
    {
        return await _dbSet.AnyAsync(expression);
    }

    public async Task AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
    }

    public async Task AddRangeAsync(IEnumerable<T> entities)
    {
        await _dbSet.AddRangeAsync(entities);

    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
    }

    public void Remove(T entity)  //Set ettiğimiz bir şeyin async olmasına gerek yok çünkü çok ağır bir iş yapmıyoruz.
    {
        _dbSet.Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        _dbSet.RemoveRange(entities);
    }
}