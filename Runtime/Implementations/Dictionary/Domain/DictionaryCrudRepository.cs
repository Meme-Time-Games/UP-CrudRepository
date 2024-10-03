using System.Collections.Generic;
using CrudRepository.Core;

namespace CrudRepository.Implementations
{
    public class DictionaryCrudRepository<TId, TData> : ICrudRepository<TId, TData> where TData : IIdentifiable<TId>
    {
        private Dictionary<TId, TData> _datas = new Dictionary<TId, TData>();

        public IEnumerable<TData> GetAll()
        {
            return _datas as IEnumerable<TData>;
        }

        public TData GetById(TId id)
        {
            return _datas[id];
        }

        public void Insert(TData data)
        {
            _datas.Add(data.Id, data);
        }

        public void Update(TData data)
        {
            TId key = data.Id;

            _datas[key] = data;
        }

        public void DeleteById(TId id)
        {
            _datas.Remove(id);
        }

        public void DeleteAll()
        {
            _datas.Clear();
        }

        public bool IsThisContained(TData dataType)
        {
            bool isContained = _datas.ContainsKey(dataType.Id);

            return isContained;
        }

        public bool IsThisContainedById(TId id)
        {
            bool isContained = _datas.ContainsKey(id);

            return isContained;
        }
    }
}