using System.Collections.Generic;

namespace CrudRepository.Core
{
    public interface ICrudRepository<TId, TData>
    {
        TData GetById(TId id);
        IEnumerable<TData> GetAll();
        void Insert(TId id, TData data);
        void Update(TId id, TData data);
        void DeleteById(TId id);
        void DeleteAll();
        bool IsThisContained(TData data);
        bool IsThisContainedById(TId id);
    }
}