using CrudRepository.Core;
using DependencyInjector.Installers;

namespace CrudRepository.Installers
{
    public abstract class CrudRepositoryInstaller<TId, TDataType> : SingleMonoInstaller<ICrudRepository<TId, TDataType>>
    {

    }
}