using CrudRepository.Core;
using CrudRepository.Implementations;

namespace CrudRepository.Installers
{
    public abstract class DictionaryCrudRepositoryInstaller<TId, TData> : CrudRepositoryInstaller<TId, TData>
    {
        protected override ICrudRepository<TId, TData> GetData()
        {
            return new DictionaryCrudRepository<TId, TData >();
        }
    }
}