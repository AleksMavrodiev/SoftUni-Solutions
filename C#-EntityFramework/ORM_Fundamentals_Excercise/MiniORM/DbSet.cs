using System.Collections;

namespace MiniORM
{
    public class DbSet<TEntity> : ICollection<TEntity> where TEntity : class, new()
    {

        internal DbSet(IEnumerable<TEntity> entities)
        {
            this.Entities = entities.ToList();
            this.ChangeTracker = new ChangeTracker<TEntity>(entities);
        }

        public IList<TEntity> Entities { get; set; }

        internal ChangeTracker<TEntity> ChangeTracker { get; set; }

        public int Count => this.Entities.Count;
        public bool IsReadOnly => this.Entities.IsReadOnly;
        public IEnumerator<TEntity> GetEnumerator() => this.Entities.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public void Add(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity can't be null");
            }

            this.Entities.Add(entity);
            this.ChangeTracker.Add(entity);
        }

        public void Clear()
        {
            while (this.Entities.Any())
            {
                TEntity entityToDelete = this.Entities.First();
                this.Remove(entityToDelete);
            }
        }

        public bool Contains(TEntity item)
        {
            return this.Entities.Contains(item);
        }

        public void CopyTo(TEntity[] array, int arrayIndex)
            => this.Entities.CopyTo(array, arrayIndex);        
            
        

        public bool Remove(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity can't be null");
            }
            bool isRemoved = this.Entities.Remove(entity);
            if (isRemoved)
            {
                this.ChangeTracker.Remove(entity);
            }
            return isRemoved;
        }

        public void RemoveRange(IEnumerable<TEntity> entitiesToRemove)
        {
            foreach (TEntity entity in entitiesToRemove)
            {
                this.Remove(entity);
            }
        }

    }
}
