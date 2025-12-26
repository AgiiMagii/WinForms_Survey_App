using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Survey.Lib
{
    public class Repository
    {
        private readonly DbContext _dbContext;
        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<TEntity> GetEntities<TEntity>() where TEntity : class
        {
            try
            {
                return _dbContext.Set<TEntity>().ToList();
            }
            catch { throw; }
        }
        public void AddEntity<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                _dbContext.Set<TEntity>().Add(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error adding entity: " + ex.Message, ex);
            }
        }
        public TEntity GetEntityById<TEntity>(long id) where TEntity : class
        {
            try
            {
                return _dbContext.Set<TEntity>().Find(id);
            }
            catch { throw; }
        }
        public void UpdateEntity<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating entity: " + ex.Message);
                throw;
            }
        }
    }
}
