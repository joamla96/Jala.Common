using System.Collections.Generic;
using System.Linq;

namespace Jala.Common.Repository
{
    public class BaseRepository<T>
    {
        private List<T> repository = new List<T>();

        public virtual void Add(T item)
        {
            repository.Add(item);
        }

        public virtual void Remove(T item)
        {
            repository.Remove(item);
        }

        public virtual List<T> GetAll(bool AsCopy = false)
        {
            if (AsCopy)
            {
                return repository.ToList<T>();
            }
            else return repository;
        }
    }
}
