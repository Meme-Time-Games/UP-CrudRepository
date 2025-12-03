using System.Collections.Generic;
using CrudRepository.Core;

namespace CrudRepository.Implementations
{
    public class DictionaryCrudRepository<TId, TData> : ICrudRepository<TId, TData> where TData : class
    {
        private Dictionary<TId, TData> _datas = new Dictionary<TId, TData>();
        
        public IEnumerable<TData> GetAll()
        {
            List<TData> datas = new List<TData>();

            foreach (var dataKV in _datas)
            {
                datas.Add(dataKV.Value);
            }
            
            return datas;
        }

        public TData GetById(TId id)
        {
            if (!IsThisContainedById(id))
            {
                return null;
            }
            
            return _datas[id];
        }

        public void Insert(TId id, TData data)
        {
            _datas.Add(id, data);
        }

        public void Update(TId id, TData data)
        {
            _datas[id] = data;
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
            bool isContained = _datas.ContainsValue(dataType);

            return isContained;
        }

        public bool IsThisContainedById(TId id)
        {
            bool isContained = _datas.ContainsKey(id);

            return isContained;
        }
    }
}