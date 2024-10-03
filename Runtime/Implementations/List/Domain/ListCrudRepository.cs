using System.Collections.Generic;
using CrudRepository.Core;

namespace CrudRepository.Implementations
{
    public class ListCrudRepository<TData> : ICrudRepository<int, TData>
    {
        private readonly List<TData> _datas = new List<TData>();

        public IEnumerable<TData> GetAll()
        {
            return _datas as IEnumerable<TData>;
        }

        public TData GetById(int id)
        {
            return _datas[id];
        }

        public void Insert(TData data)
        {
            _datas.Add(data);
        }

        public void Update(TData data)
        {
            int index = _datas.FindIndex(x => x.Equals(data));

            _datas[index] = data;
        }

        public void DeleteById(int id)
        {
            _datas.RemoveAt(id);
        }

        public void DeleteAll()
        {
            _datas.Clear();
        }

        public bool IsThisContained(TData dataType)
        {
            bool isContained = _datas.Contains(dataType);

            return isContained;
        }

        public bool IsThisContainedById(int id)
        {
            bool isContained = _datas.Count > id;

            return isContained;
        }
    }
}